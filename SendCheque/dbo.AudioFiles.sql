CREATE TABLE [dbo].[AudioFiles] (
	[Id]          INT             NOT NULL,
    [Title]       VARCHAR (50)    NOT NULL,
    [Client]      VARCHAR (50)    NOT NULL,
    [Description] NVARCHAR (50)   NOT NULL,
    [AudioFile]   VARBINARY (MAX) NOT NULL,
    [SenderID]    NVARCHAR (128)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [SenderID] FOREIGN KEY ([SenderID]) REFERENCES [dbo].[AspNetUsers] ([Id])
);

