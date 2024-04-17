SELECT *
FROM Auto a
Where a.targa = 'AA001AA'


SELECT *
FROM Auto a
Where a.targa LIKE '_B%'

SELECT *
FROM Auto a
Where a.prezzo BETWEEN 10000 and 14500

SELECT *
FROM Auto a
WHERE colore IN ('rosso','grigio')