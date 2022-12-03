-- 1- Il nome di tutte le sale di Pisa

SELECT s.Nome
FROM Sale s
WHERE s.Citta='Fossano'

-- 2- Il titolo dei film di F. Fellini prodotti dopo il 1960.

SELECT f.Titolo
FROM Film f
WHERE f.AnnoProduzione>1960
AND f.Regista='Pietro Valsecchi'

-- 3- Il titolo e la durata dei film di fantascienza giapponesi o francesi prodotti dopo il 1990

SELECT f.Titolo
FROM Film f
WHERE f.Genere='Fantascienza'
AND (f.Nazionalita='Giapponese' OR f.Nazionalita='Francese')
AND f.AnnoProduzione>1990

-- 4- Il titolo dei film di fantascienza giapponesi prodotti dopo il 1990 oppure francesi

SELECT f.Titolo
FROM Film f
WHERE f.Genere='Fantascienza'
AND (f.Nazionalita='Giapponese' 
AND f.AnnoProduzione>1990)
OR f.Nazionalita='Francese'

-- 5- I titolo dei film dello stesso regista di “Casablanca”

SELECT f.Titolo
FROM Film f 
WHERE f.Regista=(SELECT f1.Regista
				FROM Film f1
				WHERE f1.Titolo='LE FORZE DEL DESTINO')

-- 6- Il titolo ed il genere dei film proiettati il giorno di Natale 2004

SELECT DISTINCT f.Titolo,f.Genere
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
AND p.DataProiezione='2004-12-25'

-- 7- Il titolo ed il genere dei film proiettati a Napoli 
-- il giorno di Natale 2004

SELECT DISTINCT f.Titolo,f.Genere
FROM Film f,Proiezioni p, Sale s
WHERE p.DataProiezione='2004-12-25'
AND s.Citta='Napoli'
AND f.CodFilm=p.CodFilm
AND s.CodSala=p.CodSala

-- 8- I nomi delle sale di Napoli in cui il giorno di 
-- Natale 2004 è stato proiettato un film con R.Williams

SELECT DISTINCT s.Nome
FROM Sale s, Proiezioni p, Film f
WHERE s.CodSala=p.CodSala
AND p.CodFilm=f.CodFilm
AND f.Regista='R.Williams'
AND p.DataProiezione='2004-12-25'
AND s.Citta='Napoli'

-- 9- Il titolo dei film in cui recita
-- M. Mastroianni oppure S.Loren

SELECT DISTINCT f.Titolo
FROM Film f,Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
AND (a.Nome='M. Mastroianni' OR a.Nome='S.Loren')

-- 10- Il titolo dei film in cui
-- recitano M. Mastroianni e S.Loren

SELECT DISTINCT f.Titolo
FROM Film f,Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
AND a.Nome='M. Mastroianni' 
AND f.CodFilm=(SELECT r1.CodFilm
				FROM Recita r1, Attori a1
				WHERE f.CodFilm=r1.CodFilm
				AND a1.Nome='S.Loren'
				AND a1.CodAttore=r1.CodAttore)

SELECT f.Titolo
FROM Film f
WHERE 'S.Loren' IN (SELECT a.Nome
					FROM Attori a, Recita r
					WHERE f.CodFilm=r.CodFilm
					AND r.CodAttore=a.CodAttore)
AND 'M. Mastroianni' IN (SELECT a.Nome
					FROM Attori a, Recita r
					WHERE f.CodFilm=r.CodFilm
					AND r.CodAttore=a.CodAttore)

-- 11- Per ogni film in cui recita un
-- attore francese, il titolo del film e il nome dell’attore

SELECT f.Titolo, a.Nome
FROM Film f, Attori a, Recita r
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
AND a.Nazionalita='Francese'

-- 12- Per ogni film che è stato proiettato a Pisa 
-- nel gennaio 2005, il titolo del film e il nome della sala.

SELECT DISTINCT f.Titolo, s.Nome
FROM Film f, Proiezioni p, Sale s
WHERE f.CodFilm=p.CodFilm
AND p.CodSala=s.CodSala
AND s.Citta='Pisa'
AND p.DataProiezione BETWEEN '2005-01-01' AND '2005-01-31'

-- 13- Il numero di sale di Pisa con più di 60 posti

SELECT COUNT(*)
FROM Sale s
WHERE s.Posti>60
AND s.Citta='Pisa'

-- 14- Il numero totale di posti nelle sale di Pisa

SELECT SUM(s.Posti)
FROM Sale s
WHERE s.Citta='Pisa'

-- 15- Per ogni città, il numero di sale

SELECT s.Citta,COUNT(*)
FROM Sale s
GROUP BY s.Citta

-- 16- Per ogni città, il numero di sale con più di 60 posti

SELECT s.Citta,COUNT(*)
FROM Sale s
WHERE s.Posti>60
GROUP BY s.Citta

-- 17- Per ogni regista, il numero di film diretti dopo il 1990

SELECT f.Regista, COUNT(*)
FROM Film f
WHERE f.AnnoProduzione>1990
GROUP BY f.Regista

-- 18- Per ogni regista, l’incasso 
-- totale di tutte le proiezioni dei suoi film

SELECT f.Regista, SUM(p.incasso) AS Incasso
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
GROUP BY f.Regista

-- 19- Per ogni film di S.Spielberg, il titolo del film, 
-- il numero totale di proiezioni a Pisa e l’incasso totale

SELECT f.Titolo, SUM(p.Incasso) as Incasso, COUNT(*) as Numero_Proiezioni
FROM Proiezioni p, Sale s, Film f
WHERE f.Regista='S.Spielberg'
AND f.CodFilm=p.CodFilm
AND s.CodSala=p.CodSala
AND s.Citta='Pisa'
GROUP BY f.Titolo

-- 20- Per ogni regista e per ogni attore, il numero di film del regista con l’attore

SELECT f.Regista,a.Nome, COUNT(*)
FROM Film f, Attori a, Recita r
WHERE f.CodFilm=r.CodFilm
AND a.CodAttore=r.CodAttore
GROUP BY f.Regista, a.CodAttore, a.Nome
