
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Knigosha.Controllers;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels.AccountViewModels;
using Knigosha.Persistence;
using Knigosha.Utilities;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Knigosha.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _context = context; 
        }

        [TempData]
        public string ErrorMessage { get; set; }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (model.Email.IndexOf('@') > -1)
            {
                //Validate email format
                var emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                 @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                 @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                var re = new Regex(emailRegex);
                if (!re.IsMatch(model.Email))
                {
                    ModelState.AddModelError("Email", "Неверный адрес");
                }
            }
            else
            {
                //validate Username format
                string emailRegex = @"^[a-zA-Z0-9]*$";
                var re = new Regex(emailRegex);
                if (!re.IsMatch(model.Email))
                {
                    ModelState.AddModelError("Email", "Имя пользователя неверно");
                }
            }

            if (ModelState.IsValid)
            {
                var userName = model.Email;
                if (userName.IndexOf('@') > -1)
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    if (user == null)
                    {
                        ModelState.AddModelError(string.Empty, "Неудачная попытка. Попробуйте еще");
                        return View(model);
                    }

                    userName = user.UserName;
                    user.LastLogin = DateTime.Now.ToString("g");
                    user.LoginTimes++;
                    await _userManager.UpdateAsync(user);
                }
                else
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    if (user == null)
                    {
                        ModelState.AddModelError(string.Empty, "Неудачная попытка. Попробуйте еще");
                        return View(model);
                    }

                    userName = user.UserName;
                    user.LastLogin = DateTime.Now.ToString("g");
                    user.LoginTimes++;
                    await _userManager.UpdateAsync(user);
                }
                
                await _signInManager.PasswordSignInAsync(userName, model.Password, model.RememberMe, lockoutOnFailure: false);
                _logger.LogInformation("User logged in.");
                return RedirectToLocal(returnUrl);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> LoginWith2fa(bool rememberMe, string returnUrl = null)
        {
            // Ensure the user has gone through the username & password screen first
            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();

            if (user == null)
            {
                throw new ApplicationException($"Unable to load two-factor authentication user.");
            }

            var model = new LoginWith2faViewModel { RememberMe = rememberMe };
            ViewData["ReturnUrl"] = returnUrl;

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginWith2fa(LoginWith2faViewModel model, bool rememberMe, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var authenticatorCode = model.TwoFactorCode.Replace(" ", string.Empty).Replace("-", string.Empty);

            var result = await _signInManager.TwoFactorAuthenticatorSignInAsync(authenticatorCode, rememberMe, model.RememberMachine);

            if (result.Succeeded)
            {
                // save last login
                user.LastLogin = DateTime.Now.ToString("g"); 
                var lastLoginResult = await _userManager.UpdateAsync(user);
                if (!lastLoginResult.Succeeded)
                {
                    throw new InvalidOperationException($"Unexpected error occurred setting the last login date" +
                                                        $" ({lastLoginResult.ToString()}) for user with ID '{user.Id}'.");
                }
                _logger.LogInformation("User with ID {UserId} logged in with 2fa.", user.Id);
                return RedirectToLocal(returnUrl);
            }
            else if (result.IsLockedOut)
            {
                _logger.LogWarning("User with ID {UserId} account locked out.", user.Id);
                return RedirectToAction(nameof(Lockout));
            }
            else
            {
                _logger.LogWarning("Invalid authenticator code entered for user with ID {UserId}.", user.Id);
                ModelState.AddModelError(string.Empty, "Invalid authenticator code.");
                return View();
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> LoginWithRecoveryCode(string returnUrl = null)
        {
            // Ensure the user has gone through the username & password screen first
            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new ApplicationException($"Unable to load two-factor authentication user.");
            }

            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginWithRecoveryCode(LoginWithRecoveryCodeViewModel model, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new ApplicationException($"Unable to load two-factor authentication user.");
            }

            var recoveryCode = model.RecoveryCode.Replace(" ", string.Empty);

            var result = await _signInManager.TwoFactorRecoveryCodeSignInAsync(recoveryCode);

            if (result.Succeeded)
            {
                user.LastLogin = DateTime.Now.ToString("g");
                var lastLoginResult = await _userManager.UpdateAsync(user);
                if (!lastLoginResult.Succeeded)
                {
                    throw new InvalidOperationException($"Unexpected error occurred setting the last login date" +
                                                        $" ({lastLoginResult.ToString()}) for user with ID '{user.Id}'.");
                }
                _logger.LogInformation("User with ID {UserId} logged in with a recovery code.", user.Id);
                return RedirectToLocal(returnUrl);
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning("User with ID {UserId} account locked out.", user.Id);
                return RedirectToAction(nameof(Lockout));
            }
            else
            {
                _logger.LogWarning("Invalid recovery code entered for user with ID {UserId}", user.Id);
                ModelState.AddModelError(string.Empty, "Invalid recovery code entered.");
                return View();
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            var vm = new RegisterViewModel
            {
                Countries =
                    _context.Countries.Select(c => new SelectListItem() {Value = c.Title, Text = c.Title}).ToList(),
                MainCitiesRussia = _context.Cities.Select(c => new SelectListItem()
                {
                    Value = c.Title, Text = c.Title
                }).ToList()
            };


            return View(vm);
        }

        [HttpGet]
        [AllowAnonymous]
        public JsonResult GetSchoolList(string cityId)
        {
            var schoolList = new SelectList(_context.Schools.Where(s => s.City.Title == cityId), "Title", "Title");
            return Json(schoolList);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            var userType = model.UserType;

            switch (userType)
            {
                case (UserTypes.Student):
                    if (ModelState.IsValid)
                    {
                        var student = new Student
                        {
                            Name = model.Name,
                            Surname = model.Surname,
                            UserType = model.UserType,
                            UserName = model.UserName,
                            Password = model.Password,
                            Email = model.Email ?? model.ParentEmail,
                            PhoneNumber = model.PhoneNumber,
                            City = !string.IsNullOrWhiteSpace(model.CityInput)? model.CityInput: model.MainCityRussia,
                            School = !string.IsNullOrWhiteSpace(model.SchoolInput) ? model.SchoolInput : model.SchoolSelect,
                            Grade = model.Grade,
                            Parallel = model.Parallel,
                            Country = model.Country,
                            SubscribedToNewsletter = model.SubscribedToNewsletter
                        };
                        var result = await _userManager.CreateAsync(student, model.Password);
                        await _userManager.AddToRoleAsync(student, "User");
                        if (result.Succeeded)
                        {
                            await new UserSubscriptionController(_context).CreateFree(student);
                            await _signInManager.SignInAsync(student, isPersistent: false);
                            _logger.LogInformation("Student created a new account with password.");
                            return RedirectToLocal(returnUrl);
                        }
                        AddErrors(result);
                    }
                    break;

                case (UserTypes.Parent):
                    if (ModelState.IsValid)
                    {
                        var family = new Family
                        {
                            Name = model.Name,
                            Surname = model.Surname,
                            UserType = model.UserType,
                            UserName = model.UserName,
                            Password = model.Password,
                            Email = model.RequiredEmail,
                            PhoneNumber = model.PhoneNumber,
                            City = !string.IsNullOrWhiteSpace(model.CityInput) ? model.CityInput : model.MainCityRussia,
                            Grade = model.Grade,
                            Country = model.Country,
                            SubscribedToNewsletter = model.SubscribedToNewsletter
                        };
                        var result = await _userManager.CreateAsync(family, model.Password);
                        await _userManager.AddToRoleAsync(family, "User");
                        if (result.Succeeded)
                        {
                            await new UserSubscriptionController(_context).CreateFree(family);
                            var group = await _context.AllFamiliesGroup.FirstAsync();
                            group.Families.Add(family);
                            await _context.SaveChangesAsync();
                            await _signInManager.SignInAsync(family, isPersistent: false);
                            _logger.LogInformation("Family created a new account with password.");
                            return RedirectToLocal(returnUrl);
                        }
                        AddErrors(result);
                    }
                    break;

                case (UserTypes.Teacher):
                    if (ModelState.IsValid)
                    {
                        var schoolClass = new Class
                        {
                            Name = model.Name,
                            Surname = model.Surname,
                            UserType = model.UserType,
                            UserName = model.UserName,
                            Password = model.Password,
                            Email = model.RequiredEmail,
                            PhoneNumber = model.PhoneNumber,
                            City = !string.IsNullOrWhiteSpace(model.CityInput) ? model.CityInput : model.MainCityRussia,
                            School = !string.IsNullOrWhiteSpace(model.SchoolInput) ? model.SchoolInput : model.SchoolSelect,
                            Grade = model.Grade,
                            Country = model.Country,
                            SubscribedToNewsletter = model.SubscribedToNewsletter
                        };
                        var result = await _userManager.CreateAsync(schoolClass, model.Password);
                        await _userManager.AddToRoleAsync(schoolClass, "User");
                        if (result.Succeeded)
                        {
                            await new UserSubscriptionController(_context).CreateFree(schoolClass);
                            var group = await _context.AllClassesGroup.FirstAsync();
                            group.Classes.Add(schoolClass);
                            await _context.SaveChangesAsync();
                            await _signInManager.SignInAsync(schoolClass, isPersistent: false);
                            _logger.LogInformation("Family created a new account with password.");
                            return RedirectToLocal(returnUrl);
                        }
                        AddErrors(result);
                    }
                    break;
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            // Request a redirect to the external login provider.
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account", new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            if (remoteError != null)
            {
                ErrorMessage = $"Error from external provider: {remoteError}";
                return RedirectToAction(nameof(Login));
            }
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            // Sign in the user with this external login provider if the user already has a login.
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                // save last login 
                var user = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
                if (user == null)
                {
                    return NotFound("Unable to load user for update last login.");
                }
                user.LastLogin = DateTime.Now.ToString("g");
                var lastLoginResult = await _userManager.UpdateAsync(user);
                if (!lastLoginResult.Succeeded)
                {
                    throw new InvalidOperationException($"Unexpected error occurred setting the last login date" +
                                                        $" ({lastLoginResult.ToString()}) for user with ID '{user.Id}'.");
                }
                //
                _logger.LogInformation("User logged in with {Name} provider.", info.LoginProvider);
                return RedirectToLocal(returnUrl);
            }
            if (result.IsLockedOut)
            {
                return RedirectToAction(nameof(Lockout));
            }
            else
            {
                // If the user does not have an account, then ask the user to create an account.
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["LoginProvider"] = info.LoginProvider;
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                return View("ExternalLogin", new ExternalLoginViewModel { Email = email });
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await _signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    throw new ApplicationException("Error loading external login information during confirmation.");
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        _logger.LogInformation("User created an account using {Name} provider.", info.LoginProvider);
                        return RedirectToLocal(returnUrl);
                    }
                }
                AddErrors(result);
            }

            ViewData["ReturnUrl"] = returnUrl;
            return View(nameof(ExternalLogin), model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{userId}'.");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return RedirectToAction(nameof(ForgotPasswordConfirmation));
                }

                // For more information on how to enable account confirmation and password reset please
                // visit https://go.microsoft.com/fwlink/?LinkID=532713
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.ResetPasswordCallbackLink((user.Id), code, Request.Scheme);
                await _emailSender.SendEmailAsync(model.Email, "Reset Password",
                   $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>");
                return RedirectToAction(nameof(ForgotPasswordConfirmation));
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code = null)
        {
            if (code == null)
            {
                throw new ApplicationException("A code must be supplied for password reset.");
            }
            var model = new ResetPasswordViewModel { Code = code };
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }
            AddErrors(result);
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

    }

}
