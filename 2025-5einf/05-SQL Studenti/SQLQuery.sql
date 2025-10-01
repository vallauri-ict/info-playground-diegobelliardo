-- 1)

SELECT *
FROM Studenti s
WHERE s.CorsoLaurea='SBC'
ORDER BY s.NomeS;

-- 2)
SELECT d.NomeD, d.Dipartimento
FROM Docenti d, Corsi c
WHERE c.CodDocente=d.CodDocente
AND c.NomeCorso IN ('Basi di Dati','Informatica generale')

-- 3)
SELECT s.Matricola, s.NomeS
FROM Studenti s, CorsiDiLaurea cl, Corsi c, Docenti d, Frequenta f
WHERE s.CorsoLaurea=cl.CorsoLaurea
AND f.Matricola=s.Matricola
AND f.CodCorso=c.CodCorso
AND c.CodDocente=d.CodDocente
AND cl.TipoLaurea='L'
AND d.NomeD like '%Felice%'

--4)
SELECT cl.TipoLaurea, AVG(s.AnnoN)
FROM Studenti s, CorsiDiLaurea cl
WHERE s.CorsoLaurea=cl.CorsoLaurea
GROUP BY cl.TipoLaurea

-- 5)
SELECT c.CodCorso, Count(*) AS NumeroStudenti
FROM Docenti d, Corsi c, Frequenta f
WHERE d.CodDocente=c.CodDocente
AND f.CodCorso=c.CodCorso
AND d.NomeD='Leoni'
GROUP BY c.CodCorso

-- 6)

SELECT c.CodCorso, count(*) AS NUMERO_STUDENTI
FROM Docenti d, Corsi c, Frequenta f
WHERE f.CodCorso=c.CodCorso
AND d.CodDocente=c.CodDocente
AND d.Dipartimento='Informatica'
GROUP BY c.CodCorso
HAVING COUNT(*)>5

-- 11)

SELECT *
FROM Corsi c
WHERE NOT EXISTS (SELECT *
					FROM Frequenta f, Studenti s
					WHERE s.CorsoLaurea <> 'SBC'
					AND f.Matricola=s.Matricola
					AND f.CodCorso=c.CodCorso)

-- 12)
SELECT d.CodDocente, d.NomeD, count(*) AS Numero_studenti
FROM Docenti d, Corsi c, Frequenta f
WHERE d.CodDocente=c.CodDocente
AND f.CodCorso=c.CodCorso
GROUP BY d.CodDocente, d.NomeD
HAVING count(*)>5

-- OPPURE
SELECT d.CodDocente, d.NomeD
FROM Docenti d, Corsi c
WHERE d.CodDocente=c.CodDocente
AND 5 < (SELECT count(*)
		FROM Frequenta f
		WHERE f.CodCorso=c.CodCorso)

-- 13 )
SELECT *
FROM Corsi c
WHERE NOT EXISTS (SELECT *
					FROM Studenti s
					WHERE s.CorsoLaurea='SBC'
					AND Not EXISTS (SELECT *
									FROM Frequenta f
									WHERE f.CodCorso=c.CodCorso
									AND f.Matricola=s.Matricola))

SELECT *
FROM Studenti s
WHERE s.CorsoLaurea='SBC'

SELECT *
FROM Frequenta f
WHERE f.Matricola IN (1001,1002,1003,1004,1005,1006)

