-- 1) Proprietari (10)
INSERT INTO Proprietari (CodF, Nome, Residenza) VALUES
('PLLDIEGO00000001','Diego Polli','Via Roma 1, Milano'),
('BNCRALDO00000002','Rinaldo Bianchi','Via Verdi 12, Torino'),
('VRGLUCA000000003','Luca Vergari','Piazza Duomo 5, Milano'),
('ROSSA00100000004','Maria Rossi','Via Garibaldi 7, Genova'),
('FIORENZO00000005','Enzo Fior','Via San Marco 3, Venezia'),
('BRUNETTO00000006','Brunetto Nero','Viale Europa 20, Napoli'),
('MARTINA000000007','Martina Costa','Via Lunga 9, Firenze'),
('GIALLO0000000008','Alessio Gialli','Corso Italia 45, Bologna'),
('NEROFRAN00000009','Francesca Neri','Via Piave 11, Bari'),
('LUPOALF000000010','Alfonso Lupo','Via Torino 2, Palermo');

-- 2) Assicurazioni (10) -- CodAss è IDENTITY, inseriamo esplicitamente
SET IDENTITY_INSERT Assicurazioni ON;
INSERT INTO Assicurazioni (CodAss, Nome, Sede) VALUES
(1,'SARA','Milano'),
(2,'Generale','Torino'),
(3,'Unipol','Bologna'),
(4,'Allianz','Roma'),
(5,'Reale','Napoli'),
(6,'Zurich','Milano'),
(7,'Direct','Bari'),
(8,'Groupama','Firenze'),
(9,'Linear','Venezia'),
(10,'AXA','Genova');
SET IDENTITY_INSERT Assicurazioni OFF;

-- 3) Sinistro (10) -- CodS è IDENTITY, inseriamo esplicitamente
SET IDENTITY_INSERT Sinistro ON;
INSERT INTO Sinistro (CodS, Localita, DataS) VALUES
(1,'Milano','2002-01-20'),   -- 20/01/02 (per query 4)
(2,'Torino','2001-01-20'),   -- 20/01/01 (per query 9)
(3,'Bologna','2003-06-10'),
(4,'Roma','2002-03-15'),
(5,'Napoli','2000-12-05'),
(6,'Firenze','2002-01-20'),
(7,'Bari','2004-09-09'),
(8,'Venezia','2001-02-01'),
(9,'Genova','2001-12-31'),
(10,'Palermo','2005-07-07');
SET IDENTITY_INSERT Sinistro OFF;

-- 4) Auto (10)
-- Targa formato 7 caratteri
INSERT INTO [Auto] (Targa, Marca, Cilindrata, Potenza, CodF, CodAss) VALUES
('AA111AA','Fiat',1400,75,'PLLDIEGO00000001',1),    -- Diego
('BB222BB','Fiat',1600,90,'PLLDIEGO00000001',2),    -- Diego (ha 2 auto)
('CC333CC','Audi',2200,150,'BNCRALDO00000002',1),   -- Rinaldo ( >2000 , >120)
('DD444DD','BMW',3000,220,'VRGLUCA000000003',3),    -- Luca (>2000)
('EE555EE','Fiat',1800,110,'ROSSA00100000004',4),   -- Maria
('FF666FF','Mercedes',2000,136,'FIORENZO00000005',5), -- Enzo ( =2000 potenza>120)
('GG777GG','Fiat',1300,70,'BRUNETTO00000006',6),   -- Brunetto
('HH888HH','Opel',2100,130,'MARTINA000000007',7),  -- Martina (>2000, >120)
('II999II','Fiat',2200,140,'GIALLO0000000008',8), -- Alessio (Fiat >2000)
('JJ000JJ','Toyota',1600,100,'NEROFRAN00000009',9);-- Francesca

-- 5) AutoCoinvolte (più di 10 record, alcune auto coinvolte in più sinistri)
-- Chiavi: (CodS, Targa)
INSERT INTO AutoCoinvolte (CodS, Targa, ImportoDelDanno) VALUES
(1,'AA111AA', 500.00),   -- AA111AA coinvolta in sinistro 1
(1,'CC333CC',1200.00),   -- CC333CC con SARA (assicurazione 1)
(2,'BB222BB', 800.00),   -- BB222BB in sinistro 2
(3,'DD444DD',3000.00),
(4,'EE555EE',1500.00),
(4,'FF666FF',2000.00),
(5,'GG777GG',  0.00),
(6,'II999II',900.50),    -- II999II coinvolta in sinistro 6 (2002-01-20)
(7,'HH888HH',2500.00),
(8,'JJ000JJ',  700.00),
(9,'CC333CC',1800.00),   -- CC333CC coinvolta anche in sinistro 9 (quindi >1 sinistro)
(10,'CC333CC',2200.00),  -- ancora CC333CC in sinistro 10 (3 sinistri totali)
(3,'AA111AA', 350.00),   -- AA111AA coinvolta anche in sinistro 3 (2 sinistri)
(2,'II999II', 400.00);   -- II999II anche in sinistro 2 (più di un sinistro)