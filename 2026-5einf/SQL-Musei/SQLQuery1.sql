-- 8)
SELECT m.NomeM, COUNT(*) AS NumOpere
FROM Opere o, Musei m, Artisti a
WHERE o.NomeA=a.NomeA
AND o.NomeM=m.NomeM
AND m.Citta='Londra'
AND a.Nazionalita='Italiana'
GROUP BY m.NomeM

-- 9)
SELECT m.NomeM
FROM Musei m
WHERE m.Citta='Londra'
AND NOT EXISTS (SELECT *
				FROM Opere o
				WHERE o.NomeA='Tiziano'
				AND o.NomeM=m.NomeM)

-- OPPURE

SELECT *
FROM Musei m
WHERE m.Citta='Londra'
AND 'Tiziano' NOT IN (SELECT o.NomeA
					  FROM Opere o
					  WHERE m.NomeM=o.NomeM)

-- 10) Musei Londra con SOLO opere di Tiziano
SELECT m.NomeM
FROM Musei m
WHERE m.Citta = 'Londra'
AND NOT EXISTS (SELECT *
				FROM Opere o
				WHERE o.NomeA <> 'Tiziano'
				AND m.NomeM=o.NomeM)

-- OPPURE

SELECT m.NomeM
FROM Musei m
WHERE m.Citta='Londra'
AND 'Tiziano' = ALL (SELECT o.NomeA
						FROM Opere o
						WHERE o.NomeM=m.NomeM)

-- 11)
SELECT o.NomeA, count(*) AS NumeroOpere
FROM Opere o
WHERE o.NomeM='Galleria degli Uffizi'
GROUP BY o.NomeA

-- 12) Almeno 20 opere artisti Italiani
SELECT o.NomeM
FROM Opere o, Artisti a
WHERE o.NomeA=a.NomeA
AND a.Nazionalita='Italiana'
GROUP BY o.NomeM
HAVING count(*) >= 18

-- OPPURE

SELECT *
FROM Musei m
WHERE 18 <= (SELECT count(*)
			FROM Opere o, Artisti a
			WHERE o.NomeA=a.NomeA
			AND a.Nazionalita='Italiana'
			AND o.NomeM=m.NomeM)

-- 13)
SELECT *
FROM Opere o, Artisti a
WHERE o.NomeA=a.NomeA
AND a.Nazionalita='Italiana'
AND NOT EXISTS (SELECT *
				FROM Personaggi p
				WHERE p.Codice=o.Codice)