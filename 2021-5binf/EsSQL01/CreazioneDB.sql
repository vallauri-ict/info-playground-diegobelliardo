CREATE TABLE Impiegato(
  nome varchar(30) PRIMARY KEY,
  titolo varchar(50),
  eta int NOT NULL,
  salario decimal(12,2),
  dip char(1)
);

CREATE TABLE [dbo].[Cliente]
(
	[IdCliente] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] VARCHAR(30) NOT NULL, 
    [cognome] VARCHAR(50) NOT NULL, 
    [citta] VARCHAR(50) NOT NULL, 
    [stato] VARCHAR(3) NOT NULL
);

CREATE TABLE [dbo].[Acquisto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [idCliente] INT NOT NULL, 
    [dataDiOrdinazione] DATE NOT NULL, 
    [item] INT NOT NULL, 
    [quantita] INT NOT NULL, 
    [prezzo] DECIMAL(12, 2) NOT NULL
);

INSERT INTO Cliente (nome,cognome, citta, stato)
VALUES('Alberto','Tomba','Pinerolo','IT'),
('Paperino','Pape', 'Fossano','IT'),
('Alberto','Barbero','Mondovì','IT');

INSERT INTO Impiegato VALUES
('Edoardo','',18,1500,'s'),
('Ivan','',20,1200,'s'),
('Marta','',19,1300,'s');

INSERT INTO Acquisto (idCliente,dataDiOrdinazione,item,quantita,prezzo) values
(1,'2000-12-20',1,3,50),
(1,'2020-01-13',2,4,60),
(2,'2020-02-10',2,10,55)