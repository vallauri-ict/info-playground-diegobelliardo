
/* 5- Il titolo dei film dello stesso regista di "Casablanca" */

SELECT Titolo as TITOLONE, Regista
FROM Film
WHERE Regista = (
    SELECT Regista
    FROM Film
    WHERE Titolo = 'Casablanca'
);

/* 6- Il titolo ed il genere dei film proiettati il giorno di Natale 2004 */
SELECT DISTINCT f.Titolo,f.Genere
FROM Film f, Proiezioni p
WHERE f.CodFilm = p.CodFilm
AND p.DataProiezione='2004-12-25'

/* 7- Il titolo ed il genere dei film proiettati a Napoli il giorno di Natale 2004  */
SELECT DISTINCT f.Titolo,f.Genere
FROM Film f, Proiezioni p, Sale s
WHERE f.CodFilm=p.CodFilm
AND s.CodSala=p.CodSale
AND s.Citta='Napoli'
AND p.DataProiezione='2004-12-25'

/* 8- I nomi delle sale di Napoli in cui il giorno di Natale 2004 è stato proiettato un film con 
R.Williams 
*/

SELECT DISTINCT s.Nome, f.Titolo, a.Nome
FROM Sale s, Proiezioni p, Film f, Recita r, Attori a
WHERE s.CodSala=p.CodSale
AND f.CodFilm=p.CodFilm
AND r.CodFilm=f.CodFilm
AND r.CodAttore=a.CodAttore
AND p.DataProiezione='2004-12-25'
AND s.Citta='Napoli'
AND a.Nome='R.Williams'

/* 9- Il titolo dei film in cui recita M. Mastroianni oppure S.Loren */
SELECT f.Titolo
FROM Film f, Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
AND (a.Nome='Mastroianni' OR a.Nome='Sophia Loren')

-- 10- Il titolo dei film in cui recitano M. Mastroianni e S.Loren
SELECT f.Titolo
FROM Film f
WHERE 'Mastroianni' IN (SELECT a.Nome
                        FROM Attori a, Recita r
                        WHERE r.CodFilm=f.CodFilm
                        AND r.CodAttore=a.CodAttore)
AND 'Sophia Loren' IN (SELECT a.Nome
                        FROM Attori a, Recita r
                        WHERE r.CodFilm=f.CodFilm
                        AND r.CodAttore=a.CodAttore)

-- 11- Per ogni film in cui recita un attore francese, il titolo del film e il nome dell'attore
SELECT f.Titolo, a.Nome
FROM Film f, Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
AND a.Nazionalita='Francia'

-- 12- Per ogni film che è stato proiettato a Pisa nel gennaio 2005, il titolo del film 
-- e il nome della sala.
SELECT DISTINCT f.Titolo, s.Nome
FROM Film f,Proiezioni p, Sale s
WHERE f.CodFilm=p.CodFilm
AND p.CodSale=s.CodSala
AND s.Citta='Pisa'
AND p.DataProiezione>='2005-01-01'
AND p.DataProiezione<='2005-01-31'

-- 13- Il numero di sale di Pisa con più di 60 posti 
SELECT Count(*)
FROM Sale s
WHERE s.Posti>60
AND s.Citta='Pisa'

-- 14- Il numero totale di posti nelle sale di Pisa 
SELECT Sum(s.posti)
FROM Sale s
WHERE s.Citta='Pisa'

-- 15- Per ogni città, il numero di sale
SELECT s.citta, Count(*) as Numero_Sale
FROM Sale s
GROUP BY s.Citta

-- 16- Per ogni città, il numero di sale con più di 60 posti 
SELECT s.citta, Count(*) as Numero_Sale
FROM Sale s
WHERE s.Posti>60
GROUP BY s.Citta

-- 17- Per ogni regista, il numero di film diretti dopo il 1990 
SELECT f.regista, Count(*) AS Numero_Film
FROM Film f
WHERE f.AnnoProduzione > 1990
GROUP BY f.Regista

-- 18- Per ogni regista, l'incasso totale di tutte le proiezioni dei suoi film
SELECT f.regista, Sum(p.incasso) AS Incasso
FROM Film f, Proiezioni p
WHERE p.CodFilm=f.CodFilm
GROUP BY f.Regista

-- 19- Per ogni film di S.Spielberg, il titolo del film, il numero totale di proiezioni a 
-- Pisa e l'incasso totale
SELECT f.Titolo, Count(*) AS Num_Proiezioni, SUM(p.Incasso) AS Incasso
FROM Film f, Proiezioni p, Sale s
WHERE f.CodFilm=p.CodFilm
AND p.CodSale=s.CodSala
AND f.Regista='Spielberg'
AND s.Citta='Pisa'
GROUP BY f.Titolo


