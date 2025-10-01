CREATE TABLE Docenti (
CodDocente int NOT NULL PRIMARY KEY IDENTITY,
NomeD VARCHAR(50) NOT NULL,
Dipartimento VARCHAR(50) NULL);

CREATE TABLE CorsiDiLaurea (
CorsoLaurea VARCHAR(50) NOT NULL PRIMARY KEY,
TipoLaurea VARCHAR(50) NOT NULL,
Facolta VARCHAR(50) NOT NULL)

CREATE TABLE Studenti (
Matricola int NOT NULL PRIMARY KEY IDENTITY,
NomeS VARCHAR(50) NOT NULL,
CorsoLaurea VARCHAR(50) NOT NULL,
AnnoN int NOT NULL,
CONSTRAINT FK_Studenti_CorsiDiLaurea 
			FOREIGN KEY (CorsoLaurea) REFERENCES CorsiDiLaurea(CorsoLaurea));

CREATE TABLE Corsi (
CodCorso int NOT NULL PRIMARY KEY IDENTITY,
NomeCorso VARCHAR(50) NOT NULL,
CodDocente int NOT NULL,
CONSTRAINT FK_Corsi_Docenti 
			FOREIGN KEY (CodDocente) REFERENCES Docenti(CodDocente));

CREATE TABLE Frequenta (
Matricola int NOT NULL,
CodCorso int NOT NULL,
PRIMARY KEY (Matricola,CodCorso),
CONSTRAINT FK_Frequenta_Studenti 
			FOREIGN KEY (Matricola) REFERENCES Studenti(Matricola),
CONSTRAINT FK_Frequenta_Corsi 
			FOREIGN KEY (CodCorso) REFERENCES Corsi(CodCorso));

