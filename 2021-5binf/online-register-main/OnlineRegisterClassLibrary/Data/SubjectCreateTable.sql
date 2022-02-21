CREATE TABLE [dbo].[Subject]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(40) NOT NULL, 
    [IsPeculiar] bit NOT NULL DEFAULT (0)
)
