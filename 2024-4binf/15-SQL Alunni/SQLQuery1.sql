--1. Tutti i dati degli alunni che hanno l'ecdl
SELECT *
FROM alunni a
WHERE a.ecdl = 1;

-- 2. Cognome e nome degli alunni alti tra 180 e 190 in ordine decrescente 
-- di altezza e crescente cognome, nome
SELECT a.altezza, a.cognome, a.nome
FROM alunni a
WHERE a.altezza>=180
AND a.altezza<=190
ORDER BY a.altezza DESC, a.cognome, a.nome

--oppure
SELECT a.altezza, a.cognome, a.nome
FROM alunni a
WHERE a.altezza BETWEEN 180 AND 190
ORDER BY a.altezza DESC, a.cognome, a.nome


-- 3. Cognome e nome degli alunni nati nel mese di dicembre
SELECT a.cognome, a.nome
FROM alunni a
WHERE MONTH(a.dataNascita) = 12.

-- 4. Cognome e nome degli alunni che non hanno l’ecdl
SELECT a.cognome, a.nome
FROM alunni a
WHERE a.ecdl = 0;

SELECT *
FROM alunni a
WHERE a.dataNascita IS NULL

-- 6.Visualizzare gli alunni che hanno il cognome che inizia per MA

SELECT *
FROM alunni a
WHERE a.cognome LIKE 'Ma%'

-- 7.Per ogni mese visualizzare quanti sono gli alunni
SELECT MONTH(a.dataNascita) AS MESE_NASCITA,count(*) AS NUM_NATI
FROM alunni a
WHERE a.dataNascita is not null
GROUP BY MONTH(a.dataNascita)

--8.      
--Per ogni altezza visualizzare quanti sono gli
--alunni escludendo le altezze con un solo alunnno
SELECT a.altezza, count(*) AS N_Alunni
FROM alunni a
GROUP BY a.altezza
HAVING count(*) > 1


--9.      
--Visualizzare idAlunno, cognome, nome e
--‘maggiorenne’ se ha già compiuto 18 anni, ‘quasi maggiorenne’ se nell’anno in
--corso compie 18 anni, ‘minorenne’ negli altri casi
SELECT a.Id, a.cognome, a.nome, a.dataNascita , CASE
    WHEN DATEDIFF(year, a.dataNascita, GETDATE()) > 18 THEN 'maggiorenne'
    WHEN DATEDIFF(year, a.dataNascita, GETDATE()) = 18 THEN 'quasi maggiorenne'
    ELSE 'minorenne'
    END
FROM alunni a

SELECT a.Id, a.cognome, a.nome, a.dataNascita , CASE
    WHEN DATEADD(year, 18, a.dataNascita) < GETDATE() THEN 'maggiorenne'
    WHEN Year(a.dataNascita)+18 = Year(GETDATE()) THEN 'quasi maggiorenne'
    --WHEN DATEADD(year, 18, a.dataNascita) > GETDATE() 
    --AND DATEDIFF(year, a.dataNascita, GETDATE()) = 18 THEN 'quasi maggiorenne'
    ELSE 'minorenne'
    END
FROM alunni a


--10.  
--Visualizzare i dati dell’alunno più giovane

SELECT *
FROM alunni a
WHERE a.dataNascita = (SELECT MAX(a1.dataNascita) FROM alunni a1)