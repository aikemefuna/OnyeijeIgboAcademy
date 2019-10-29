﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnyeijeSchool.DbContexts;

namespace OnyeijeSchool.Migrations
{
    [DbContext(typeof(OnyeijeContext))]
    partial class OnyeijeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmAssignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description");

                    b.Property<int>("Id");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Title");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("AssignmentId");

                    b.HasIndex("Id");

                    b.ToTable("AdmAssignment");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName");

                    b.Property<int>("CourseId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("AdmClass");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmCourses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode");

                    b.Property<string>("CourseTitle");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("CourseId");

                    b.ToTable("AdmCourses");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmModules", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("ModuleCode");

                    b.Property<string>("Title");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("ModuleId");

                    b.HasIndex("CourseId");

                    b.ToTable("AdmModules");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmQuestions", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Format");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Questions");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("QuestionId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("AdmQuestions");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmResult", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Attempted");

                    b.Property<int>("Correct");

                    b.Property<string>("Course");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("ExamName");

                    b.Property<int>("InCorrect");

                    b.Property<int>("NotAttempted");

                    b.Property<int>("Score");

                    b.Property<string>("StudentName");

                    b.Property<int>("TotalQuestions");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("ResultId");

                    b.ToTable("AdmResult");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<bool>("IsEnabled");

                    b.Property<int>("ModuleId");

                    b.Property<string>("Notes");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.Property<string>("TopicNumber");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.Property<string>("VideoUrl");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("AdmTopic");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<string>("DateOfBirth")
                        .HasMaxLength(6);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .HasMaxLength(6);

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Meta")
                        .HasMaxLength(1000);

                    b.Property<string>("ShortDescription")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("BlogId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.ExamSetUp", b =>
                {
                    b.Property<int>("ExaminationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("Id");

                    b.Property<string>("Instructions");

                    b.Property<bool>("IsActive");

                    b.Property<int>("QuestionNo");

                    b.Property<string>("Title");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("ExaminationId");

                    b.HasIndex("Id");

                    b.ToTable("ExamSetUp");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("InstructorEmail")
                        .IsRequired();

                    b.Property<string>("OtherNames");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("PreferedName");

                    b.Property<string>("SurName")
                        .IsRequired();

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.InstructorCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("InstructorId");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("InstructorCourse");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.QuestionChoices", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<bool>("IsAnswer");

                    b.Property<int>("QuestionId");

                    b.Property<string>("Text");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionChoices");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.Questions", b =>
                {
                    b.Property<int>("QuestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdmModulesModuleId");

                    b.Property<int>("CourseId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Instructions");

                    b.Property<string>("ModuleId");

                    b.Property<string>("Option1");

                    b.Property<string>("Option2");

                    b.Property<string>("Option3");

                    b.Property<string>("Option4");

                    b.Property<string>("Question");

                    b.Property<string>("RightAnswer");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("QuestId");

                    b.HasIndex("AdmModulesModuleId");

                    b.HasIndex("CourseId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentId");

                    b.Property<DateTime?>("CompletedTime");

                    b.Property<string>("CourseCode");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description");

                    b.Property<bool>("IsCompleted");

                    b.Property<DateTime?>("StartTime");

                    b.Property<int>("StudentId");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StAssignment");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StAssignmentAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Choice");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Essay");

                    b.Property<int>("QuestionId");

                    b.Property<int>("StudentId");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("StudentId");

                    b.ToTable("StAssignmentAnswer");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StCourseEnrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ApprovedDate");

                    b.Property<int>("CourseId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsCompleted");

                    b.Property<int>("StudentId");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StCourseEnrollment");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Country");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("Gender");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("State");

                    b.Property<string>("StudentEmail");

                    b.Property<string>("StudentFirstName")
                        .IsRequired();

                    b.Property<string>("StudentLastName")
                        .IsRequired();

                    b.Property<string>("StudentMiddleName");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StudentModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CompletedTime");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<bool>("IsCompleted");

                    b.Property<int>("ModuleId");

                    b.Property<DateTime?>("StartTime");

                    b.Property<int>("StudentId");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentModule");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StudentTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdmTopicId");

                    b.Property<DateTime?>("CompletedTime");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<bool>("IsCompleted");

                    b.Property<DateTime?>("StartTime");

                    b.Property<int>("StudentId");

                    b.Property<int>("Topicid");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.HasIndex("AdmTopicId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentTopic");
                });

            modelBuilder.Entity("OnyeijeSchool.Models.TopicFiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AdmTopicId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Extension");

                    b.Property<string>("FileName");

                    b.Property<int>("Topic");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.HasIndex("AdmTopicId");

                    b.ToTable("TopicFiles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnyeijeSchool.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmAssignment", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmClass", "AdmClass")
                        .WithMany("AdmAssignment")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmClass", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmCourses", "AdmCourses")
                        .WithMany("AdmClass")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmModules", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmCourses", "AdmCourses")
                        .WithMany("AdmModules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmQuestions", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmAssignment", "AdmAssignment")
                        .WithMany("AdmQuestions")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.AdmTopic", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmModules", "AdmModules")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.ExamSetUp", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmClass", "AdmClass")
                        .WithMany("ExamSetUp")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.InstructorCourse", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmCourses", "AdmCourses")
                        .WithMany("InstructorCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnyeijeSchool.Models.Instructor", "Instructor")
                        .WithMany("InstructorCourse")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.QuestionChoices", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmQuestions", "AdmQuestions")
                        .WithMany("QuestionChoices")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.Questions", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmModules", "AdmModules")
                        .WithMany("Questions")
                        .HasForeignKey("AdmModulesModuleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnyeijeSchool.Models.AdmCourses", "AdmCourses")
                        .WithMany("Questions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StAssignment", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmAssignment", "AdmAssignment")
                        .WithMany("StAssignment")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnyeijeSchool.Models.Student", "Student")
                        .WithMany("StAssignment")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StAssignmentAnswer", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmQuestions", "AdmQuestions")
                        .WithMany("StAssignmentAnswer")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnyeijeSchool.Models.Student", "Student")
                        .WithMany("StAssignmentAnswer")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StCourseEnrollment", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmCourses", "AdmCourses")
                        .WithMany("StCourseEnrollment")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnyeijeSchool.Models.Student", "Student")
                        .WithMany("StCourseEnrollment")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StudentModule", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmModules", "AdmModules")
                        .WithMany("StudentModule")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnyeijeSchool.Models.Student", "Student")
                        .WithMany("StudentModule")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.StudentTopic", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmTopic", "AdmTopic")
                        .WithMany("StudentTopic")
                        .HasForeignKey("AdmTopicId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnyeijeSchool.Models.Student", "Student")
                        .WithMany("StudentTopic")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnyeijeSchool.Models.TopicFiles", b =>
                {
                    b.HasOne("OnyeijeSchool.Models.AdmTopic", "AdmTopic")
                        .WithMany("TopicFiles")
                        .HasForeignKey("AdmTopicId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}