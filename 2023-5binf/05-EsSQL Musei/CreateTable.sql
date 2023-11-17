CREATE TABLE [dbo].[Musei]
(
	[NomeM] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Citta] VARCHAR(50) NULL
);

CREATE TABLE [dbo].[Artisti]
(
	[NomeA] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Nazionalita] VARCHAR(50) NULL
);

CREATE TABLE [dbo].[Opere] (
    [Codice] INT          IDENTITY (1, 1) NOT NULL,
    [Titolo] VARCHAR (50) NOT NULL,
    [NomeM]  VARCHAR (50) NOT NULL,
    [NomeA]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codice] ASC),
    CONSTRAINT [FK_Opere_ToTable] FOREIGN KEY ([NomeM]) REFERENCES [dbo].[Musei] ([NomeM]),
    CONSTRAINT [FK_Opere_ToTable_1] FOREIGN KEY ([NomeA]) REFERENCES [dbo].[Artisti] ([NomeA])
);

--CREATE TABLE [dbo].[Personaggi]
--(
--	[Personaggio] VARCHAR(50) NOT NULL PRIMARY KEY, 
--    [Codice] INT NOT NULL, 
--    CONSTRAINT [FK_Personaggi_ToTable] FOREIGN KEY ([Codice]) REFERENCES [Opere]([Codice]) 
--);

CREATE TABLE [dbo].[Personaggi] (
    [Personaggio] VARCHAR (50) NOT NULL,
    [Codice]      INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Personaggio], [Codice]),
    CONSTRAINT [FK_Personaggi_ToTable] FOREIGN KEY ([Codice]) REFERENCES [Opere]([Codice]) 
);


