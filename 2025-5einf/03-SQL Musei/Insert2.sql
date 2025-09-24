-- 1) NUOVI MUSEI A LONDRA (almeno 10)
INSERT INTO Musei (NomeM, Citta) VALUES ('National Gallery', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Tate Britain', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Tate Modern', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Victoria and Albert Museum', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('National Portrait Gallery', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Wallace Collection', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Courtauld Gallery', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Saatchi Gallery', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Dulwich Picture Gallery', 'London');
INSERT INTO Musei (NomeM, Citta) VALUES ('Serpentine Galleries', 'London');

-- 2) ARTISTI ITALIANI (aggiunta se non esistono già)
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Raffaello Sanzio', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Tiziano Vecellio', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Giovanni Bellini', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Canaletto', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Artemisia Gentileschi', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Amedeo Modigliani', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Giorgio de Chirico', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Umberto Boccioni', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Piero della Francesca', 'Italiana');
INSERT INTO Artisti (NomeA, Nazionalita) VALUES ('Filippo Lippi', 'Italiana');

-- 3) OPERE (inserisco Codice espliciti partendo da 21; usa IDENTITY_INSERT per mantenere ID noti)
SET IDENTITY_INSERT Opere ON;

INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (21, 'Ritratto di gentildonna', 'National Gallery', 'Raffaello Sanzio');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (22, 'Venere di Urbino (studio)', 'Tate Britain', 'Tiziano Vecellio');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (23, 'Madonna col Bambino', 'Tate Modern', 'Giovanni Bellini');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (24, 'Veduta di Londra dal Tamigi', 'Victoria and Albert Museum', 'Canaletto');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (25, 'Giuditta che decapita Oloferne', 'National Portrait Gallery', 'Artemisia Gentileschi');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (26, 'Testa di donna', 'Wallace Collection', 'Amedeo Modigliani');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (27, 'Piazza metafisica', 'Courtauld Gallery', 'Giorgio de Chirico');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (28, 'Dinamismo di una corsa', 'Saatchi Gallery', 'Umberto Boccioni');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (29, 'Madonna della Misericordia', 'Dulwich Picture Gallery', 'Piero della Francesca');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (30, 'Annunciazione (studio)', 'Serpentine Galleries', 'Filippo Lippi');
-- aggiungo anche alcune opere di artisti italiani già noti (se vuoi linkare opere famose)
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (31, 'Studio per Mona Lisa (schizzo)', 'National Gallery', 'Leonardo da Vinci');
INSERT INTO Opere (Codice, Titolo, NomeM, NomeA) VALUES (32, 'Soggetto barocco', 'Tate Modern', 'Caravaggio');

SET IDENTITY_INSERT Opere OFF;

-- 4) PERSONAGGI associati alle nuove opere (almeno una riga per ogni opera)
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Ritratta', 21);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Venere', 22);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Madonna', 23);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Vedutista', 24);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Giuditta', 25);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Testa femminile', 26);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Figura solitaria', 27);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Corridore', 28);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Madonna centrale', 29);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Angelo annunciante', 30);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Studio di sorriso', 31);
INSERT INTO Personaggi (Personaggio, Codice) VALUES ('Uomo in controluce', 32);
