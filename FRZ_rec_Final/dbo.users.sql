CREATE TABLE [dbo].[users] (
    [Id]       INT           NOT NULL IDENTITY,
    [username] NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

