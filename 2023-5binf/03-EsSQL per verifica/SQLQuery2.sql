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


--11- Per ogni film in cui recita un attore francese, il titolo del film e il nome dell’attore
SELECT f.Titolo, a.Nome
FROM Attori a, Film f, Recita r
WHERE a.Id=r.CodAttore
AND r.CodFilm=f.Id
AND a.Nazionalità='Francese'


--12- Per ogni film che è stato proiettato a Pisa nel gennaio 2005, il titolo del film e il nome della sala.
SELECT distinct f.Titolo, s.Nome
FROM Film f, Proiezioni p, Sale s
WHERE f.Id=p.CodFilm
AND p.CodSala=s.Id
AND s.Città='Pisa'
AND YEAR(p.DataProiezione)=2005
AND MONTH(p.DataProiezione)=1


-- 13. Il numero di sale di Pisa con più di 60 posti
SELECT COUNT(*) AS NumeroSale
FROM Sale s
WHERE s.Città = 'Pisa'
AND s.Posti > 60;

-- 14. Il numero totale di posti nelle sale di Pisa
SELECT SUM(s.Posti) AS NumeroPostiTotale
FROM Sale s
WHERE s.Città = 'Pisa';

--15- Per ogni città, il numero di sale
SELECT s.Città, count(*)
FROM Sale s
GROUP BY s.Città


--16- Per ogni città, il numero di sale con più di 60 posti
SELECT s.Città, count(*)
FROM Sale s
WHERE s.Posti>60
GROUP BY s.Città


--17- Per ogni regista, il numero di film diretti dopo il 1990

SELECT f.Regista, count(*)
FROM Film f
WHERE f.AnnoProduzione>1990
GROUP BY f.Regista

--18- Per ogni regista, l’incasso totale di tutte le proiezioni dei suoi film
SELECT f.Regista, sum(p.incasso)
FROM Film f, Proiezioni p
WHERE f.Id=p.CodFilm
GROUP BY f.Regista


--19- Per ogni film di S.Spielberg, il titolo del film, 
--il numero totale di proiezioni a Pisa e l’incasso totale
SELECT f.Titolo, count(*) AS N_Proiezioni, SUM(p.Incasso) AS Incasso_Totale
FROM Film f, Proiezioni p, Sale s
WHERE f.Id=p.CodFilm
AND p.CodSala=s.Id
AND f.Regista='Spielberg'
AND s.Città='Pisa'
GROUP BY f.Titolo


--20- Per ogni regista e per ogni attore, il numero di film del regista 
--con l’attore
SELECT f.Regista, a.nome, count(*)
FROM Attori a, Recita r, Film f
WHERE f.Id=r.CodFilm
AND r.CodAttore=a.Id
GROUP BY f.Regista, a.Id, a.Nome


--21 - Il regista ed il titolo dei film in cui recitano meno di 6 attori
SELECT f.Regista, f.Titolo
FROM Film f, Recita r
WHERE f.Id=r.CodFilm
GROUP BY f.Titolo,f.Regista
HAVING count(*)<6

-- La soluzione sotto risolve il problema dei film senza attori che
-- nella precedente non venivano estratti

SELECT f.Regista, f.Titolo
FROM Film f
WHERE 6>(SELECT count(*)
			FROM Recita r
			WHERE f.Id=r.CodFilm)


--22- Per ogni film prodotto dopo il 2000, il codice, il titolo e 
-- l’incasso totale di tutte le sue proiezioni
SELECT f.Id, f.Titolo, SUM(p.Incasso) AS Incasso_Totale
FROM Film f, Proiezioni p
WHERE f.Id=p.CodFilm
AND f.annoProduzione>2000
GROUP BY f.Id, f.Titolo

--23 - Il numero di attori dei film in cui appaiono solo attori nati 
-- prima del 1970
SELECT f.Titolo, count(*) as NumeroAttori
FROM Film f, Recita r, Attori a
WHERE f.Id=r.CodFilm
AND r.CodAttore=a.Id
GROUP BY f.Titolo
HAVING MAX(a.AnnoNascita)<1970

--24- Per ogni film di fantascienza, il titolo e l’incasso totale di tutte le sue proiezioni
SELECT f.Titolo, sum(p.incasso) as 'Incasso totale'
FROM Film f, Proiezioni p
Where f.Id=p.CodFilm
and f.Genere='Fantascienza'
GROUP BY f.Titolo

--25- Per ogni film di fantascienza il titolo e l’incasso totale di tutte le sue proiezioni 
-- successive al 1/1/01
SELECT f.Titolo, sum(p.Incasso) as 'Incasso totale'
FROM Film f, Proiezioni p
WHERE f.Id=p.CodFilm
AND f.Genere='Fantascienza'
AND p.DataProiezione>'2001/01/01'
GROUP BY f.Titolo

--26- Per ogni film di fantascienza che non è mai stato proiettato prima del 1/1/01 il titolo e
--l’incasso totale di tutte le sue proiezioni
SELECT f.Titolo, sum(p.Incasso) as 'Incasso Totale'
FROM Film f, Proiezioni p
Where f.Id=p.CodFilm
AND f.Genere='Fantascienza'
GROUP BY f.Titolo
HAVING min(p.DataProiezione)>'2001/01/01'


--27- Per ogni sala di Pisa, che nel mese di gennaio 2005 ha incassato più di 20000 €, il nome della
--sala e l’incasso totale (sempre del mese di gennaio 2005)

SELECT s.Nome, sum(p.Incasso)
FROM Sale s, Proiezioni p
WHERE s.Id=p.CodSala
AND p.DataProiezione>='2005/01/01'
AND p.DataProiezione<'2005/02/01'
AND s.Città='Pisa'
GROUP by s.Nome
HAVING sum(p.Incasso)>20000



--28- I titoli dei film che non sono mai stati proiettati a Pisa
SELECT f.Titolo
FROM Film f
WHERE 'Pisa' NOT IN (SELECT s.Città FROM Proiezioni p, Sale s
						WHERE f.Id=p.CodFilm
						AND p.CodSala=s.Id)

SELECT f.Titolo
FROM Film f
WHERE NOT EXISTS (SELECT *
					FROM Proiezioni p, Sale s
						WHERE f.Id=p.CodFilm
						AND p.CodSala=s.Id
						AND s.Città='Pisa')


--29- I titoli dei film che sono stati proiettati solo a Pisa
SELECT f.id, f.Titolo
FROM Film f
WHERE not exists (SELECT *
					FROM Proiezioni p, Sale s
						WHERE f.Id=p.CodFilm
						AND p.CodSala=s.Id
						AND s.Città<>'Pisa')
and f.Id in (SELECT p1.CodFilm            -- Esclude i film che non hanno proiezioni
			FROM Proiezioni p1)



SELECT f.id,f.Titolo
FROM Film f
WHERE 'Pisa' = All (SELECT s.Città
					FROM Proiezioni p, Sale s
						WHERE f.Id=p.CodFilm
						AND p.CodSala=s.Id)
and f.Id in (SELECT p1.CodFilm		-- Esclude i film che non hanno proiezioni
			FROM Proiezioni p1)


--30- I titoli dei film dei quali non vi è mai stata una proiezione 
-- con incasso superiore a 500 €
SELECT f.Titolo
FROM Film f
WHERE not Exists (SELECT *
				From Proiezioni p1
				Where p1.Incasso>500
				AND p1.CodFilm=f.Id)


--31- I titoli dei film le cui proiezioni hanno sempre ottenuto un incasso 
-- superiore a 500 €
SELECT f.id,f.Titolo
FROM Film f
WHERE f.Id not in(SELECT f1.id
				FROM Film f1, Proiezioni p1
				WHERE f1.Id=p1.CodFilm
				AND p1.Incasso < 500)
AND f.Id in (SELECT p2.CodFilm FROM Proiezioni p2)

SELECT f.id,f.Titolo
FROM Film f
WHERE f.Id not in(SELECT f1.id
				FROM Film f1, Proiezioni p1
				WHERE f1.Id=p1.CodFilm
				AND p1.Incasso < 500)
And Exists (Select * FROM Proiezioni p Where p.CodFilm=f.Id)

--32- Il nome degli attori italiani che non hanno mai recitato in film di Fellini
SELECT a.Nome
FROM Film f, Attori a, Recita r
Where f.Id=r.CodFilm
And r.CodAttore=a.Id
And a.Nazionalità='Italiana'
And a.Nome not in (SELECT a1.Nome FROM Film f1, Attori a1, Recita r1
					WHERE f1.Id=r1.CodFilm
					AND r1.CodAttore=a1.Id
					AND f1.Regista='Fellini')

SELECT a.Nome
FROM Attori a
WHERE a.Nazionalità='Italiana'
AND not Exists ( SELECT * 
				FROM Film f, Recita r
				WHERE f.Id=r.CodFilm
				AND r.CodAttore=a.Id
				AND f.Regista='Fellini')


--33- Il titolo dei film di Fellini in cui non recitano attori italiani
SELECT f.Titolo
FROM Film f
WHERE not Exists (SELECT * 
					FROM Attori a, Recita r
					WHERE a.Id=r.CodAttore
					AND r.CodFilm=f.Id
					AND a.Nazionalità='Italiana')
AND f.Regista='Fellini'


--34- Il titolo dei film senza attori
SELECT f.Titolo
FROM Film f
WHERE f.Id not in (SELECT r.CodFilm FROM Recita r)

SELECT f.Titolo
FROM Film f
WHERE not Exists (SELECT * FROM Recita r WHERE r.CodFilm=f.Id)

--35- Gli attori che prima del 1960 hanno recitato solo nei film di Fellini
SELECT a.Nome
FROM Attori a
WHERE not exists (SELECT * FROM Recita r, Film f
				WHERE f.Regista<>'Fellini'
					AND r.CodAttore=a.Id
					AND f.AnnoProduzione<1960
					AND r.CodFilm=f.Id)
AND a.Id in (Select r.codAttore FROM Recita r)





--36- Gli attori che hanno recitato in film di Fellini solo prima del 1960

SELECT a.Nome
FROM Attori a
WHERE not exists (SELECT * FROM Recita r, Film f
				WHERE f.Regista='Fellini'
					AND r.CodAttore=a.Id
					AND f.AnnoProduzione>=1960
					AND r.CodFilm=f.Id)
AND a.Id in (Select r.codAttore FROM Recita r)