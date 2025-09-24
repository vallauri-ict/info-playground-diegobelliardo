CREATE TABLE Musei (
	NomeM varchar(50) not NULL PRIMARY KEY,
	Citta VARCHAR(50) NOT NULL);

CREATE TABLE Artisti (
	NomeA varchar(50) not NULL PRIMARY KEY,
	Nazionalita VARCHAR(50) NOT NULL);

CREATE TABLE Opere (
	Codice INT NOT NULL PRIMARY KEY IDENTITY,
	Titolo VARCHAR(50) NOT NULL,
	NomeM VARCHAR(50) NOT NULL,
	NomeA varchar(50) not NULL,
	CONSTRAINT FK_Opere_Musei FOREIGN KEY (NomeM) REFERENCES Musei(NomeM),
	CONSTRAINT FK_Opere_Artisti FOREIGN KEY (NomeA) REFERENCES Artisti(NomeA));

CREATE TABLE Personaggi (
	Personaggio varchar(50) not NULL,
	Codice INT NOT NULL,
	PRIMARY KEY (Personaggio,Codice),
	CONSTRAINT FK_Personaggi_Opere FOREIGN KEY (Codice) REFERENCES Opere(Codice));