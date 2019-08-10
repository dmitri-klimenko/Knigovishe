﻿// <auto-generated />
using System;
using Knigosha.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Knigosha.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190810061145_AddingModels")]
    partial class AddingModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Knigosha.Core.Models.Answer", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<string>("UserId");

                    b.Property<int>("AnswerType");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("Id");

                    b.Property<int>("NumberOfSkippedQuestions");

                    b.Property<int>("NumberOfWriteResponses");

                    b.Property<int>("NumberOfWrongResponses");

                    b.Property<int>("PercentageOfRightResponses");

                    b.Property<int>("PercentageOfSkippedQuestions");

                    b.Property<int>("PercentageOfWrongResponses");

                    b.Property<int>("QuizType");

                    b.Property<string>("ReasonForRestart");

                    b.HasKey("BookId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Knigosha.Core.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("Grade");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int>("NumberOfCreatedBooks");

                    b.Property<int>("NumberPointsForCreatedBooks");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Photo");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Knigosha.Core.Models.AssociationKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<int>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("AssociationKeys");
                });

            modelBuilder.Entity("Knigosha.Core.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddedByAdmin");

                    b.Property<string>("BookAuthor")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("BookCategory");

                    b.Property<float>("CalculatedRating");

                    b.Property<string>("CoverPhoto")
                        .IsRequired();

                    b.Property<int>("DateAdded");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Grade");

                    b.Property<bool>("IsShortForm");

                    b.Property<string>("Isbn1")
                        .IsRequired();

                    b.Property<string>("Isbn2");

                    b.Property<int>("NumberOfComprehensionQuestions");

                    b.Property<int>("NumberOfContentQuestions");

                    b.Property<int>("NumberOfPages");

                    b.Property<int>("PartOfSchoolProgramAtGrade");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("QuestionsAuthor")
                        .IsRequired();

                    b.Property<string>("Tags")
                        .IsRequired();

                    b.Property<int>("TimesCompleted");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Translator");

                    b.Property<string>("YearPublished")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Knigosha.Core.Models.BookNote", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<string>("UserId");

                    b.Property<string>("Text")
                        .HasMaxLength(255);

                    b.HasKey("BookId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("BookNotes");
                });

            modelBuilder.Entity("Knigosha.Core.Models.BookRating", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<string>("UserId");

                    b.Property<int>("Rating");

                    b.HasKey("BookId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("BookRatings");
                });

            modelBuilder.Entity("Knigosha.Core.Models.MarkedBook", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<string>("UserId");

                    b.HasKey("BookId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("MarkedBooks");
                });

            modelBuilder.Entity("Knigosha.Core.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<int>("QuestionType");

                    b.Property<string>("RightAnswer")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("WrongAnswer1")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("WrongAnswer2")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Knigosha.Core.Models.ReceivedMessage", b =>
                {
                    b.Property<string>("ReceiverId");

                    b.Property<string>("SenderId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Topic");

                    b.HasKey("ReceiverId", "SenderId");

                    b.HasIndex("SenderId");

                    b.ToTable("ReceivedMessages");
                });

            modelBuilder.Entity("Knigosha.Core.Models.SentMessage", b =>
                {
                    b.Property<string>("ReceiverId");

                    b.Property<string>("SenderId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Topic");

                    b.HasKey("ReceiverId", "SenderId");

                    b.HasIndex("SenderId");

                    b.ToTable("SentMessages");
                });

            modelBuilder.Entity("Knigosha.Core.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivationCode");

                    b.Property<string>("BankData");

                    b.Property<string>("Note");

                    b.Property<int>("PaymentType");

                    b.Property<string>("SchoolYear");

                    b.Property<int>("Status");

                    b.Property<DateTime>("SubscribeDateTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Knigosha.Core.Models.SubscriptionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxQuizzes");

                    b.Property<int>("Name");

                    b.Property<int>("NumberOfParentProfiles");

                    b.Property<int>("NumberOfStudentProfiles");

                    b.Property<int>("NumberOfTeacherProfiles");

                    b.Property<int>("Price");

                    b.Property<string>("PriceTag")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("SubscriptionId");

                    b.Property<string>("Text1")
                        .HasMaxLength(255);

                    b.Property<string>("Text2")
                        .HasMaxLength(255);

                    b.Property<string>("Text3")
                        .HasMaxLength(255);

                    b.Property<string>("ValidUntil")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId")
                        .IsUnique();

                    b.ToTable("SubscriptionTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Knigosha.Core.Models.Class", b =>
                {
                    b.HasBaseType("Knigosha.Core.Models.ApplicationUser");

                    b.Property<int>("NumberOfClassesInAgeGroup");

                    b.Property<int>("NumberOfStudentsInClass");

                    b.Property<int>("PositionInAgeGroupAccordingToTotalNumberOfAnswers");

                    b.Property<int>("PositionInAgeGroupAccordingToTotalNumberOfRightResponses");

                    b.Property<int>("PositionInAgeGroupAccordingToTotalPoints");

                    b.Property<string>("School");

                    b.Property<int>("TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers");

                    b.Property<int>("TopPercentageInAgeGroupAccordingToTotalNumberOfRightResponses");

                    b.Property<int>("TopPercentageInAgeGroupAccordingToTotalPoints");

                    b.Property<int>("TotalNumberOfAnswers");

                    b.Property<int>("TotalPercentageOfRightResponses");

                    b.Property<int>("TotalPoints");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Classes");

                    b.HasDiscriminator().HasValue("Class");
                });

            modelBuilder.Entity("Knigosha.Core.Models.Family", b =>
                {
                    b.HasBaseType("Knigosha.Core.Models.ApplicationUser");

                    b.Property<int>("NumberOfFamiliesInAgeGroup");

                    b.Property<int>("NumberOfStudentsInFamily");

                    b.Property<int>("PositionInAgeGroupAccordingToTotalNumberOfAnswers")
                        .HasColumnName("Family_PositionInAgeGroupAccordingToTotalNumberOfAnswers");

                    b.Property<int>("PositionInAgeGroupAccordingToTotalNumberOfRightResponses")
                        .HasColumnName("Family_PositionInAgeGroupAccordingToTotalNumberOfRightResponses");

                    b.Property<int>("PositionInAgeGroupAccordingToTotalPoints")
                        .HasColumnName("Family_PositionInAgeGroupAccordingToTotalPoints");

                    b.Property<bool>("ShowAchievements");

                    b.Property<int>("TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers")
                        .HasColumnName("Family_TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers");

                    b.Property<int>("TopPercentageInAgeGroupAccordingToTotalNumberOfRightResponses")
                        .HasColumnName("Family_TopPercentageInAgeGroupAccordingToTotalNumberOfRightResponses");

                    b.Property<int>("TopPercentageInAgeGroupAccordingToTotalPoints")
                        .HasColumnName("Family_TopPercentageInAgeGroupAccordingToTotalPoints");

                    b.Property<int>("TotalNumberOfAnswers")
                        .HasColumnName("Family_TotalNumberOfAnswers");

                    b.Property<int>("TotalPercentageOfRightResponses")
                        .HasColumnName("Family_TotalPercentageOfRightResponses");

                    b.Property<int>("TotalPoints")
                        .HasColumnName("Family_TotalPoints");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("Family_UserId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[Family_UserId] IS NOT NULL");

                    b.ToTable("Families");

                    b.HasDiscriminator().HasValue("Family");
                });

            modelBuilder.Entity("Knigosha.Core.Models.Student", b =>
                {
                    b.HasBaseType("Knigosha.Core.Models.ApplicationUser");

                    b.Property<string>("ClassStudentBelongsToId");

                    b.Property<string>("FamilyStudentBelongsToId");

                    b.Property<string>("GreetingName");

                    b.Property<string>("Level");

                    b.Property<int>("NumberOfAnswers");

                    b.Property<string>("ParentEmail");

                    b.Property<int>("PercentageOfRightResponses");

                    b.Property<int>("Points");

                    b.Property<int>("PositionInClassAccordingToNumberOfAnswers");

                    b.Property<int>("PositionInClassAccordingToPercentageOfRightResponses");

                    b.Property<int>("PositionInClassAccordingToPoints");

                    b.Property<int>("PositionInFamilyAccordingToNumberOfAnswers");

                    b.Property<int>("PositionInFamilyAccordingToPercentageOfRightResponses");

                    b.Property<int>("PositionInFamilyAccordingToPoints");

                    b.Property<string>("School")
                        .HasColumnName("Student_School");

                    b.Property<string>("StudentCode");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("Student_UserId");

                    b.HasIndex("ClassStudentBelongsToId");

                    b.HasIndex("FamilyStudentBelongsToId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[Student_UserId] IS NOT NULL");

                    b.ToTable("Students");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Knigosha.Core.Models.Answer", b =>
                {
                    b.HasOne("Knigosha.Core.Models.Book", "Book")
                        .WithMany("Answers")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "User")
                        .WithMany("Answers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Knigosha.Core.Models.AssociationKey", b =>
                {
                    b.HasOne("Knigosha.Core.Models.Subscription", "Subscription")
                        .WithMany("AssociationKeys")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Knigosha.Core.Models.BookNote", b =>
                {
                    b.HasOne("Knigosha.Core.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "User")
                        .WithMany("BookNotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Knigosha.Core.Models.BookRating", b =>
                {
                    b.HasOne("Knigosha.Core.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "User")
                        .WithMany("BookRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Knigosha.Core.Models.MarkedBook", b =>
                {
                    b.HasOne("Knigosha.Core.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "User")
                        .WithMany("MarkedBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Knigosha.Core.Models.Question", b =>
                {
                    b.HasOne("Knigosha.Core.Models.Book", "Book")
                        .WithMany("Questions")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Knigosha.Core.Models.ReceivedMessage", b =>
                {
                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "Receiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Knigosha.Core.Models.SentMessage", b =>
                {
                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Knigosha.Core.Models.Subscription", b =>
                {
                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Knigosha.Core.Models.SubscriptionType", b =>
                {
                    b.HasOne("Knigosha.Core.Models.Subscription", "Subscription")
                        .WithOne("SubscriptionType")
                        .HasForeignKey("Knigosha.Core.Models.SubscriptionType", "SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Knigosha.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Knigosha.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Knigosha.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Knigosha.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Knigosha.Core.Models.Class", b =>
                {
                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "User")
                        .WithOne("Class")
                        .HasForeignKey("Knigosha.Core.Models.Class", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Knigosha.Core.Models.Family", b =>
                {
                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "User")
                        .WithOne("Family")
                        .HasForeignKey("Knigosha.Core.Models.Family", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Knigosha.Core.Models.Student", b =>
                {
                    b.HasOne("Knigosha.Core.Models.Class", "ClassStudentBelongsTo")
                        .WithMany("Students")
                        .HasForeignKey("ClassStudentBelongsToId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Knigosha.Core.Models.Family", "FamilyStudentBelongsTo")
                        .WithMany("Students")
                        .HasForeignKey("FamilyStudentBelongsToId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Knigosha.Core.Models.ApplicationUser", "User")
                        .WithOne("Student")
                        .HasForeignKey("Knigosha.Core.Models.Student", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
