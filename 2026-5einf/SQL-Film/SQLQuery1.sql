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