--1- Il nome di tutte le sale di Pisa

SELECT s.Nome
FROM Sale s
WHERE s.Citta='Pisa'

--2- Il titolo dei film di F. Fellini prodotti dopo il 1960
SELECT f.Titolo
FROM Film f
WHERE f.Regista='Fellini'
AND f.AnnoProduzione > 1960

--3- Il titolo e la durata dei film di fantascienza giapponesi 
--o francesi prodotti dopo il 1990
SELECT *
FROM Film f
WHERE f.Nazionalita in ('Francese','Giapponese')
And f.AnnoProduzione>1990
and f.Genere='Fantascienza'

--4- Il titolo dei film di fantascienza giapponesi prodotti 
--dopo il 1990 oppure francesi
SELECT *
FROM Film f
WHERE (f.Genere='Fantascienza'
and f.Nazionalita = 'Giapponese'
And f.AnnoProduzione>1990)
or f.Nazionalita='Francese'

--5- I titolo dei film dello stesso regista di “Casablanca”
SELECT *
FROM Film f
Where f.Regista=(SELECT f1.Regista FROM Film f1 
				WHERE f1.Titolo='Casablanca')
And f.Titolo <> 'Casablanca'

--6- Il titolo ed il genere dei film proiettati il giorno 
--di Natale 2004
SELECT f.Titolo, f.Genere
FROM Film f, Proiezioni p
WHERE f.Id=p.CodFilm
AND p.DataProiezione='2004/12/25'