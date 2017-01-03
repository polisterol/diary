CREATE TABLE [dbo].[Tasks] (
    [Id]          INT  IDENTITY (0, 1) NOT NULL,
    [name]        TEXT NOT NULL,
    [description] TEXT NULL,
    [status]      INT  NOT NULL,
    [priority]    INT  NOT NULL,
    [list] TEXT NOT NULL DEFAULT 'inList', 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

