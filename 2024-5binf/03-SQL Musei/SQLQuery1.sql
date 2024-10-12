--1- Il codice ed il titolo delle opere di Tiziano conservate alla “National Gallery”.

SELECT o.Id,o.titolo
FROM opere o
WHERE o.nomeA='Tiziano'
AND o.nomeM='National Gallery'

--2- Il nome dell’artista ed il titolo delle opere conservate alla “Galleria degli Uffizi” o alla
--“National Gallery”.

SELECT o.nomeA, o.titolo
FROM opere o
WHERE o.nomeM in ('Galleria degli Uffizi', 'National Gallery')

--3- Il nome dell’artista ed il titolo delle opere conservate nei musei di Firenze
SELECT o.nomeA, o.titolo
FROM opere o, musei m
WHERE m.citta='Firenze'
AND o.nomeM=m.nomeM



--4- Le città in cui son conservate opere di Caravaggio
SELECT distinct m.citta
FROM musei m, opere o
WHERE o.nomeM=m.nomeM
AND o.nomeA='Caravaggio'

--5- Il codice ed il titolo delle opere di Tiziano conservate nei musei di Londra
SELECT o.Id, o.titolo
FROM opere o, musei m
WHERE o.nomeM=m.nomeM
AND m.citta='Londra'
AND o.nomeA='Tiziano'
--6- Il nome dell’artista ed il titolo delle opere di artisti spagnoli conservate nei musei di Firenze
SELECT o.nomeA, o.titolo
FROM artisti a, opere o, musei m
WHERE a.nazionalita='Spagnola'
AND o.nomeA=a.nomeA
AND m.nomeM=o.nomeM
AND m.citta='Firenze'

--7- Il codice ed il titolo delle opere di artisti italiani conservate nei musei di Londra, in cui è
--rappresentata la Madonna
SELECT o.Id, o.titolo
FROM opere o, artisti a, musei m, personaggi p
WHERE o.nomeA=a.nomeA
AND o.nomeM=m.nomeM
AND p.codiceO=o.Id
AND a.nazionalita='Italiana'
AND m.citta='Londra'
AND p.personaggio='Madonna'

--8- Per ciascun museo di Londra, il numero di opere di artisti italiani ivi conservate
SELECT m.nomeM, COUNT(*) NumOpere
FROM musei m, opere o, artisti a
WHERE m.nomeM=o.nomeM
AND m.citta='Londra'
AND a.nomeA=o.nomeA
AND a.nazionalita='Italiana'
GROUP BY m.nomeM
--9- Il nome dei musei di Londra che non conservano opere di Tiziano
SELECT m.nomeM
FROM musei m
WHERE m.citta='Londra'
AND NOT EXISTS (SELECT *
				FROM opere o
				WHERE o.nomeM=m.nomeM
				AND o.nomeA='Tiziano')

-- OPPURE
SELECT m.nomeM
FROM musei m
WHERE m.citta = 'Londra'
AND 'Tiziano' NOT IN (SELECT o.nomeA
					  FROM opere o
					  WHERE o.nomeM=m.nomeM)

--10- Il nome dei musei di Londra che conservano solo opere di Tiziano
SELECT m.nomeM
FROM musei m
WHERE m.citta='Londra'
AND NOT EXISTS (SELECT *
				FROM opere o
				WHere o.nomeM=m.nomeM
				AND o.nomeA<>'Tiziano')

-- OPPURE
SELECT m.nomeM
FROM musei m
WHERE m.citta='Londra'
AND 'Tiziano' = ALL (SELECT o.nomeA
					 FROM opere o
					 WHERE o.nomeM=m.nomeM)
--11- Per ciascun artista, il nome dell’artista ed il numero di sue opere conservate alla “Galleria
--degli Uffizi”
SELECT o.nomeA, count(*) AS Numero_Opere
FROM opere o
WHERE o.nomeM='Galleria degli uffizi'
GROUP BY o.nomeA

--12- I musei che conservano almeno 20 opere di artisti italiani
SELECT o.nomeM
FROM opere o, artisti a
WHERE o.nomeA=a.nomeA
AND a.nazionalita='Italiana'
GROUP BY o.nomeM
HAVING count(*)>=5

-- OPPURE
SELECT *
FROM musei m
WHERE 4<=(SELECT count(*)
			FROM opere o, artisti a
			WHERE o.nomeA=a.nomeA
			AND m.nomeM=o.nomeM
			AND a.nazionalita='Italiana')

--13- Per le opere di artisti italiani che non hanno personaggi, il titolo dell’opera ed il nome
--dell’artista
SELECT o.titolo, o.nomeA
FROM opere o, artisti a
WHERE o.nomeA=a.nomeA
AND a.nazionalita='Italiana'
AND NOT EXISTS (SELECT *
				FROM personaggi p
				WHERE p.codiceO=o.Id)


--14- Il nome dei musei di Londra che non conservano opere di artisti italiani, 
--eccettuato Tiziano
SELECT *
FROM musei m 
WHERE m.citta='Londra'
AND NOT EXISTS (SELECT *
				FROM opere o, artisti a
				WHERE o.nomeM=m.nomeM
				AND o.nomeA=a.nomeA
				AND a.nazionalita='Italiana'
				AND a.nomeA<>'Tiziano')
--15- Per ogni museo, il numero di opere divise per la nazionalità dell’artista