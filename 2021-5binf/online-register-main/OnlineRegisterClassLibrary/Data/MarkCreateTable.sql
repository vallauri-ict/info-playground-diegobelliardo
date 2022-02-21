CREATE TABLE [dbo].[Mark]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Mark] DECIMAL(3, 1) NOT NULL, 
    [When] DATE NOT NULL,
	[IdStudent] INT NOT NULL
)
