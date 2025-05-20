-- RENAME COLUMN
EXEC sp_rename 'Film.Nazionalità', 'Nazionalita', 'COLUMN';

--1- Il nome di tutte le sale di Pisa
SELECT s.Nome
FROM Sale s
WHERE s.Citta = 'Pisa'

--2- Il titolo dei film di F. Fellini prodotti dopo il 1960.
SELECT f.titolo
FROM Film f
WHERE f.Registra = 'Fellini' AND f.annoProduzione > 1960

--3- Il titolo e la durata dei film di fantascienza giapponesi o francesi prodotti dopo il 1990
SELECT f.titolo
FROM Film f
WHERE ((f.Nazionalita = 'JP'
AND f.Genere = 'Fantascienza')
OR (f.Nazionalita = 'FR'))
AND f.annoProduzione > 1990

--4- Il titolo dei film di fantascienza giapponesi prodotti dopo il 1990 oppure francesi
SELECT f.titolo
FROM Film f
WHERE (f.Nazionalita = 'FR') 
OR (f.Nazionalita = 'JP' AND f.Genere = 'Fantascienza' AND f.annoProduzione > 1990)

--5- I titolo dei film dello stesso regista di “Casablanca”
SELECT f.titolo	
FROM Film f
WHERE f.Registra = (SELECT f.Registra 
					FROM Film f
					WHERE f.titolo = 'Casablanca')
AND f.titolo <> 'Casablanca'

--6- Il titolo ed il genere dei film proiettati il giorno di Natale 2004
SELECT f.titolo, f.Genere
FROM Film f, Proiezioni p
WHERE f.codFilm=p.codFilm
AND p.DataProiezione= '2004-12-25'

--7- Il titolo ed il genere dei film proiettati a Napoli il giorno 
-- di Natale 2004
SELECT f.titolo, f.Genere
FROM Film f, Proiezioni p, Sale s
WHERE f.codFilm=p.codFilm
AND s.CodSala=p.codSala
AND p.DataProiezione= '2004-12-25'
AND s.Citta='Napoli'

--8- I nomi delle sale di Napoli in cui il giorno di Natale 2004 è 
--stato proiettato un film con R.Williams
SELECT s.Nome
FROM Film f, Proiezioni p, Sale s, Recita r, Attori a
WHERE f.codFilm=r.codFilm
AND r.codAttore=a.codAttore
AND p.codFilm=f.codFilm
AND p.codSala=s.CodSala
AND p.DataProiezione= '2004-12-25'
AND s.Citta='Napoli'
AND a.Nome='Williams'

--9- Il titolo dei film in cui recita M. Mastroianni oppure S.Loren

--10- Il titolo dei film in cui recitano M. Mastroianni e S.Loren

--11- Per ogni film in cui recita un attore francese, il titolo del 
--film e il nome dell’attore

--12- Per ogni film che è stato proiettato a Pisa nel gennaio 2005,
-- il titolo del film e il nome della sala.

--15- Per ogni città, il numero di sale
SELECT s.Citta, count(*)
FROM Sale s
GROUP BY s.Citta