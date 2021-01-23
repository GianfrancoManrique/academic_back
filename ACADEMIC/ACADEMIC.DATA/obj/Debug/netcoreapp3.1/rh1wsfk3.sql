IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Courses] (
    [CourseId] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [ReferencedPrice] real NOT NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY ([CourseId])
);
GO

CREATE TABLE [Students] (
    [StudentId] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [LastName] nvarchar(100) NOT NULL,
    [State] bit NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([StudentId])
);
GO

CREATE TABLE [Inscriptions] (
    [CourseId] int NOT NULL,
    [StudentId] int NOT NULL,
    CONSTRAINT [PK_Inscriptions] PRIMARY KEY ([CourseId], [StudentId]),
    CONSTRAINT [FK_Inscriptions_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([CourseId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Inscriptions_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([StudentId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Inscriptions_StudentId] ON [Inscriptions] ([StudentId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210123164621_init', N'5.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Courses] ADD [State] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210123172822_CourseModified', N'5.0.2');
GO

COMMIT;
GO

