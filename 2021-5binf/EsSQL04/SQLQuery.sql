/* Per ciascun museo di Londra il numero di opere di artisti ivi conservate*/

SELECT m.NomeMuseo, COUNT(*) AS NumeroOpere
FROM Artisti a, Opere o, Musei m
WHERE a.Nazionalita='IT'
AND a.NomeArtista=o.NomeArtista
AND m.NomeMuseo=o.NomeMuseo
AND m.Citta='Londra'
GROUP BY m.NomeMuseo

/* Il nome dei musei di Londra che non hanno opere di Tiziano */

SELECT m.NomeMuseo
FROM Musei m
WHERE m.Citta='Londra'
AND NOT EXISTS (SELECT * 
				FROM Opere o
				WHERE o.NomeArtista='Tiziano'
				AND o.NomeMuseo=m.NomeMuseo)
/* Versione 2 */
SELECT *
FROM Musei m
WHERE m.Citta='Londra'
AND 'Tiziano' NOT IN (SELECT o.NomeArtista 
					FROM Opere o 
					WHERE o.NomeMuseo=m.NomeMuseo)

/* I musei di Londra che hanno solo opere di Tiziano */

SELECT *
FROM Musei m
WHERE m.Citta='Londra'
AND NOT EXISTS (SELECT *
				FROM Opere o
				WHERE o.NomeArtista<>'Tiziano'
				AND o.NomeMuseo=m.NomeMuseo)

SELECT *
FROM Opere

SELECT *
FROM Musei m
WHERE m.Citta='Londra'
AND 'Tiziano' = ALL (SELECT o.NomeArtista 
					FROM Opere o 
					WHERE o.NomeMuseo=m.NomeMuseo)

/* 11. Per ciascun artista, il nome dell'artista ed il numero 
di sue opere conservate alla “Galleria degli Uffizi” */

SELECT o.NomeArtista,COUNT(*) as NOpere
FROM Opere o
WHERE o.NomeMuseo='Galleria degli Uffizi'
GROUP BY o.NomeArtista

/* 12. I musei che conservano almeno 2 opere di artisti italiani */
SELECT o.NomeMuseo, COUNT(*) as n
FROM Opere o, Artisti a
WHERE o.NomeArtista=a.NomeArtista
AND a.Nazionalita='IT'
GROUP BY o.NomeMuseo
HAVING COUNT(*)>1

SELECT m.NomeMuseo
FROM Musei m
WHERE 2<= (SELECT count(*)
			FROM Opere o, Artisti a
			WHERE o.NomeArtista=a.NomeArtista
			AND a.Nazionalita='IT'
			AND m.NomeMuseo=o.NomeMuseo)

/* 13- Per le opere di artisti italiani che non hanno personaggi. 
il titolo dell’opera ed il nome dell'artista */

SELECT a.NomeArtista, o.Titolo
FROM Artisti a, Opere o
WHERE a.Nazionalita='IT'
AND a.NomeArtista=o.NomeArtista
AND NOT EXISTS (SELECT *
				FROM Personaggi p
				WHERE p.Codice=o.Codice)

/* 14- Il nome dei musei di Londra che non conservano opere di 
artisti italiani, eccettuato Tiziano */
SELECT *
FROM Opere o, Musei m
WHERE o.NomeMuseo=m.NomeMuseo
AND m.Citta='Londra'
AND NOT EXISTS(SELECT *
			FROM Artisti a
			WHERE a.NomeArtista=o.NomeArtista
			AND a.NomeArtista<>'Tiziano' 
			AND a.Nazionalita='IT')

/* 15- Per ogni museo, il numero di opere divise per la nazionalità
dell'artista */
SELECT o.NomeMuseo,a.Nazionalita, COUNT(*) AS nOpere
FROM Artisti a, Opere o
WHERE a.NomeArtista=o.NomeArtista
GROUP BY o.NomeMuseo,a.Nazionalita
ORDER BY o.NomeMuseo


UPDATE Artisti
SET Nazionalita='ES'
WHERE NomeArtista='Picasso'