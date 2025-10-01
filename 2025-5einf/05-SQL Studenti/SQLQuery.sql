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