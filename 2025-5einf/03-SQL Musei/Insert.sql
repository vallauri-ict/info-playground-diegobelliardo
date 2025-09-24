-- INSERT per MUSEI (almeno 10)
INSERT INTO Musei (NomeM, Citta) VALUES ('Louvre', 'Paris');
INSERT INTO Musei (NomeM, Citta) VALUES ('Uffizi', 'Florence');
INSERT INTO Musei (NomeM, Citta) VALUES ('British Museum', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Metropolitan Museum', 'New York');
INSERT INTO Musei (NomeM, Citta) VALUES ('Prado', 'Madrid');
INSERT INTO Musei (NomeM, Citta) VALUES ('Rijksmuseum', 'Amsterdam');
INSERT INTO Musei (NomeM, Citta) VALUES ('Galleria Borghese', 'Rome');
INSERT INTO Musei (NomeM, Citta) VALUES ('Hermitage', 'St. Petersburg');
INSERT INTO Musei (NomeM, Citta) VALUES ('Alte Nationalgalerie', 'Berlin');
INSERT INTO Musei (NomeM, Citta) VALUES ('Belvedere', 'Vienna');
INSERT INTO Musei (NomeM, Citta) VALUES ('MACBA', 'Barcelona');
INSERT INTO Musei (NomeM, Citta) VALUES ('Art Institute of Chicago', 'Chicago');

-- INSERT per ARTISTI (almeno 10)
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Leonardo da Vinci', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Michelangelo', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Vincent van Gogh', 'Olandese');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Pablo Picasso', 'Spagnola');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Rembrandt', 'Olandese');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Claude Monet', 'Francese');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Sandro Botticelli', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Caravaggio', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Frida Kahlo', 'Messicana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Georgia O''Keeffe', 'Statunitense');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Salvador Dalí', 'Spagnola');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Gustav Klimt', 'Austriaca');

-- INSERT per OPERE (usando IDENTITY_INSERT per inserire Codice esplicito)
SET IDENTITY_INSERT Opere ON;

INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (1, 'Mona Lisa', 'Louvre', 'Leonardo da Vinci');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (2, 'Annunciazione', 'Uffizi', 'Sandro Botticelli');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (3, 'David (Bozzetto)', 'Galleria Borghese', 'Michelangelo');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (4, 'Starry Night', 'Metropolitan Museum', 'Vincent van Gogh');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (5, 'Sunflowers', 'Art Institute of Chicago', 'Vincent van Gogh');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (6, 'Guernica', 'Prado', 'Pablo Picasso');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (7, 'The Night Watch', 'Rijksmuseum', 'Rembrandt');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (8, 'Water Lilies', 'MACBA', 'Claude Monet');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (9, 'Narciso', 'Belvedere', 'Gustav Klimt');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (10, 'Bacco', 'Uffizi', 'Caravaggio');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (11, 'Autoritratto con collana', 'Hermitage', 'Frida Kahlo');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (12, 'Composizione astratta', 'Alte Nationalgalerie', 'Salvador Dalí');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (13, 'Fiori nel vaso', 'Art Institute of Chicago', 'Georgia O''Keeffe');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (14, 'Ritratto di gentiluomo', 'British Museum', 'Rembrandt');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (15, 'Madonna con bambino', 'Louvre', 'Leonardo da Vinci');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (16, 'La Primavera', 'Uffizi', 'Sandro Botticelli');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (17, 'Il sacrificio', 'Hermitage', 'Gustav Klimt');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (18, 'Ritratto femminile', 'Belvedere', 'Gustav Klimt');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (19, 'Autoritratto', 'Metropolitan Museum', 'Pablo Picasso');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (20, 'Battesimo', 'Galleria Borghese', 'Caravaggio');

SET IDENTITY_INSERT Opere OFF;

-- INSERT per PERSONAGGI (almeno 10)
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Monna Lisa', 1);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Annunciatrice', 2);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Giovane Davide', 3);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Contadino notturno', 7);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Fanciulla con girasoli', 5);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Pilota', 6);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Ninfea centrale', 8);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Narciso', 9);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Bacco', 10);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Autoritratto', 11);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Figura surreale', 12);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Donna col vaso', 13);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Gentiluomo', 14);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Madonna', 15);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Venere', 16);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Figura allegorica', 17);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Dama', 18);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Ritratto cubista', 19);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Battesimando', 20);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Testimone', 6);