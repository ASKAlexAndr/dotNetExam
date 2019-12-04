CREATE TABLE [dbo].[Games] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [user_id] INT NOT NULL,
    [score]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Games_ToUsers] FOREIGN KEY ([user_id]) REFERENCES [dbo].[Users] ([Id])
);

