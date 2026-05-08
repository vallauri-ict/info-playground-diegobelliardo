/* 1. Tutti i dati degli alunni di FOSSANO, BRA e MONDOVI */
SELECT *
FROM Alunni
WHERE CittaResidenza = 'Fossano'
OR CittaResidenza = 'Bra'
OR CittaResidenza = 'Mondovì'

/* Meglio */
SELECT *
FROM Alunni
WHERE CittaResidenza IN ('Fossano','Bra','Mondovì')

/* 2. Cognome e nome degli alunni alti tra 180 e 190
   in ordine decrescente di altezza e crescente cognome, 
   nome
   */
SELECT *
FROM Alunni a
WHERE a.Altezza BETWEEN 180 AND 190
ORDER BY a.Altezza, a.Cognome, a.Nome ASC

/* 3. Cognome e nome degli alunni nati nel mese di dicembre */
SELECT *
FROM Alunni a
WHERE MONTH(a.DataNascita) = 12

/* 4.      
Cognome e nome degli alunni che non hanno l’ecdl */

/* 5.      
Tutti i dati degli alunni senza data dinascita */

/* 6. Visualizzare gli alunni che hanno il cognome che inizia per Bo */
SELECT *
FROM Alunni a
WHERE a.Cognome LIKE 'Bo%'


/* 6.a. Visualizzare  l'altezza dell'alunno più alto */
SELECT MAX(a.Altezza) as 'Max'
FROM Alunni a

/* 6.b.  Visualizzare l'altezza dell'alunno più basso */
SELECT MIN(a.Altezza) as 'Min'
FROM Alunni a

/* 6.c.  Visualizzare l'altezza media */
SELECT AVG(a.Altezza) as 'Avg'
FROM Alunni a

/* 6.d.  Visualizzare il numero totale degli alunni */
SELECT count(*)  as 'Num'
FROM Alunni a

/* 7. Per ogni mese visualizzare quanti sono gli alunni */

SELECT MONTH(a.DataNascita) as 'MeseNascita', count(*) as 'Numero'
FROM Alunni a
GROUP BY MONTH(a.DataNascita)

/* 8. Per ogni altezza visualizzare quanti sono gli
alunni */
SELECT a.Altezza, count(*)
FROM Alunni a
GROUP BY a.Altezza

/* 10. Visualizzare i dati dell’alunno più giovane */
SELECT *
FROM Alunni a
WHERE a.DataNascita = (SELECT MAX(DataNascita) FROM Alunni)