﻿using Knigosha.Core.Models;
using Knigosha.Persistence.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Knigosha.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookNote> BookNotes { get; set; }
        public DbSet<BookRating> BookRatings { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<ActivationKey> ActivationKeys { get; set; }
        public DbSet<MarkedBook> MarkedBooks { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SentMessage> SentMessages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Text> Texts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var jsonStateList = MyAppResources.CountriesJson;
            var states = JsonConvert.DeserializeObject<List<Country>>(jsonStateList);
            builder.Entity<Country>().HasData(states);

            var jsonCitiesList = MyAppResources.CitiesJson;
            var cities = JsonConvert.DeserializeObject<List<City>>(jsonCitiesList);
            builder.Entity<City>().HasData(cities);

            var jsonSchoolsMoskowList = MyAppResources.SchoolsMoskowJson;
            var schoolsMoskow = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsMoskowList);
            builder.Entity<School>().HasData(schoolsMoskow);

            var jsonSchoolsPetersburgList = MyAppResources.SchoolsPetersburgJson;
            var schoolsPetersburg = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsPetersburgList);
            builder.Entity<School>().HasData(schoolsPetersburg);

            var jsonSchoolsUfaList = MyAppResources.SchoolsUfaJson;
            var schoolsUfa = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsUfaList);
            builder.Entity<School>().HasData(schoolsUfa);

            var jsonSchoolsSamaraList = MyAppResources.SchoolsSamaraJson;
            var schoolsSamara = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsSamaraList);
            builder.Entity<School>().HasData(schoolsSamara);

            var jsonSchoolsVolgogradList = MyAppResources.SchoolsVolgogradJson;
            var schoolsVolgograd = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsVolgogradList);
            builder.Entity<School>().HasData(schoolsVolgograd);

            var jsonSchoolsChelyabinskList = MyAppResources.SchoolsChelyabinskJson;
            var schoolsChelyabinsk = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsChelyabinskList);
            builder.Entity<School>().HasData(schoolsChelyabinsk);

            var jsonSchoolsRostovList = MyAppResources.SchoolsRostovJson;
            var schoolsRostov = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsRostovList);
            builder.Entity<School>().HasData(schoolsRostov);

            var jsonSchoolsHabarovskList = MyAppResources.SchoolsHabarovskJson;
            var schoolsHabarovsk = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsHabarovskList);
            builder.Entity<School>().HasData(schoolsHabarovsk);

            var jsonSchoolsPermList = MyAppResources.SchoolsPermJson;
            var schoolsPerm = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsPermList);
            builder.Entity<School>().HasData(schoolsPerm);

            var jsonSchoolsOmskList = MyAppResources.SchoolsOmskJson;
            var schoolsOmsk = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsOmskList);
            builder.Entity<School>().HasData(schoolsOmsk);

            var jsonSchoolsNovosibirskList = MyAppResources.SchoolsNovosibirskJson;
            var schoolsNovosibirsk = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsNovosibirskList);
            builder.Entity<School>().HasData(schoolsNovosibirsk);

            var jsonSchoolsNovgorodList = MyAppResources.SchoolsNovgorodJson;
            var schoolsNovgorod = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsNovgorodList);
            builder.Entity<School>().HasData(schoolsNovgorod);

            var jsonSchoolsKrasnoyarskList = MyAppResources.SchoolsKrasnoyarskJson;
            var schoolsKrasnoyarsk = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsKrasnoyarskList);
            builder.Entity<School>().HasData(schoolsKrasnoyarsk);

            var jsonSchoolsKrasnodarList = MyAppResources.SchoolsKrasnodarJson;
            var schoolsKrasnodar = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsKrasnodarList);
            builder.Entity<School>().HasData(schoolsKrasnodar);

            var jsonSchoolsKaliningradList = MyAppResources.SchoolsKaliningradJson;
            var schoolsKaliningrad = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsKaliningradList);
            builder.Entity<School>().HasData(schoolsKaliningrad);

            var jsonSchoolsKazanList = MyAppResources.SchoolsKazanJson;
            var schoolsKazan = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsKazanList);
            builder.Entity<School>().HasData(schoolsKazan);

            var jsonSchoolsEkatirenburgList = MyAppResources.SchoolsEkatirenburgJson;
            var schoolsEkatirenburg = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsEkatirenburgList);
            builder.Entity<School>().HasData(schoolsEkatirenburg);

            var jsonSchoolsVoronezList = MyAppResources.SchoolsVoronezJson;
            var schoolsVoronez = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsVoronezList);
            builder.Entity<School>().HasData(schoolsVoronez);

            var jsonSchoolsVladivostokList = MyAppResources.SchoolsVladivostokJson;
            var schoolsVladivostok = JsonConvert.DeserializeObject<List<School>>(jsonSchoolsVladivostokList);
            builder.Entity<School>().HasData(schoolsVladivostok);

            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new AnswerConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new BookNoteConfiguration());
            builder.ApplyConfiguration(new BookRatingConfiguration());
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new FamilyConfiguration());
            builder.ApplyConfiguration(new ActivationKeyConfiguration());
            builder.ApplyConfiguration(new MarkedBookConfiguration());
            builder.ApplyConfiguration(new QuestionConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new UserSubscriptionConfiguration());
            builder.ApplyConfiguration(new SubscriptionConfiguration());
            builder.ApplyConfiguration(new SentMessageConfiguration());
            builder.ApplyConfiguration(new ReceivedMessageConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new SchoolConfiguration());
            builder.ApplyConfiguration(new TextConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
