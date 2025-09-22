
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

-- 20- Per ogni regista e per ogni attore, 
-- il numero di film del regista con l'attore
SELECT f.Regista, a.Nome, Count(*) AS Numero_Film
FROM Film f, Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
GROUP BY f.Regista, a.Nome

-- 21 - Il regista ed il titolo dei film in cui recitano meno di 6 attori
SELECT f.Regista, f.Titolo, count(*)
FROM Film f, Recita r
WHERE f.CodFilm=r.CodFilm
GROUP BY r.CodFilm, f.Regista, f.Titolo
HAVING COUNT(*)<2

-- VARIANTE PER FAR COMPARIRE ANCHE I FILM SENZA ATTORI
SELECT f.Regista, f.Titolo, count(r.CodAttore)
FROM Film f LEFT JOIN Recita r ON f.CodFilm=r.CodFilm
GROUP BY r.CodFilm, f.Regista, f.Titolo
HAVING COUNT(*)<2

-- OPPURE

SELECT f.Regista, f.Titolo
FROM Film f
WHERE 2>(SELECT count(*)
            FROM Recita r
            WHERE r.CodFilm=f.CodFilm)

-- 22- Per ogni film prodotto dopo il 2000, il codice, il titolo 
-- e l'incasso totale di tutte le sue proiezioni
SELECT f.CodFilm, f.Titolo, SUM(p.Incasso) as Incasso
FROM Film f, Proiezioni p
WHERE f.AnnoProduzione>2000
AND f.CodFilm=p.CodFilm
GROUP BY f.CodFilm, f.Titolo

-- 23 - Il numero di attori dei film in cui appaiono solo attori 
-- nati prima del 1970
SELECT f.Titolo
FROM Film f, Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
--AND a.AnnoNascita<1970
GROUP BY f.Titolo
HAVING MAX(a.AnnoNascita)<1970

SELECT f.Titolo
FROM Film f, Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
AND a.AnnoNascita<1970
GROUP BY f.Titolo

-- 24- Per ogni film di fantascienza, il titolo e l'incasso totale di tutte 
-- le sue proiezioni

SELECT f.Titolo, SUM(p.Incasso) AS Incasso
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
AND f.Genere='Fantascienza'
GROUP BY f.CodFilm, f.Titolo

-- 25- Per ogni film di fantascienza il titolo e l'incasso totale 
-- di tutte le sue proiezioni successive al 1/1/01

SELECT f.Titolo, SUM(p.Incasso) AS Incasso
FROM Film f, Proiezioni p 
WHERE f.CodFilm=p.CodFilm
AND p.DataProiezione>'2001-01-01'
AND f.Genere='Fantascienza'
GROUP BY f.CodFilm, f.Titolo

-- 26- Per ogni film di fantascienza che non è mai stato proiettato 
-- prima del 1/1/01 il titolo e l'incasso totale di tutte le sue proiezioni

SELECT f.Titolo, SUM(p.Incasso) AS Incasso
FROM Film f, Proiezioni p
WHERE f.Genere='Fantascienza'
AND f.CodFilm=p.CodFilm
GROUP BY f.CodFilm, f.Titolo
HAVING MIN(p.DataProiezione)>'2001-01-01'

-- 27- Per ogni sala di Pisa, che nel mese di gennaio 2005 ha incassato 
-- più di 20000 €, il nome della sala e l'incasso totale 
-- (sempre del mese di gennaio 2005)

SELECT s.Nome, SUM(p.Incasso)
FROM Sale s, Proiezioni p
WHERE p.CodSale=s.CodSala
AND s.Citta='Pisa'
AND p.DataProiezione BETWEEN '2005-01-01' AND '2005-01-31'
GROUP BY s.CodSala, s.Nome
HAVING SUM(p.Incasso)>20000

-- 28- I titoli dei film che non sono mai stati proiettati a Pisa

SELECT f.Titolo
FROM Film f
WHERE NOT EXISTS(SELECT *
                    FROM Proiezioni p, Sale s
                    WHERE p.CodSale=s.CodSala
                    AND p.CodFilm=f.CodFilm
                    AND s.Citta='Pisa')

-- OPPURE

SELECT f.Titolo
FROM Film f
WHERE 'Pisa' not in (SELECT s.Citta
                        FROM Proiezioni p, Sale s
                        WHERE p.CodFilm=f.CodFilm
                        AND p.CodSale=s.CodSala)

-- 29- I titoli dei film che sono stati proiettati solo a Pisa 

SELECT f.Titolo
FROM Film f
WHERE NOT EXISTS (SELECT *
                    FROM Proiezioni p, Sale s
                    WHERE p.CodFilm=f.CodFilm
                    AND p.CodSale=s.CodSala
                    AND s.Citta <> 'Pisa')
AND EXISTS (SELECT *
                    FROM Proiezioni p, Sale s
                    WHERE p.CodFilm=f.CodFilm
                    AND p.CodSale=s.CodSala)

-- OPPURE

SELECT f.Titolo
FROM Film f
WHERE 'Pisa' = ALL(SELECT s.Citta
                    FROM Proiezioni p, Sale s
                    WHERE p.CodFilm=f.CodFilm
                    AND p.CodSale=s.CodSala)

-- 30- I titoli dei film dei quali non vi è mai stata una proiezione 
-- con incasso superiore a 500 € 
SELECT f.Titolo
FROM Film f
WHERE NOT EXISTS (SELECT *
                    FROM Proiezioni p
                    WHERE p.CodFilm=f.CodFilm
                    AND p.Incasso>500)

SELECT f.Titolo
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
GROUP BY f.CodFilm, f.Titolo
HAVING MAX(p.incasso)<=500

-- 31- I titoli dei film le cui proiezioni hanno sempre ottenuto un 
-- incasso superiore a 500 € 

SELECT f.CodFilm,f.Titolo
FROM Film f
WHERE NOT EXISTS (SELECT *
                    FROM Proiezioni p
                    WHERE p.CodFilm=f.CodFilm
                    AND p.Incasso<=500)

SELECT f.CodFilm,f.Titolo
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
GROUP BY f.CodFilm, f.Titolo
HAVING MIN(p.incasso)>500

-- 32- Il nome degli attori italiani che non hanno mai recitato in film di Fellini 
SELECT a.Nome
FROM Attori a
WHERE a.Nazionalita='Italiana'
AND NOT EXISTS (SELECT *
                FROM Film f, Recita r
                WHERE r.CodAttore=a.CodAttore
                AND r.CodFilm=f.CodFilm
                AND f.Regista='Fellini')

-- 33- Il titolo dei film di Fellini in cui non recitano attori italiani 
SELECT F.Titolo
FROM Film f
WHERE f.Regista='F. Fellini'
AND NOT EXISTS (SELECT *
                FROM Attori a, Recita r
                WHERE r.CodFilm=f.CodFilm
                AND r.CodAttore=a.CodAttore
                AND a.Nazionalita='Italiana')

-- 34- Il titolo dei film senza attori 
SELECT *
FROM Film f
WHERE NOT EXISTS (SELECT *
                    FROM Recita r
                    WHERE r.CodFilm=f.CodFilm)

-- 35- Gli attori che prima del 1960 hanno recitato solo nei film di Fellini 
SELECT a.Nome
FROM Attori a
WHERE NOT EXISTS (SELECT *
                    FROM Film f, Recita r
                    WHERE r.CodAttore=a.CodAttore
                    AND f.CodFilm=r.CodFilm
                    AND f.AnnoProduzione<1960
                    AND f.Regista<>'F. Fellini')
AND EXISTS (SELECT *
                    FROM Film f, Recita r
                    WHERE r.CodAttore=a.CodAttore
                    AND f.CodFilm=r.CodFilm
                    AND f.AnnoProduzione<1960
                    AND f.Regista='F. Fellini')

-- 36- Gli attori che hanno recitato in film di Fellini solo prima del 1960 
SELECT *
FROM Attori a
WHERE NOT EXISTS (SELECT *
                    FROM Film f, Recita r
                    WHERE f.CodFilm=r.CodFilm
                    AND r.CodAttore=a.CodAttore
                    AND f.AnnoProduzione>1960
                    AND f.Regista='F. Fellini')
AND EXISTS (SELECT *
                    FROM Film f, Recita r
                    WHERE f.CodFilm=r.CodFilm
                    AND r.CodAttore=a.CodAttore
                    AND f.AnnoProduzione<=1960
                    AND f.Regista='F. Fellini')