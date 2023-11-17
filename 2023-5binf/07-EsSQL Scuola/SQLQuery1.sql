--1- Il nome e l’anno di nascita degli studenti iscritti a SFC, in ordine rispetto al nome
SELECT s.NomeS,s.AnnoN
FROM STUDENTI s,CORSODILAUREA c
WHERE s.CorsoLaurea=c.CorsoLaurea AND c.Facolta='SFC'
ORDER BY s.NomeS

--2- Il nome ed il Dipartimento dei docenti di “Basi di Dati e Sistemi Informativi” o di “Informatica Generale”
SELECT d.NomeD,d.Dipartimento
FROM DOCENTI d
WHERE d.Dipartimento IN ('Basi di Dati e Sistemi Informativi','Informatica Generale')

--non completata
--3- Matricola e nome degli studenti di un corso di laurea triennale 
--(tipoLaurea = 'L') che seguono un corso di un docente di nome Felice.
SELECT *
FROM STUDENTI s, DOCENTI d, CORSODILAUREA cl, CORSI c, FREQUENTA f
WHERE cl.TipoLaurea='L'
AND s.CorsoLaurea=cl.CorsoLaurea
AND d.NomeD='Felice'
AND c.CodDocente=d.CodDocente
AND f.Matricola=s.Matricola
AND f.CodCorso=c.CodCorso


--4- Per ogni tipo di laurea, il tipoLaurea e l’età media degli studenti
SELECT c.CorsoLaurea, AVG(s.AnnoN) as Media_anni
FROM CORSODILAUREA c, STUDENTI s
WHERE c.CorsoLaurea=s.CorsoLaurea
GROUP BY c.CorsoLaurea

--5- Di ogni corso di un docente di nome Leoni, il CodCorso e il numero degli studenti che lo frequentano
SELECT c.CodCorso, COUNT(*) as numero_studenti
FROM CORSI c
INNER JOIN FREQUENTA f ON f.CodCorso=c.CodCorso
INNER JOIN DOCENTI d ON c.CodDocente=d.CodDocente
WHERE d.NomeD='Leoni'
GROUP BY c.CodCorso

--6- Il codice dei corsi frequentati da più di 5 studenti e tenuti da docenti del Dipartimento di Informatica
SELECT c.CodCorso
FROM CORSI c
INNER JOIN FREQUENTA f ON f.CodCorso=c.CodCorso
INNER JOIN DOCENTI d ON c.CodDocente=d.CodDocente
WHERE d.Dipartimento='Informatica Generale'
GROUP BY c.CodCorso
HAVING COUNT(*) > 1

--7- Per ogni studente della Facoltà di Lettere e Filisofia, la matricola ed il numero di corsi seguiti
SELECT s.Matricola, COUNT(*) as numero_corsi
FROM Studenti s, CORSODILAUREA c
WHERE s.CorsoLaurea= c.CorsoLaurea AND c.Facolta='Lettere e filosofia'
GROUP BY s.Matricola

--8- Matricola e nome degli studenti che non frequentano nessun corso
SELECT s.Matricola, s.NomeS
FROM STUDENTI s
WHERE s.Matricola NOT IN (SELECT f.Matricola FROM FREQUENTA f)

--9- Il Codice ed il Nome dei docenti dei Corsi che non sono frequentati da nessuno studente
SELECT d.CodDocente, d.NomeD
FROM DOCENTI d
INNER JOIN CORSI c ON c.CodDocente=d.CodDocente
WHERE c.CodCorso NOT IN(SELECT f.CodCorso FROM FREQUENTA f)

--non completata
--10- Matricola e nome degli studenti che seguono solo corsi di docenti 
-- del dipartimento di Storia

-- Se lo studente non frequenta corsi viene restituito
SELECT s.Matricola, s.NomeS
FROM STUDENTI s
WHERE NOT EXISTS (SELECT *
					FROM DOCENTI d, FREQUENTA f, CORSI c
					WHERE d.Dipartimento<>'Storia'
					AND f.CodCorso=c.CodCorso
					AND f.Matricola=s.Matricola
					AND d.CodDocente=c.CodDocente)


-- Se lo studente non frequenta corsi NON viene restituito
SELECT s.Matricola, s.NomeS
FROM Studenti s,Frequenta f, Corsi c, Docenti d
WHERE s.Matricola=f.Matricola AND f.CodCorso=c.CodCorso AND c.CodDocente=d.CodDocente
AND d.Dipartimento='Storia'
AND c.CodCorso = ALL (SELECT f.CodCorso FROM Frequenta f WHERE f.Matricola=s.Matricola)


--11- Il CodCorso dei corsi seguiti solo da studenti che appartengono
-- al Corso di Laurea Triennale in SBC

SELECT c.CodCorso
FROM Corsi c, Studenti s, Frequenta f
WHERE c.CodCorso=f.CodCorso 
AND f.Matricola=s.Matricola
AND s.CorsoLaurea='SBC'
AND s.Matricola = ALL(SELECT f1.Matricola FROM  Frequenta f1 WHERE f1.CodCorso=c.CodCorso)


--12- Nome e CodDocente dei docenti che insegnano qualche corso seguito 
-- da più di 5 studenti

SELECT d.NomeD, d.CodDocente
FROM Docenti d, Frequenta f, Corsi c
WHERE d.CodDocente=c.CodDocente AND c.CodCorso=f.CodCorso
GROUP BY d.NomeD,d.CodDocente,c.CodCorso
HAVING COUNT(f.Matricola)>=5

--13- Codice dei corsi che sono frequentati da tutti gli studenti del 
-- CorsoLaurea SBC

SELECT DISTINCT f.CodCorso
FROM  Studenti s, Frequenta f
WHERE f.Matricola = s.Matricola
AND s.CorsoLaurea='SBC'
AND f.CodCorso IN (SELECT f1.CodCorso FROM Frequenta f1 WHERE f1.Matricola=s.Matricola)
