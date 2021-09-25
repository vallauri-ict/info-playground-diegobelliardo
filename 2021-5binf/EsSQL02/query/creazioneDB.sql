CREATE TABLE Aeroporto (
Citta VARCHAR(30) PRIMARY KEY,
Nazione VARCHAR(3),
NumPiste INT)

CREATE TABLE Volo (
IdVolo INT PRIMARY KEY IDENTITY,
GiornoSettimana VARCHAR(10),
CittaPartenza VARCHAR(10),
OraPartenza TIME,
CittaArrivo VARCHAR(10),
OraArrivo TIME,
TipoAereo VARCHAR(10))

CREATE TABLE Aereo(
TipoAereo VARCHAR(10) PRIMARY KEY,
NumPasseggeri INT,
QtaMerci INT
)