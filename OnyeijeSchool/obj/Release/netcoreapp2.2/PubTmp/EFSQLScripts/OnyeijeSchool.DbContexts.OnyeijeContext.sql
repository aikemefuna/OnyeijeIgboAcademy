IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AdmCourses] (
        [CourseId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [CourseCode] nvarchar(max) NULL,
        [IsEnabled] bit NOT NULL,
        [CourseTitle] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_AdmCourses] PRIMARY KEY ([CourseId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AdmResult] (
        [ResultId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [StudentName] nvarchar(max) NULL,
        [ExamName] nvarchar(max) NULL,
        [Course] nvarchar(max) NULL,
        [TotalQuestions] int NOT NULL,
        [Attempted] int NOT NULL,
        [NotAttempted] int NOT NULL,
        [Correct] int NOT NULL,
        [InCorrect] int NOT NULL,
        [Score] int NOT NULL,
        CONSTRAINT [PK_AdmResult] PRIMARY KEY ([ResultId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [Country] nvarchar(max) NULL,
        [EducationalLevel] nvarchar(max) NULL,
        [DateOfBirth] nvarchar(6) NULL,
        [Gender] nvarchar(6) NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [Blog] (
        [BlogId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [Title] nvarchar(500) NOT NULL,
        [ShortDescription] nvarchar(max) NOT NULL,
        [Content] nvarchar(max) NOT NULL,
        [Meta] nvarchar(1000) NULL,
        CONSTRAINT [PK_Blog] PRIMARY KEY ([BlogId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [Instructor] (
        [InstructorId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [SurName] nvarchar(max) NOT NULL,
        [OtherNames] nvarchar(max) NULL,
        [PreferedName] nvarchar(max) NULL,
        [InstructorEmail] nvarchar(max) NOT NULL,
        [PhoneNumber] nvarchar(15) NOT NULL,
        [Country] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Instructor] PRIMARY KEY ([InstructorId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [Student] (
        [StudentId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [StudentFirstName] nvarchar(max) NOT NULL,
        [StudentLastName] nvarchar(max) NOT NULL,
        [StudentMiddleName] nvarchar(max) NULL,
        [Gender] int NOT NULL,
        [StudentEmail] nvarchar(max) NULL,
        [IsEnabled] bit NOT NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [State] nvarchar(max) NULL,
        [Country] nvarchar(max) NULL,
        CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AdmClass] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [ClassName] nvarchar(max) NULL,
        [CourseId] int NOT NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_AdmClass] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AdmClass_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AdmModules] (
        [ModuleId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsEnabled] bit NOT NULL,
        [CourseId] int NOT NULL,
        [ModuleCode] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        CONSTRAINT [PK_AdmModules] PRIMARY KEY ([ModuleId]),
        CONSTRAINT [FK_AdmModules_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [InstructorCourse] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [InstructorId] int NOT NULL,
        [CourseId] int NOT NULL,
        CONSTRAINT [PK_InstructorCourse] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_InstructorCourse_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE CASCADE,
        CONSTRAINT [FK_InstructorCourse_Instructor_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructor] ([InstructorId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [StCourseEnrollment] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [IsApproved] bit NOT NULL,
        [IsCompleted] bit NOT NULL,
        [StudentId] int NOT NULL,
        [CourseId] int NOT NULL,
        [ApprovedDate] datetime2 NULL,
        CONSTRAINT [PK_StCourseEnrollment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StCourseEnrollment_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE CASCADE,
        CONSTRAINT [FK_StCourseEnrollment_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AdmAssignment] (
        [AssignmentId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsEnabled] bit NOT NULL,
        [Title] nvarchar(max) NULL,
        [Id] int NOT NULL,
        CONSTRAINT [PK_AdmAssignment] PRIMARY KEY ([AssignmentId]),
        CONSTRAINT [FK_AdmAssignment_AdmClass_Id] FOREIGN KEY ([Id]) REFERENCES [AdmClass] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [ExamSetUp] (
        [ExaminationId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [Id] int NOT NULL,
        [IsActive] bit NOT NULL,
        [Title] nvarchar(max) NULL,
        [QuestionNo] int NOT NULL,
        [Instructions] nvarchar(max) NULL,
        CONSTRAINT [PK_ExamSetUp] PRIMARY KEY ([ExaminationId]),
        CONSTRAINT [FK_ExamSetUp_AdmClass_Id] FOREIGN KEY ([Id]) REFERENCES [AdmClass] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AdmTopic] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [IsEnabled] bit NOT NULL,
        [TopicNumber] nvarchar(max) NULL,
        [Notes] nvarchar(max) NULL,
        [ModuleId] int NOT NULL,
        [Summary] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [VideoUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_AdmTopic] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AdmTopic_AdmModules_ModuleId] FOREIGN KEY ([ModuleId]) REFERENCES [AdmModules] ([ModuleId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [Questions] (
        [QuestId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [CourseId] int NOT NULL,
        [ModuleId] nvarchar(max) NULL,
        [AdmModulesModuleId] int NULL,
        [Instructions] nvarchar(max) NULL,
        [Question] nvarchar(max) NULL,
        [Option1] nvarchar(max) NULL,
        [Option2] nvarchar(max) NULL,
        [Option3] nvarchar(max) NULL,
        [Option4] nvarchar(max) NULL,
        [RightAnswer] nvarchar(max) NULL,
        CONSTRAINT [PK_Questions] PRIMARY KEY ([QuestId]),
        CONSTRAINT [FK_Questions_AdmModules_AdmModulesModuleId] FOREIGN KEY ([AdmModulesModuleId]) REFERENCES [AdmModules] ([ModuleId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Questions_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [StudentModule] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [IsCompleted] bit NOT NULL,
        [StudentId] int NOT NULL,
        [ModuleId] int NOT NULL,
        [StartTime] datetime2 NULL,
        [CompletedTime] datetime2 NULL,
        CONSTRAINT [PK_StudentModule] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StudentModule_AdmModules_ModuleId] FOREIGN KEY ([ModuleId]) REFERENCES [AdmModules] ([ModuleId]) ON DELETE CASCADE,
        CONSTRAINT [FK_StudentModule_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [AdmQuestions] (
        [QuestionId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [Questions] nvarchar(max) NULL,
        [IsEnabled] bit NOT NULL,
        [Format] nvarchar(max) NULL,
        [AssignmentId] int NOT NULL,
        CONSTRAINT [PK_AdmQuestions] PRIMARY KEY ([QuestionId]),
        CONSTRAINT [FK_AdmQuestions_AdmAssignment_AssignmentId] FOREIGN KEY ([AssignmentId]) REFERENCES [AdmAssignment] ([AssignmentId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [StAssignment] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [CourseCode] nvarchar(max) NULL,
        [IsCompleted] bit NOT NULL,
        [AssignmentId] int NOT NULL,
        [StudentId] int NOT NULL,
        [StartTime] datetime2 NULL,
        [CompletedTime] datetime2 NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_StAssignment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StAssignment_AdmAssignment_AssignmentId] FOREIGN KEY ([AssignmentId]) REFERENCES [AdmAssignment] ([AssignmentId]) ON DELETE CASCADE,
        CONSTRAINT [FK_StAssignment_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [StudentTopic] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [IsCompleted] bit NOT NULL,
        [StudentId] int NOT NULL,
        [Topicid] int NOT NULL,
        [AdmTopicId] int NULL,
        [StartTime] datetime2 NULL,
        [CompletedTime] datetime2 NULL,
        CONSTRAINT [PK_StudentTopic] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StudentTopic_AdmTopic_AdmTopicId] FOREIGN KEY ([AdmTopicId]) REFERENCES [AdmTopic] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_StudentTopic_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [TopicFiles] (
        [Id] uniqueidentifier NOT NULL,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [FileName] nvarchar(max) NULL,
        [Extension] nvarchar(max) NULL,
        [Topic] int NOT NULL,
        [AdmTopicId] int NULL,
        CONSTRAINT [PK_TopicFiles] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TopicFiles_AdmTopic_AdmTopicId] FOREIGN KEY ([AdmTopicId]) REFERENCES [AdmTopic] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [QuestionChoices] (
        [AnswerId] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [IsAnswer] bit NOT NULL,
        [QuestionId] int NOT NULL,
        [Text] nvarchar(max) NULL,
        CONSTRAINT [PK_QuestionChoices] PRIMARY KEY ([AnswerId]),
        CONSTRAINT [FK_QuestionChoices_AdmQuestions_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [AdmQuestions] ([QuestionId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE TABLE [StAssignmentAnswer] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NULL,
        [UserCreated] nvarchar(max) NULL,
        [DateModified] datetime2 NULL,
        [UserModified] nvarchar(max) NULL,
        [Choice] int NOT NULL,
        [Essay] nvarchar(max) NULL,
        [QuestionId] int NOT NULL,
        [StudentId] int NOT NULL,
        CONSTRAINT [PK_StAssignmentAnswer] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StAssignmentAnswer_AdmQuestions_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [AdmQuestions] ([QuestionId]) ON DELETE CASCADE,
        CONSTRAINT [FK_StAssignmentAnswer_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AdmAssignment_Id] ON [AdmAssignment] ([Id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AdmClass_CourseId] ON [AdmClass] ([CourseId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AdmModules_CourseId] ON [AdmModules] ([CourseId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AdmQuestions_AssignmentId] ON [AdmQuestions] ([AssignmentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AdmTopic_ModuleId] ON [AdmTopic] ([ModuleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_ExamSetUp_Id] ON [ExamSetUp] ([Id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_InstructorCourse_CourseId] ON [InstructorCourse] ([CourseId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_InstructorCourse_InstructorId] ON [InstructorCourse] ([InstructorId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_QuestionChoices_QuestionId] ON [QuestionChoices] ([QuestionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_Questions_AdmModulesModuleId] ON [Questions] ([AdmModulesModuleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_Questions_CourseId] ON [Questions] ([CourseId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StAssignment_AssignmentId] ON [StAssignment] ([AssignmentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StAssignment_StudentId] ON [StAssignment] ([StudentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StAssignmentAnswer_QuestionId] ON [StAssignmentAnswer] ([QuestionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StAssignmentAnswer_StudentId] ON [StAssignmentAnswer] ([StudentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StCourseEnrollment_CourseId] ON [StCourseEnrollment] ([CourseId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StCourseEnrollment_StudentId] ON [StCourseEnrollment] ([StudentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StudentModule_ModuleId] ON [StudentModule] ([ModuleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StudentModule_StudentId] ON [StudentModule] ([StudentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StudentTopic_AdmTopicId] ON [StudentTopic] ([AdmTopicId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_StudentTopic_StudentId] ON [StudentTopic] ([StudentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    CREATE INDEX [IX_TopicFiles_AdmTopicId] ON [TopicFiles] ([AdmTopicId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015122012_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191015122012_InitialCreate', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmAssignment] DROP CONSTRAINT [FK_AdmAssignment_AdmClass_Id];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmClass] DROP CONSTRAINT [FK_AdmClass_AdmCourses_CourseId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmModules] DROP CONSTRAINT [FK_AdmModules_AdmCourses_CourseId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmQuestions] DROP CONSTRAINT [FK_AdmQuestions_AdmAssignment_AssignmentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmTopic] DROP CONSTRAINT [FK_AdmTopic_AdmModules_ModuleId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetRoleClaims] DROP CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserClaims] DROP CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserLogins] DROP CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserTokens] DROP CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [ExamSetUp] DROP CONSTRAINT [FK_ExamSetUp_AdmClass_Id];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [InstructorCourse] DROP CONSTRAINT [FK_InstructorCourse_AdmCourses_CourseId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [InstructorCourse] DROP CONSTRAINT [FK_InstructorCourse_Instructor_InstructorId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [QuestionChoices] DROP CONSTRAINT [FK_QuestionChoices_AdmQuestions_QuestionId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [Questions] DROP CONSTRAINT [FK_Questions_AdmCourses_CourseId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StAssignment] DROP CONSTRAINT [FK_StAssignment_AdmAssignment_AssignmentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StAssignment] DROP CONSTRAINT [FK_StAssignment_Student_StudentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StAssignmentAnswer] DROP CONSTRAINT [FK_StAssignmentAnswer_AdmQuestions_QuestionId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StAssignmentAnswer] DROP CONSTRAINT [FK_StAssignmentAnswer_Student_StudentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StCourseEnrollment] DROP CONSTRAINT [FK_StCourseEnrollment_AdmCourses_CourseId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StCourseEnrollment] DROP CONSTRAINT [FK_StCourseEnrollment_Student_StudentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StudentModule] DROP CONSTRAINT [FK_StudentModule_AdmModules_ModuleId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StudentModule] DROP CONSTRAINT [FK_StudentModule_Student_StudentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StudentTopic] DROP CONSTRAINT [FK_StudentTopic_Student_StudentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmAssignment] ADD CONSTRAINT [FK_AdmAssignment_AdmClass_Id] FOREIGN KEY ([Id]) REFERENCES [AdmClass] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmClass] ADD CONSTRAINT [FK_AdmClass_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmModules] ADD CONSTRAINT [FK_AdmModules_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmQuestions] ADD CONSTRAINT [FK_AdmQuestions_AdmAssignment_AssignmentId] FOREIGN KEY ([AssignmentId]) REFERENCES [AdmAssignment] ([AssignmentId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AdmTopic] ADD CONSTRAINT [FK_AdmTopic_AdmModules_ModuleId] FOREIGN KEY ([ModuleId]) REFERENCES [AdmModules] ([ModuleId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetRoleClaims] ADD CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserClaims] ADD CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserLogins] ADD CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserRoles] ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserRoles] ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [AspNetUserTokens] ADD CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [ExamSetUp] ADD CONSTRAINT [FK_ExamSetUp_AdmClass_Id] FOREIGN KEY ([Id]) REFERENCES [AdmClass] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [InstructorCourse] ADD CONSTRAINT [FK_InstructorCourse_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [InstructorCourse] ADD CONSTRAINT [FK_InstructorCourse_Instructor_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructor] ([InstructorId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [QuestionChoices] ADD CONSTRAINT [FK_QuestionChoices_AdmQuestions_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [AdmQuestions] ([QuestionId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [Questions] ADD CONSTRAINT [FK_Questions_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StAssignment] ADD CONSTRAINT [FK_StAssignment_AdmAssignment_AssignmentId] FOREIGN KEY ([AssignmentId]) REFERENCES [AdmAssignment] ([AssignmentId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StAssignment] ADD CONSTRAINT [FK_StAssignment_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StAssignmentAnswer] ADD CONSTRAINT [FK_StAssignmentAnswer_AdmQuestions_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [AdmQuestions] ([QuestionId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StAssignmentAnswer] ADD CONSTRAINT [FK_StAssignmentAnswer_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StCourseEnrollment] ADD CONSTRAINT [FK_StCourseEnrollment_AdmCourses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [AdmCourses] ([CourseId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StCourseEnrollment] ADD CONSTRAINT [FK_StCourseEnrollment_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StudentModule] ADD CONSTRAINT [FK_StudentModule_AdmModules_ModuleId] FOREIGN KEY ([ModuleId]) REFERENCES [AdmModules] ([ModuleId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StudentModule] ADD CONSTRAINT [FK_StudentModule_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    ALTER TABLE [StudentTopic] ADD CONSTRAINT [FK_StudentTopic_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([StudentId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191015123951_InitialCreate2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191015123951_InitialCreate2', N'2.2.6-servicing-10079');
END;

GO

