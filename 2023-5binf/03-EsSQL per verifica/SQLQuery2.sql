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

-- 7. Il titolo ed il genere dei film proiettati a Napoli il giorno di Natale 2004
SELECT f.Titolo, f.Genere
FROM Film f, Proiezioni p, Sale s
WHERE f.Id = p.CodFilm
AND s.Id = p.codSala
AND s.Città = 'Napoli'
AND p.DataProiezione = '2004/12/25'; -- Oppure p.DataProiezione = '20041225'

-- 8. I nomi delle sale di Napoli in cui il giorno di Natale 2004 è stato proiettato un film con R.Williams
SELECT DISTINCT s.Nome
FROM Sale s, Proiezioni p, Attori a, Recita r
WHERE s.Città = 'Napoli'
AND p.DataProiezione = '2004/12/25'
AND p.CodSala = s.Id
AND p.CodFilm = r.CodFilm
AND r.CodAttore = a.Id
AND a.Nome = 'Williams';

-- 9. Il titolo dei film in cui recita M. Mastroianni oppure S.Loren
SELECT DISTINCT f.Titolo
FROM Film f, Attori a, Recita r
WHERE f.Id = r.CodFilm
AND a.Id = r.CodAttore
AND (a.Nome = 'Mastroianni' OR a.Nome = 'Loren');

-- 10. Il titolo dei film in cui recitano M. Mastroianni e S.Loren
SELECT f.Titolo
FROM Film f
WHERE 'Mastroianni' IN (SELECT a.Nome FROM Attori a, Recita r WHERE r.CodFilm = f.Id AND r.CodAttore = a.Id)
AND 'Loren' IN (SELECT a.Nome FROM Attori a, Recita r WHERE r.CodFilm = f.Id AND r.CodAttore = a.Id);

-- 13. Il numero di sale di Pisa con più di 60 posti
SELECT COUNT(*) AS NumeroSale
FROM Sale s
WHERE s.Città = 'Pisa'
AND s.Posti > 60;

-- 14. Il numero totale di posti nelle sale di Pisa
SELECT SUM(s.Posti) AS NumeroPostiTotale
FROM Sale s
WHERE s.Città = 'Pisa';