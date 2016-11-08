CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] TEXT NOT NULL, 
    [description] TEXT NULL, 
    [status] INT NOT NULL, 
    [priority] INT NOT NULL
)
