﻿-- 1- Il codice ed il titolo delle opere di Tiziano 
-- conservate alla “National Gallery”.
SELECT *
FROM Opere o
WHERE o.NomeM='National Gallery'
AND o.NomeA='Tiziano'

-- 4- Le città in cui son conservate opere di Caravaggio
SELECT DISTINCT m.Citta
FROM Opere o, Musei m
WHERE o.NomeM=m.NomeM
AND o.NomeA='Caravaggio'

-- 7- Il codice ed il titolo delle opere di artisti italiani 
-- conservate nei musei di Londra, in cui è rappresentata la Madonna
SELECT o.Codice, o.Titolo
FROM Opere o, Personaggi p, Artisti a, Musei m
WHERE o.Codice=p.Codice
AND a.NomeA=o.NomeA
AND o.NomeM=m.NomeM
AND m.Citta='London'
AND a.Nazionalita='Italiana'
AND p.Personaggio='Madonna'

-- 8- Per ciascun museo di Londra, il numero di opere di artisti 
-- italiani ivi conservate
SELECT m.NomeM, count(*) AS 'Numero opere'
FROM Musei m, Opere o, Artisti a
WHERE m.NomeM=o.NomeM
AND o.NomeA=a.NomeA
AND a.Nazionalita='Italiana'
AND m.Citta='London'
GROUP BY m.NomeM

-- 9- Il nome dei musei di Londra che non conservano 
-- opere di Tiziano
SELECT *
FROM Musei m
WHERE m.Citta='London'
AND not Exists (SELECT *
					FROM Opere o
					WHERE o.NomeM=m.NomeM
					AND o.NomeA='Tiziano')

-- 10- Il nome dei musei di Londra che conservano 
-- solo opere di Tiziano
SELECT m.*
FROM Musei m
WHERE m.Citta='London'
AND not Exists (SELECT *
				FROM Opere o
				WHERE o.NomeM=m.NomeM
				AND o.NomeA<>'Tiziano')

-- 11- Per ciascun artista, il nome dell’artista ed il numero 
-- di sue opere conservate alla “Galleria degli Uffizi”
SELECT o.NomeA, count(*) 'Numero Opere'
FROM Opere o
WHERE o.NomeM='Galleria degli Uffizi'
GROUP BY o.NomeA

--12- I musei che conservano almeno 20 opere di artisti italiani
SELECT o.NomeM
FROM Opere o, Artisti a
WHERE a.Nazionalita = 'Italiana'
AND a.NomeA = o.NomeA
GROUP BY o.NomeM
HAVING COUNT(*) > 13

--13- Per le opere di artisti italiani che non hanno personaggi, 
--il titolo dell’opera ed il nome dell’artista
SELECT o.Codice,o.Titolo, o.NomeA
FROM Opere o, Artisti a
WHERE o.NomeA = a.NomeA
AND a.Nazionalita = 'Italiana'
AND o.Codice NOT IN(SELECT p.Codice FROM Personaggi p)
ORDER BY o.Codice

--14- Il nome dei musei di Londra che non conservano opere di artisti 
--italiani, eccettuato Tiziano
SELECT m.NomeM
FROM Musei m
WHERE m.Citta='London' 
AND NOT EXISTS(SELECT * FROM Artisti a, Opere o WHERE a.Nazionalita='Italiana'
				AND a.NomeA<>'Tiziano' AND o.NomeA=a.NomeA AND m.NomeM=o.NomeM)

SELECT m.NomeM
FROM Musei m
WHERE m.Citta='London' 
AND m.NomeM not in (SELECT o.NomeM FROM Opere o, Artisti a 
	WHERE a.NomeA=o.NomeA AND a.Nazionalita='Italiana' AND a.NomeA<>'Tiziano')

--15- Per ogni museo, il numero di opere divise per la nazionalità dell’artista
SELECT o.NomeM, a.Nazionalita, COUNT(*)
FROM Opere o, Artisti a
WHERE a.NomeA=o.NomeA
GROUP BY o.NomeM, a.Nazionalita
ORDER BY o.NomeM, a.Nazionalita
