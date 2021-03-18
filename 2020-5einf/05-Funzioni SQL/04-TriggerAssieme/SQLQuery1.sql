


/*
CREATE TABLE [StoricoCancellazioni] (
[Id] int NOT NULL IDENTITY,
[IdCliente] int,
[Nome] varchar(50),
[Cognome] varchar(50),
[IdCarrello] int,
[Data] datetime,
PRIMARY KEY ([Id])
);
*/

/*
CREATE TABLE [StoricoAggiornamenti] (
[Id] int NOT NULL IDENTITY,
[IdCliente] int,
[NomeOld] varchar(50),
[NomeNew] varchar(50),
[CognomeOld] varchar(50),
[CognomeNew] varchar(50),
[IdCarrelloOld] int,
[IdCarrelloNew] int,
[Data] datetime,
PRIMARY KEY ([Id])
);
*/

/*
CREATE TABLE [Clienti] (
[IdCliente] int NOT NULL IDENTITY,
[Nome] varchar(50),
[Cognome] varchar(50),
[IdCarrello] int,
PRIMARY KEY ([IdCliente])
);
*/

INSERT INTO [Clienti] (
	Nome,
	Cognome,
	IdCarrello
)
VALUES(
		'Enrico',
		'Barale',
		1
);

INSERT INTO [Clienti] (
	Nome,
	Cognome,
	IdCarrello
)
VALUES(
		'Stefano',
		'Maggiore',
		2
);

INSERT INTO [Clienti] (
	Nome,
	Cognome,
	IdCarrello
)
VALUES(
		'Massimo',
		'Grosso',
		3
);

INSERT INTO [Clienti] (
	Nome,
	Cognome,
	IdCarrello
)
VALUES(
		'Samuele',
		'Giccardi',
		4
);

INSERT INTO [Clienti] (
	Nome,
	Cognome,
	IdCarrello
)
VALUES(
		'Giovanni',
		'Favole',
		5
);



