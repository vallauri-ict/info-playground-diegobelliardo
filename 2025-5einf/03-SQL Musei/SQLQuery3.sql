-- 1 
SELECT o.Codice, o.Titolo
FROM Opere o
WHERE o.NomeA='Caravaggio'
AND o.NomeM='Uffizi'

-- 2
SELECT o.NomeA, o.Titolo
FROM Opere o
WHERE o.NomeM IN ('Galleria Borghese','Louvre')

-- 3
SELECT o.NomeA, o.Titolo
FROM Opere o, Musei m
WHERE o.NomeM=m.NomeM
AND m.Citta='Florence'

-- 4
SELECT DISTINCT m.Citta
FROM Opere o, Musei m
WHERE o.NomeM=m.NomeM
AND o.NomeA='Caravaggio'

-- 5
SELECT o.Codice, o.Titolo
FROM Opere o, Musei m
WHERE o.NomeM=m.NomeM
AND o.NomeA='Rembrandt'
AND m.Citta='London'

SELECT *
FROM Opere o, Musei m
WHERE o.NomeM=m.NomeM

-- 6
SELECT o.NomeA, o.Titolo
FROM Opere o, Musei m, Artisti a
WHERE o.NomeM=m.NomeM
AND a.NomeA=o.NomeA
AND a.Nazionalita='Italiana'
AND m.Citta='Florence'

-- 7
SELECT o.Codice, o.Titolo
FROM Opere o, Musei m, Artisti a, Personaggi p
WHERE o.NomeM=m.NomeM
AND a.NomeA=o.NomeA
AND p.Codice=o.Codice
AND m.Citta='Paris'
AND a.Nazionalita='Italiana'
AND p.Personaggio='Madonna'

-- 8
	SELECT m.NomeM, count(*) AS NumeroOpereItaliane
	FROM Opere o, Musei m, Artisti a
	WHERE o.NomeM=m.NomeM
	AND a.NomeA=o.NomeA
	AND m.Citta='London'
	AND a.Nazionalita='Italiana'
	GROUP BY m.NomeM

-- 9 
SELECT M.NomeM
	FROM Musei m
	WHERE m.Citta='London'
	AND NOT EXISTS (SELECT *
					FROM Opere o
					WHERE o.NomeM=m.NomeM
					AND o.NomeA='Tiziano Vecellio')

-- OPPURE

SELECT m.NomeM
FROM Musei m
WHERE m.Citta='London' 
AND 'Tiziano Vecellio' NOT IN (SELECT o.NomeA
					FROM Opere o
					WHERE o.NomeM=m.NomeM)

-- 10
SELECT M.NomeM
	FROM Musei m
	WHERE m.Citta='London'
	AND NOT EXISTS (SELECT *
					FROM Opere o
					WHERE o.NomeM=m.NomeM
					AND o.NomeA<>'Tiziano Vecellio')

--OPPURE
SELECT m.NomeM
FROM Musei m
WHERE m.Citta='London' 
AND 'Tiziano Vecellio' = ALL (SELECT o.NomeA
					FROM Opere o
					WHERE o.NomeM=m.NomeM)

-- 11
SELECT o.NomeA, count(*) AS Numero_Opere
	FROM Opere o
	WHERE o.NomeM='Galleria degli Uffizi'
	GROUP BY o.NomeA

-- 12
SELECT o.NomeM
FROM Opere o, Artisti a
WHERE o.NomeA=a.NomeA
AND a.Nazionalita='Italiana'
GROUP BY o.NomeM
HAVING COUNT(*)>=3

--OPPURE
SELECT m.NomeM
FROM Musei m
WHERE 3 <= (SELECT COUNT(*)
				FROM Opere o,Artisti a
				WHERE o.NomeA=a.NomeA
				AND o.NomeM=m.NomeM
				AND a.Nazionalita='Italiana')