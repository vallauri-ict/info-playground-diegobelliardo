-- 5- I titolo dei film dello stesso regista di “Casablanca”
SELECT *
FROM Film f
WHERE f.Regista = (SELECT f1.Regista
					FROM Film f1
					WHERE f1.Titolo='Casablanca')
AND f.Titolo <> 'Casablanca'

-- 10- Il titolo dei film in cui recitano M. Mastroianni e S.Loren
SELECT f.Titolo
FROM Film f
WHERE 'Marcello Mastroianni' IN (SELECT a.Nome
								FROM Attori a, Recita r
								WHERE a.CodAttore=r.CodAttore
								AND f.CodFilm=r.CodFilm)
AND 'Sophia Loren' IN (SELECT a.Nome
								FROM Attori a, Recita r
								WHERE a.CodAttore=r.CodAttore
								AND f.CodFilm=r.CodFilm)

-- 16- Per ogni città, il numero di sale con più di 60 posti
SELECT s.Citta, count(*)
FROM Sale s
WHERE s.Posti > 60
GROUP BY S.Citta

-- 19- Per ogni film di S.Spielberg, il titolo del film, 
-- il numero totale di proiezioni a Pisa e l’incasso totale
SELECT f.Titolo, count(*) AS NumProiezioni, SUM(p.Incasso) AS IcassoTotale
FROM Film f, Proiezioni p, Sale s
WHERE f.CodFilm=p.CodFilm
AND s.CodSala=p.CodSala
AND f.Regista='S. Spielberg'
AND s.Citta='Pisa'
GROUP BY f.CodFilm, f.Titolo

-- 20- Per ogni regista e per ogni attore, il numero di film del 
-- regista con l’attore
SELECT f.Regista, a.Nome, count(*) as NumeroFilm
FROM Film f, Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
GROUP BY f.Regista, a.CodAttore, a.Nome

-- 21 - Il regista ed il titolo dei film in cui recitano meno 
-- di 6 attori
-- Non restituisce i film senza attori!!!
SELECT f.Titolo, f.Regista
FROM Film f,Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
GROUP BY f.CodFilm, f.Titolo, f.Regista
HAVING count(*)<6

-- OPPURE
SELECT f.Titolo, f.Regista
FROM Film f
WHERE 6>(SELECT count(*)
		FROM Recita r
		WHERE r.CodFilm=f.CodFilm)


-- 22- Per ogni film prodotto dopo il 2000, il codice, il titolo
-- e l’incasso totale di tutte le sue proiezioni
SELECT f.CodFilm, f.Titolo, SUM(p.Incasso) AS IncassoTotale
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
AND f.AnnoProduzione>1900
GROUP BY f.CodFilm, f.Titolo

-- Per estrarre anche i film senza proiezioni
SELECT f.CodFilm, f.Titolo, SUM(p.Incasso) AS IncassoTotale
FROM Film f LEFT JOIN Proiezioni p ON f.CodFilm=p.CodFilm
WHERE f.AnnoProduzione>1900
GROUP BY f.CodFilm, f.Titolo

-- 23 - Il numero di attori dei film in cui appaiono solo attori 
-- nati prima del 1970
SELECT f.CodFilm, f.Titolo, count(*) as NumeroAttori
FROM Film f, Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
GROUP BY f.CodFilm, f.Titolo
HAVING max(a.AnnoNasciata) < 1970

-- VERIFICA:
SELECT f.Titolo, a.Nome, a.AnnoNasciata
FROM Film f,Recita r, Attori a
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
AND f.CodFilm=1

-- 24- Per ogni film di fantascienza, il titolo e l’incasso 
-- totale di tutte le sue proiezioni
SELECT f.Titolo, SUM(p.Incasso) as IncassoTotale
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
AND f.Genere='Fantascienza'
GROUP BY f.CodFilm, f.Titolo

-- 25- Per ogni film di fantascienza il titolo e l’incasso totale 
-- di tutte le sue proiezioni successive al 1/1/01
SELECT f.Titolo, SUM(p.Incasso) as IncassoTotale
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
AND f.Genere='Fantascienza'
AND p.DataProiezione > '2001-01-01'
GROUP BY f.CodFilm, f.Titolo

-- 26- Per ogni film di fantascienza che non è mai stato 
-- proiettato prima del 1/1/01 il titolo e l’incasso totale 
-- di tutte le sue proiezioni
SELECT f.Titolo, SUM(p.Incasso) as IncassoTotale
FROM Film f, Proiezioni p
WHERE f.CodFilm=p.CodFilm
AND f.Genere='Fantascienza'
GROUP BY f.CodFilm, f.Titolo
HAVING min(p.DataProiezione)>'2001-01-01'

-- 27- Per ogni sala di Pisa, che nel mese di gennaio 2005 ha 
-- incassato più di 20000 €, il nome della sala e 
-- l’incasso totale (sempre del mese di gennaio 2005)
SELECT s.Nome, sum(p.Incasso) as IncassoTotale
FROM Sale s, Proiezioni p
WHERE p.CodSala=s.CodSala
AND p.DataProiezione BETWEEN '2005-01-01' AND '2005-01-31'
AND s.Citta='Pisa'
GROUP BY s.CodSala, s.Nome
HAVING sum(p.Incasso) > 2000

-- OPPURE
SELECT s.Nome, sum(p.Incasso) as IncassoTotale
FROM Sale s, Proiezioni p
WHERE p.CodSala=s.CodSala
AND MONTH(p.DataProiezione) = 1
AND YEAR(p.DataProiezione) = 2005
--AND p.DataProiezione BETWEEN '2005-01-01' AND '2005-01-31'
AND s.Citta='Pisa'
GROUP BY s.CodSala, s.Nome
HAVING sum(p.Incasso) > 2000

-- 28- I titoli dei film che non sono mai stati proiettati a Pisa
SELECT *
FROM Film f
WHERE NOT EXISTS (SELECT *
				FROM Proiezioni p, Sale s
				WHERE p.CodSala=s.CodSala
				AND p.CodFilm=f.CodFilm
				AND s.Citta='Pisa')

-- OPPURE
SELECT *
FROM Film f
WHERE 'Pisa' NOT IN (SELECT s.Citta
				FROM Proiezioni p, Sale s
				WHERE p.CodSala=s.CodSala
				AND p.CodFilm=f.CodFilm)

-- 29- I titoli dei film che sono stati proiettati solo a Pisa
SELECT *
FROM Film f
WHERE not exists (SELECT * 
				FROM Proiezioni p, Sale s
				WHERE p.CodFilm=f.CodFilm
				AND p.CodSala=s.CodSala
				AND s.Citta <> 'Pisa')
-- Se il film non ha proiezioni viene restituito lo stesso
-- Non è il massimo!

-- OPPURE 
-- IDEM COME SOPRA!
-- Se il film non ha proiezioni viene restituito lo stesso
-- Non è il massimo!
SELECT *
FROM Film f
WHERE 'Pisa' = ALL (SELECT s.Citta
					FROM Sale s, Proiezioni p
					WHERE s.CodSala= p.CodSala
					AND p.CodFilm=f.CodFilm)

-- !!! SOLUZIONE MIGLIORATA !!!
SELECT *
FROM Film f
WHERE not exists (SELECT * 
				FROM Proiezioni p, Sale s
				WHERE p.CodFilm=f.CodFilm
				AND p.CodSala=s.CodSala
				AND s.Citta <> 'Pisa')
AND EXISTS (SELECT * 
				FROM Proiezioni p, Sale s
				WHERE p.CodFilm=f.CodFilm
				AND p.CodSala=s.CodSala)
					
-- 30- I titoli dei film dei quali non vi è mai stata una proiezione con incasso superiore a 500 €31- I titoli dei film le cui proiezioni hanno sempre ottenuto un incasso superiore a 500 €
-- 32- Il nome degli attori italiani che non hanno mai recitato in film di Fellini
-- 33- Il titolo dei film di Fellini in cui non recitano attori italiani
-- 34- Il titolo dei film senza attori
-- 35- Gli attori che prima del 1960 hanno recitato solo nei film di Fellini
-- 36- Gli attori che hanno recitato in film di Fellini solo prima del 1960