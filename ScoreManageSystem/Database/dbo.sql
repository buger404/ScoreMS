CREATE TABLE [dbo].[User] (
    [Id]       INT          NOT NULL,
    [UserName] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [Type]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Student] (
    [Id]     INT           NOT NULL,
    [UserID] INT           NOT NULL REFERENCES [dbo].[User]([Id]),
    [Sex]    INT           NOT NULL,
    [Name]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Course] (
    [Id]      INT        NOT NULL,
    [Name]    NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Teacher] (
    [Id]      INT        NOT NULL,
    [UserID]  INT        NOT NULL REFERENCES [dbo].[User]([Id]),
    [CourseID] INT        NOT NULL REFERENCES [dbo].[Course]([Id]),
    [Name]    NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Class] (
    [Id]      INT        NOT NULL,
    [CourseID] INT        NOT NULL REFERENCES [dbo].[Course]([Id]),
    [StudentID] INT NOT NULL REFERENCES [dbo].[Student]([Id]), 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Score]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [StudentID] INT NOT NULL REFERENCES [dbo].[Student]([Id]), 
    [CourseID] INT NOT NULL REFERENCES [dbo].[Course]([Id]),
    [Score] INT NOT NULL, 
    [Comment] NCHAR(256) NULL
)