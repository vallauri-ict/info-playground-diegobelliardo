-- Inserimento di dati nella tabella PROPRIETARI
INSERT INTO PROPRIETARI (CodF, Nome, Residenza)
VALUES
    (1, 'Mario Rossi', 'Via Roma, 123'),
    (2, 'Anna Verdi', 'Via Napoli, 456'),
    (3, 'Luca Bianchi', 'Via Firenze, 789'),
    (4, 'Laura Gialli', 'Via Venezia, 234'),
    (5, 'Antonio Marroni', 'Via Milano, 567'),
    (6, 'Paola Neri', 'Via Genova, 890'),
    (7, 'Giuseppe Celeste', 'Via Bologna, 123'),
    (8, 'Rosa Viola', 'Via Torino, 456'),
    (9, 'Roberto Blu', 'Via Palermo, 789'),
    (10, 'Giovanna Verde', 'Via Catania, 234'),
    (11, 'Marco Arancio', 'Via Palermo, 890'),
    (12, 'Maria Gialla', 'Via Catanzaro, 123'),
    (13, 'Francesco Rosa', 'Via Reggio, 456'),
    (14, 'Teresa Marrone', 'Via Cosenza, 789'),
    (15, 'Luigi Celestino', 'Via Matera, 234'),
    (16, 'Sara Viola', 'Via Potenza, 567'),
    (17, 'Enrico Rossi', 'Via Lecce, 890'),
    (18, 'Silvia Rossa', 'Via Foggia, 123'),
    (19, 'Vincenzo Verdi', 'Via Brindisi, 456'),
    (20, 'Carmela Nera', 'Via Taranto, 789');

-- Inserimento di dati nella tabella ASSICURAZIONI
INSERT INTO ASSICURAZIONI (CodAss, Nome, Sede)
VALUES
    (1, 'Assicurazione ABC', 'Milano, Via Milano, 1'),
    (2, 'Assicurazione XYZ', 'Roma, Via Roma, 2'),
    (3, 'Assicurazione 123', 'Napoli, Via Napoli, 3'),
    (4, 'Assicurazione QWERTY', 'Firenze, Via Firenze, 4'),
    (5, 'Assicurazione InVita', 'Venezia, Via Venezia, 5'),
    (6, 'Assicurazione SafeDrive', 'Genova, Via Genova, 6'),
    (7, 'Assicurazione Shield', 'Bologna, Via Bologna, 7'),
    (8, 'Assicurazione AllRisk', 'Torino, Via Torino, 8'),
    (9, 'Assicurazione SureCare', 'Palermo, Via Palermo, 9'),
    (10, 'Assicurazione StarGuard', 'Catania, Via Catania, 10'),
    (11, 'Assicurazione Premium', 'Catanzaro, Via Catanzaro, 11'),
    (12, 'Assicurazione ProPlan', 'Reggio, Via Reggio, 12'),
    (13, 'Assicurazione QuickCover', 'Cosenza, Via Cosenza, 13'),
    (14, 'Assicurazione EasyLife', 'Matera, Via Matera, 14'),
    (15, 'Assicurazione SafetyNet', 'Potenza, Via Potenza, 15'),
    (16, 'Assicurazione PeaceGuard', 'Lecce, Via Lecce, 16'),
    (17, 'Assicurazione PrimeAssure', 'Foggia, Via Foggia, 17'),
    (18, 'Assicurazione MaxCare', 'Brindisi, Via Brindisi, 18'),
    (19, 'Assicurazione TrustyShield', 'Taranto, Via Taranto, 19'),
    (20, 'Assicurazione ShieldCare', 'Bari, Via Bari, 20');

-- Inserimento di dati nella tabella SINISTRO
INSERT INTO SINISTRO (CodS, Località, Data)
VALUES
    (1, 'Roma', '2023-01-15'),
    (2, 'Milano', '2023-02-20'),
    (3, 'Napoli', '2023-03-10'),
    (4, 'Firenze', '2023-04-25'),
    (5, 'Venezia', '2023-05-12'),
    (6, 'Genova', '2023-06-30'),
    (7, 'Bologna', '2023-07-18'),
    (8, 'Torino', '2023-08-04'),
    (9, 'Palermo', '2023-09-21'),
    (10, 'Catania', '2023-10-08'),
    (11, 'Catanzaro', '2023-11-27'),
    (12, 'Reggio', '2023-12-14'),
    (13, 'Cosenza', '2024-01-31'),
    (14, 'Matera', '2024-02-17'),
    (15, 'Potenza', '2024-03-05'),
    (16, 'Lecce', '2024-04-22'),
    (17, 'Foggia', '2024-05-09'),
    (18, 'Brindisi', '2024-06-26'),
    (19, 'Taranto', '2024-07-13'),
    (20, 'Bari', '2024-08-30');

-- Inserimento di dati nella tabella AUTO
INSERT INTO AUTO (Targa, Marca, Cilindrata, Potenza, CodF, CodAss)
VALUES
    ('AB123CD', 'Fiat', 1200, 80, 1, 1),
    ('XY456ZW', 'Ford', 1600, 100, 2, 2),
    ('LM789NO', 'Toyota', 1400, 90, 3, 3),
    ('PO987QP', 'Volkswagen', 1300, 85, 4, 4),
    ('RS345AB', 'Mercedes', 1800, 120, 5, 5),
    ('FG678CD', 'Honda', 1500, 95, 6, 6),
    ('KL123EF', 'Hyundai', 1100, 75, 7, 7),
    ('IJ456KL', 'Nissan', 1250, 82, 8, 8),
    ('VW789YZ', 'Renault', 1700, 110, 9, 9),
    ('XZ123RS', 'Kia', 1350, 88, 10, 10),
    ('BC456DE', 'Audi', 1600, 105, 11, 11),
    ('MN789OP', 'Peugeot', 1400, 92, 12, 12),
    ('QR123ST', 'Subaru', 1500, 98, 13, 13),
    ('UV456WX', 'Mazda', 1100, 72, 14, 14),
    ('YZ123AB', 'Chevrolet', 1200, 78, 15, 15),
    ('CD456EF', 'Jeep', 1700, 115, 16, 16),
    ('EF789GH', 'Suzuki', 1300, 86, 17, 17),
    ('GH123IJ', 'Chrysler', 1600, 104, 18, 18),
    ('IJ456KK', 'Volvo', 1400, 91, 19, 19),
    ('KL123MN', 'Dodge', 1500, 96, 20, 20);

-- Inserimento di dati nella tabella AUTOCOINVOLTE
INSERT INTO AUTOCOINVOLTE (CodS, Targa, ImportoDelDanno)
VALUES
    (1, 'AB123CD', 1500.00),
    (2, 'XY456ZW', 2000.00),
    (3, 'LM789NO', 1000.00),
    (4, 'PO987QP', 2500.00),
    (5, 'RS345AB', 1800.00),
    (6, 'FG678CD', 1200.00),
    (7, 'KL123EF', 900.00),
    (8, 'IJ456KL', 1700.00),
    (9, 'VW789YZ', 1400.00),
    (10, 'XZ123RS', 1600.00),
    (11, 'BC456DE', 1100.00),
    (12, 'MN789OP', 1300.00),
    (13, 'QR123ST', 1900.00),
    (14, 'UV456WX', 950.00),
    (15, 'YZ123AB', 2200.00),
    (16, 'CD456EF', 1800.00),
    (17, 'EF789GH', 1250.00),
    (18, 'GH123IJ', 1700.00),
    (19, 'IJ456KK', 1350.00),
    (20, 'KL123MN', 1600.00);


    -----------------------------------------------------
