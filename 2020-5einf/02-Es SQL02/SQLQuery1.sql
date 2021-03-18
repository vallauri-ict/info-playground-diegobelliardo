--15 Per ogni museo il numero di opere divise per la nazionalità dell'artista
/*SELECT o.NomeM, a.Nazionalita, count(*) as NumeroOpere
FROM Artisti a, Opere o
WHERE a.NomeA=o.NomeA
GROUP BY o.NomeM, a.Nazionalita */

--14 Il nome dei musei di Londra che non conservano opere di artisti italiani, eccettuato Barbero
/*SELECT *
FROM Musei m
WHERE m.Citta='Ancona'
AND not exists (SELECT * FROM Opere o, Artisti a
WHERE a.NomeA=o.NomeA
AND m.NomeM=o.NomeM
AND a.Nazionalita='Italiana'
AND a.NomeA <> 'Barbero')*/

--13 Il titolo dell'opera ed il nome dell'artista delle opere di artisti italiani che non hanno personaggi
/*SELECT *
FROM Opere o, Artisti a
WHERE a.Nazionalita='Italiana'
AND o.NomeA=a.NomeA
AND not exists (SELECT * FROM Personaggi p
WHERE p.Codice=o.Codice)*/

--12 I musei che conservano almeno 20 opere di artisti italiani
/*SELECT o.NomeM
FROM Opere o, Artisti a
WHERE a.NomeA=o.NomeA
AND a.Nazionalita='Italiana'
GROUP BY o.NomeM
HAVING count(*)>=2 */

--11 Per ciscun artista, il nome dell'artista ed il numero di sue opere conservate alla "Galleria degli Uffizi"
/*SELECT o.NomeA, count(*) as NumeroOpere
FROM Opere o
WHERE o.NomeM='Fenice'
GROUP BY o.NomeA*/

--10 Il nome dei musei di Londra che conservano solo opere di Tiziano
SELECT *
FROM Musei m
WHERE m.Citta='Ancona'
AND not exists (SELECT * FROM Opere o
WHERE o.NomeM=m.NomeM
AND o.NomeA<>'Barbero')
AND exists (SELECT * FROM Opere o
WHERE o.NomeM=m.NomeM)

--10 bis
/*SELECT m.NomeM
FROM Musei m
WHERE m.Citta='Ancona'
AND 'Barbero'= ALL(SELECT o.NomeA FROM Opere o
WHERE o.NomeM=m.NomeM)*/
