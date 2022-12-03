CREATE TABLE Attori (
CodAttore int IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(50) NOT NULL,
AnnoNascita int NOT NULL,
Nazionalita varchar(25));

INSERT INTO Attori (Nome,AnnoNascita,Nazionalita) VALUES
('Robert DN',1943,'USA'),
('Checco Zalone',1977,'Italiana'),
('Nino Frassica',1956,'Italiana'),
('Brad Pitt',1963,'USA');

CREATE TABLE Film (
CodFilm int IDENTITY(1,1) PRIMARY KEY,
Titolo VARCHAR(100) NOT NULL,
AnnoProduzione int NOT NULL,
Nazionalita varchar(25),
Regista VARCHAR(50) NOT NULL,
Genere VARCHAR(50) NOT NULL);

INSERT INTO Film (Titolo,AnnoProduzione,Nazionalita,Regista,Genere) VALUES
('Taxi Driver',1976,'USA','Martin Scorsese','Drammatico'),
('Il padrino',1972,'USA','Francis Ford Coppola','Drammatico'),
('Quo vado?',2016,'Italiana','Pietro Valsecchi','Commedia'),
('LE FORZE DEL DESTINO',2003,'Giapponese','Thomas Vinterberg','Fantascienza'),
('Lucy',2014,'Francese','Luc Besson','Fantascienza'),
('LE FORZE DEL DESTINO-1',1980,'Giapponese','Thomas Vinterberg','Fantascienza');

CREATE TABLE Sale (
CodSala int IDENTITY(1,1) PRIMARY KEY,
Posti int NOT NULL,
Nome VARCHAR(50) NOT NULL,
Citta VARCHAR(50) NOT NULL);

INSERT INTO Sale (Posti,Nome,Citta) VALUES
(125,'Sala Rossa','Fossano'),
(500,'Sala Grande','Fossano'),
(355,'Sala Gialla','Bra'),
(400,'Sala Blu','Bra')


CREATE TABLE Recita (
CodAttore int NOT NULL,
CodFilm int NOT NULL,
PRIMARY KEY CLUSTERED (CodAttore,CodFilm ASC),
CONSTRAINT [FK_AttoreRecita] FOREIGN KEY (CodAttore) REFERENCES Attori(CodAttore),
CONSTRAINT [FK_FilmRecita] FOREIGN KEY (CodFilm) REFERENCES Film(CodFilm)
);

INSERT INTO [dbo].[Recita] ([CodAttore], [CodFilm]) VALUES (1, 1)
INSERT INTO [dbo].[Recita] ([CodAttore], [CodFilm]) VALUES (1, 2)
INSERT INTO [dbo].[Recita] ([CodAttore], [CodFilm]) VALUES (2, 1)
INSERT INTO [dbo].[Recita] ([CodAttore], [CodFilm]) VALUES (2, 3)
INSERT INTO [dbo].[Recita] ([CodAttore], [CodFilm]) VALUES (1, 3)
INSERT INTO [dbo].[Recita] ([CodAttore], [CodFilm]) VALUES (3, 3)

CREATE TABLE Proiezioni (
CodProiezione int IDENTITY(1,1) PRIMARY KEY,
CodFilm int NOT NULL,
CodSala int NOT NULL,
Incasso int NOT NULL,
DataProiezione DATE NOT NULL,
CONSTRAINT [FK_FilmProiezioni] FOREIGN KEY (CodFilm) REFERENCES Film(CodFilm),
CONSTRAINT [FK_SalaProiezioni] FOREIGN KEY (CodSala) REFERENCES Sale(CodSala),
);

INSERT INTO [dbo].[Proiezioni] ([CodFilm], [CodSala], [Incasso], [DataProiezione]) VALUES ( 1, 1, 1000, N'2020-10-01')
INSERT INTO [dbo].[Proiezioni] ([CodFilm], [CodSala], [Incasso], [DataProiezione]) VALUES (1, 2, 5000, N'2020-10-02')
INSERT INTO [dbo].[Proiezioni] ([CodFilm], [CodSala], [Incasso], [DataProiezione]) VALUES (2, 3, 1500, N'2021-12-10')
INSERT INTO [dbo].[Proiezioni] ([CodFilm], [CodSala], [Incasso], [DataProiezione]) VALUES (3, 4, 1750, N'2022-04-25')
INSERT INTO [dbo].[Proiezioni] ([CodFilm], [CodSala], [Incasso], [DataProiezione]) VALUES (3, 3, 1800, N'2022-06-20')