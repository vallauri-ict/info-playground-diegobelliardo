-- RENAME COLUMN
EXEC sp_rename 'Film.Registra', 'Regista', 'COLUMN';

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
SELECT DISTINCT F.Titolo
FROM FILM F
JOIN RECITA R ON F.CodFilm = R.CodFilm
JOIN ATTORI A ON R.CodAttore = A.CodAttore
WHERE A.Nome IN ('Mastroianni', 'Loren')

SELECT DISTINCT F.Titolo
FROM FILM F ,RECITA R ,ATTORI A
WHERE A.Nome IN ('Mastroianni', 'Loren')
AND f.codFilm=r.codFilm
AND r.codAttore=a.codAttore

SELECT *
FROM Film f LEFT JOIN Recita r ON f.codFilm=r.codFilm

--10- Il titolo dei film in cui recitano M. Mastroianni e S.Loren
SELECT F.Titolo
FROM FILM F
WHERE F.CodFilm IN (
    SELECT R1.CodFilm
    FROM RECITA R1
    JOIN ATTORI A1 ON R1.CodAttore = A1.CodAttore
    WHERE A1.Nome = 'Mastroianni'
)
AND F.CodFilm IN (
    SELECT R2.CodFilm
    FROM RECITA R2
    JOIN ATTORI A2 ON R2.CodAttore = A2.CodAttore
    WHERE A2.Nome = 'Loren'
);


--11- Per ogni film in cui recita un attore francese, il titolo del 
--film e il nome dell’attore
SELECT DISTINCT F.Titolo, A.Nome
FROM FILM F
JOIN RECITA R ON F.CodFilm = R.CodFilm
JOIN ATTORI A ON R.CodAttore = A.CodAttore
WHERE A.Nazionalita = 'IT';

--12- Per ogni film che è stato proiettato a Pisa nel gennaio 2005,
-- il titolo del film e il nome della sala.
SELECT DISTINCT F.Titolo, S.Nome
FROM FILM F
JOIN PROIEZIONI P ON F.CodFilm = P.CodFilm
JOIN SALE S ON P.CodSala = S.CodSala
WHERE S.Citta = 'Pisa'
  AND P.DataProiezione BETWEEN '2005-01-01' AND '2005-01-31';

--13- Il numero di sale di Pisa con più di 60 posti
SELECT COUNT(*)
FROM SALE
WHERE Citta = 'Pisa' AND Posti > 60;

--14- Il numero totale di posti nelle sale di Pisa
SELECT SUM(Posti)
FROM SALE
WHERE Citta = 'Pisa';

--15- Per ogni città, il numero di sale
SELECT s.Citta, count(*)
FROM Sale s
GROUP BY s.Citta

--16- Per ogni città, il numero di sale con più di 60 posti
SELECT Citta, COUNT(*) AS NumeroSale
FROM SALE
WHERE Posti > 60
GROUP BY Citta;

--17- Per ogni regista, il numero di film diretti dopo il 1990
SELECT Regista, COUNT(*) AS NumeroFilm
FROM FILM
WHERE AnnoProduzione > 1990
GROUP BY Regista;

--18- Per ogni regista, l’incasso totale di tutte le proiezioni 
--dei suoi film
SELECT F.Regista, SUM(P.Incasso) AS IncassoTotale
FROM FILM F
JOIN PROIEZIONI P ON F.CodFilm = P.CodFilm
GROUP BY F.Regista;

--19- Per ogni film di S.Spielberg, il titolo del film, il numero 
--totale di proiezioni a Pisa e l’incasso totale
SELECT F.Titolo,
       COUNT(P.CodProiezione) AS NumeroProiezioni,
       SUM(P.Incasso) AS IncassoTotale
FROM FILM F
JOIN PROIEZIONI P ON F.CodFilm = P.CodFilm
JOIN SALE S ON P.CodSala = S.CodSala
WHERE F.Regista = 'Spielberg' AND S.Citta = 'Pisa'
GROUP BY F.CodFilm, F.Titolo;