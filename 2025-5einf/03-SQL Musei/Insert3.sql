-- 1) MUSEO (inserisce solo se non esiste)
IF NOT EXISTS (SELECT 1 FROM Musei WHERE NomeM = 'Galleria degli Uffizi')
BEGIN
    INSERT INTO Musei (NomeM, Citta) VALUES ('Galleria degli Uffizi', 'Florence');
END

-- 2) ARTISTI ITALIANI (inserisce solo se non esistono)
IF NOT EXISTS (SELECT 1 FROM Artisti WHERE NomeA = 'Sandro Botticelli')
    INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Sandro Botticelli', 'Italiana');

IF NOT EXISTS (SELECT 1 FROM Artisti WHERE NomeA = 'Filippo Lippi')
    INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Filippo Lippi', 'Italiana');

IF NOT EXISTS (SELECT 1 FROM Artisti WHERE NomeA = 'Raffaello Sanzio')
    INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Raffaello Sanzio', 'Italiana');

IF NOT EXISTS (SELECT 1 FROM Artisti WHERE NomeA = 'Michelangelo')
    INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Michelangelo', 'Italiana');

IF NOT EXISTS (SELECT 1 FROM Artisti WHERE NomeA = 'Leonardo da Vinci')
    INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Leonardo da Vinci', 'Italiana');

-- 3) OPERE (uso IDENTITY_INSERT per codici prevedibili: 33..38)
SET IDENTITY_INSERT Opere ON;

-- Cambia i valori Codice se nella tua tabella esistono già questi ID
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (33, 'La Primavera', 'Galleria degli Uffizi', 'Sandro Botticelli');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (34, 'La Nascita di Venere', 'Galleria degli Uffizi', 'Sandro Botticelli');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (35, 'Annunciazione', 'Galleria degli Uffizi', 'Filippo Lippi');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (36, 'Madonna del Cardellino', 'Galleria degli Uffizi', 'Raffaello Sanzio');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (37, 'Tondo Doni', 'Galleria degli Uffizi', 'Michelangelo');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (38, 'Studio per ritratto', 'Galleria degli Uffizi', 'Leonardo da Vinci');

SET IDENTITY_INSERT Opere OFF;

-- 4) PERSONAGGI associati alle opere (almeno una per opera; aggiungi altre righe se vuoi più dettagli)
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Flora', 33);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Primavera - Mercurio', 33);  -- seconda figura per stessa opera (chiave composta consente più righe)
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Venere', 34);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Nereo/Proti', 34);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Angelo', 35);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Madonna', 36);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Bambino', 36);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Sacra Famiglia (Tondo)', 37);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Giovane (studio)', 38);
