-- ---------------------------
-- 1) Docenti (10) -- IDENTITY
-- ---------------------------
SET IDENTITY_INSERT Docenti ON;
INSERT INTO Docenti (CodDocente, NomeD, Dipartimento) VALUES
(1,'Felice','Informatica'),
(2,'Leoni','Informatica'),
(3,'Rossi','Basi di Dati e Sistemi Informativi'),
(4,'Bianchi','Informatica Generale'),
(5,'Verdi','Storia'),
(6,'Neri','Storia'),
(7,'Gialli','Matematica'),
(8,'Bruno','Ingegneria'),
(9,'Ferri','Lettere'),
(10,'Longo','Filosofia');
SET IDENTITY_INSERT Docenti OFF;

-- --------------------------------
-- 2) CorsiDiLaurea (10) - pk non identity
-- --------------------------------
INSERT INTO CorsiDiLaurea (CorsoLaurea, TipoLaurea, Facolta) VALUES
('SBC','L','Informatica'),
('LET','L','Lettere e Filosofia'),
('ING','L','Ingegneria'),
('MAT','M','Matematica'),
('BIO','L','Scienze Biologiche'),
('SCI','M','Scienze'),
('ECO','L','Economia'),
('FIL','M','Lettere e Filosofia'),
('ART','L','Lettere e Filosofia'),
('MED','M','Medicina');

-- ------------------------------
-- 3) Studenti (15) -- IDENTITY
-- ------------------------------
-- assegno matricole esplicite per comodità nelle freq.
SET IDENTITY_INSERT Studenti ON;
INSERT INTO Studenti (Matricola, NomeS, CorsoLaurea, AnnoN) VALUES
(1001,'Anna Rossi','SBC',2001),
(1002,'Marco Bianchi','SBC',2000),
(1003,'Laura Feltri','SBC',2002),
(1004,'Stefano Leoni','SBC',1999),
(1005,'Giulia Neri','SBC',2001),
(1006,'Paolo Verdi','SBC',2000),
(1007,'Clara Ferri','LET',1998),
(1008,'Davide Longo','LET',1997),
(1009,'Elisa Gialli','ING',1996),
(1010,'Roberto Bruno','MAT',1995),
(1011,'Marta Rossi','ECO',2001),
(1012,'Simone Rossi','BIO',2000),
(1013,'Nicola Storia','LET',1999),
(1014,'Pietro Solo','ING',2000),   -- studente che non frequenta corsi (vedi frequenta)
(1015,'Vanessa Unica','MAT',1998); -- altro studente con poche frequenze
SET IDENTITY_INSERT Studenti OFF;

-- ------------------------------
-- 4) Corsi (10) -- IDENTITY
-- ------------------------------
SET IDENTITY_INSERT Corsi ON;
INSERT INTO Corsi (CodCorso, NomeCorso, CodDocente) VALUES
(201,'Basi di Dati','3'),        -- docente Rossi (Basi di Dati e Sist Inform.)
(202,'Programmazione 1','1'),    -- docente Felice (Informatica)
(203,'Algoritmi','2'),           -- docente Leoni (Informatica)
(204,'Storia Medievale','5'),    -- docente Verdi (Storia)
(205,'Storia Moderna','6'),      -- docente Neri (Storia)
(206,'Letteratura Italiana','9'),-- docente Ferri (Lettere)
(207,'Calcolo','7'),             -- docente Gialli (Matematica)
(208,'Macchine','8'),            -- docente Bruno (Ingegneria)
(209,'Filosofia','10'),          -- docente Longo (Filosofia)
(210,'CorsoNonFrequentato','4'); -- docente Bianchi (Informatica Generale) -> nessuno lo frequenterà
SET IDENTITY_INSERT Corsi OFF;

-- -----------------------------------------
-- 5) Frequenta (molte righe) - rispetta fk
-- -----------------------------------------
-- Idea: 
-- - Corso 201 (Basi di Dati) sarà seguito da molti studenti (>=6) e tenuto da docente del dip. 'Basi di Dati e Sist Informativi'
-- - Corso 202 (Programmazione 1) sarà seguito da tutti gli studenti SBC (1001..1006) e solo da loro
-- - Corso 203 (Algoritmi) seguito da vari studenti
-- - Corso 204 e 205 sono corsi di Storia; alcuni studenti seguiranno solo corsi di Storia
-- - Corso 210 non sarà frequentato da nessuno (per query 9)

INSERT INTO Frequenta (Matricola, CodCorso) VALUES
-- corso 201 Basi di Dati -> molti studenti (>=6)
(1001,201),
(1002,201),
(1003,201),
(1004,201),
(1005,201),
(1006,201),
(1007,201),

-- corso 202 Programmazione 1 -> tutti gli studenti SBC (solo SBC)
(1001,202),
(1002,202),
(1003,202),
(1004,202),
(1005,202),
(1006,202),

-- corso 203 Algoritmi -> alcuni studenti (include docenti Felice/Leoni come richiesto)
(1001,203),
(1003,203),
(1009,203),
(1010,203),
(1015,203),

-- corsi di Storia (204,205) -> studenti che seguono solo corsi di Storia
(1013,204),
(1013,205),
(1007,204),  -- 1007 partecipa anche ad altri; 1013 invece solo storia (per query 10)
(1008,205),

-- altri corsi
(1009,208),
(1010,207),
(1011,201), -- anche studente economia segue basi di dati
(1012,201),
(1015,209);


