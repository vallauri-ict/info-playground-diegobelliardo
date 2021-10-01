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
