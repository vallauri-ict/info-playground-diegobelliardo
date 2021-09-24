CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(20) NOT NULL, 
    [LastName] VARCHAR(30) NOT NULL
);

SET IDENTITY_INSERT [dbo].[Student] ON;
INSERT INTO [dbo].[Student] ([Id], [FirstName], [LastName]) VALUES (1, N'Luca', N'Pirra');
INSERT INTO [dbo].[Student] ([Id], [FirstName], [LastName]) VALUES (2, N'Stefano', N'Einaudi');
INSERT INTO [dbo].[Student] ([Id], [FirstName], [LastName]) VALUES (3, N'Samuele', N'Barale');
INSERT INTO [dbo].[Student] ([Id], [FirstName], [LastName]) VALUES (4, N'Enrico', N'Ricca');
INSERT INTO [dbo].[Student] ([Id], [FirstName], [LastName]) VALUES (5, N'Marco', N'Roccia');
SET IDENTITY_INSERT [dbo].[Student] OFF;
