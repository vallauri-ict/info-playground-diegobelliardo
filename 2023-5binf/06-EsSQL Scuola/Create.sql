﻿--STUDENTI (Matricola, NomeS, CorsoLaurea*, AnnoN)
--CORSIDILAUREA (CorsoLaurea, TipoLaurea, Facoltà)
--FREQUENTA (Matricola*, CodCorso*)
--CORSI (CodCorso, NomeCorso, CodDocente*)
--DOCENTI (CodDocente, NomeD, Dipartimento)

--CREATE TABLE CORSODILAUREA (
--	CorsoLaurea VARCHAR(10) NOT NULL PRIMARY KEY,
--	TipoLaurea VARCHAR(50) NOT NULL,
--	Facolta VARCHAR(50) NOT NULL
--);

--CREATE TABLE DOCENTI (
--	CodDocente INT NOT NULL IDENTITY PRIMARY KEY,
--	NomeD VARCHAR(50) NOT NULL,
--	Dipartimento VARCHAR(50) NOT NULL
--);

CREATE TABLE STUDENTI (
	Matricola INT NOT NULL IDENTITY PRIMARY KEY,
	NomeS VARCHAR(50) NOT NULL,
	CorsoLaurea VARCHAR(10) NOT NULL,
	AnnoN INT,
	CONSTRAINT ChiaveCorsoLaurea FOREIGN KEY (CorsoLaurea) REFERENCES [CORSODILAUREA] ([CorsoLaurea])
);

CREATE TABLE CORSI (
	CodCorso INT NOT NULL IDENTITY PRIMARY KEY,
	NomeCorso VARCHAR(50) NOT NULL,
	CodDocente INT NOT NULL,
	CONSTRAINT ChiaveDocente FOREIGN KEY (CodDocente) REFERENCES DOCENTI (CodDocente)
);

CREATE TABLE FREQUENTA(
	Matricola INT NOT NULL,
	CodCorso INT NOT NULL,
	PRIMARY KEY (Matricola,CodCorso),
	CONSTRAINT ChiaveStudente FOREIGN KEY (Matricola) REFERENCES STUDENTI (Matricola),
	CONSTRAINT ChiaveCorso FOREIGN KEY (CodCorso) REFERENCES CORSI (CodCorso)
);