CREATE TABLE Passeggeri(
	id_Utente int primary key identity(1,1),
	nome varchar(20) not null,
	cognome varchar(20) not null,
	telefono varchar(10) not null,
	email varchar(40) not null,
	docIdentita varchar(10) not null
)

CREATE TABLE Autisti(
	id_Autista int primary key identity(1,1),
	nome varchar(20) not null,
	cognome varchar(20) not null,
	telefono varchar(10) not null,
	email varchar (40) not null,
	fotografia varchar(10) not null,
	datiAuto varchar(50) not null,
	scadPatente date not null
)

CREATE TABLE Viaggio(
	id_Viaggio int primary key identity(1,1),
	cittaPartenza varchar(25) not null,
	cittaArrivo varchar(25) not null,
	tempiStimati int not null,
	prezzo decimal(5,2) not null,
	costo decimal(5,2) not null,
	[data] date not null,
	ora time not null,
	soste int not null,
	bagagli bit not null,
	animali bit not null,
	isPrenotabile bit not null,
	idAutista int foreign key references Autisti(id_Autista) not null
)

CREATE TABLE Prenotazioni(
	id_Viaggio int foreign key references Viaggio(id_Viaggio) not null,
	id_Utente int foreign key references Passeggeri(id_Utente) not null,
	stato bit not null,
	primary key(id_Viaggio, Id_Utente)
)

CREATE TABLE FeedbackAutista(
	id_FeedbackAutista int primary key identity not null,
	voto int not null,
	descrizione varchar(100),
	idViaggio int foreign key references Viaggio(id_Viaggio) not null,
	idUtente int foreign key references Passeggeri(id_Utente) not null
)

CREATE TABLE FeedbackPasseggero(
	id_FeedbackAutista int primary key identity not null,
	voto int not null,
	descrizione varchar(100),
	idViaggio int foreign key references Viaggio(id_Viaggio) not null,
	idAutista int foreign key references Autisti(id_Autista) not null,
)