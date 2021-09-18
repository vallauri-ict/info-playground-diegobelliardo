/* 1 Selezionare il nome e l'età e il salario 
degli impieati con più di 50 anni */
SELECT nome,eta,salario
FROM Impiegato
WHERE eta>50;

/* 2 Le informazioni degli acquisti di item=2 */
SELECT * 
FROM Acquisto
WHERE item=2;

/* 3 nome, titolo e salario dei programmatori 
con salario > 1400 */
SELECT nome,titolo,salario
FROM Impiegato
WHERE salario>1400
AND titolo='Programmatore'

/* 4 nome di tutti i Progrmmatori e analisti */
SELECT nome
FROM Impiegato
WHERE titolo='Programmatore'
OR titolo='Analista'

/* Le diverse età degli impiegati */
select distinct eta
from Impiegato

/* Stipendio medio dei impiegati */
select AVG(salario)
from Impiegato

/* tutti i dati di impiegato ordinati per salario dal maggiore al minore*/
SELECT *
FROM Impiegato
ORDER BY salario DESC

/* tutti i dati di impiegato ordinati per salario e per età dal maggiore al minore*/
SELECT *
FROM Impiegato
ORDER BY salario desc, eta DESC

/* tutti i dati degli impiegati: Marta, Fabio e Ivan */
SELECT *
FROM Impiegato
WHERE nome IN ('Marta','Fabio','Ivan')  /*OPPURE utilizzo OR */

/* tutti i dati degli impiegati tranne: Marta, Fabio e Ivan */
SELECT *
FROM Impiegato
WHERE nome NOT IN ('Marta','Fabio','Ivan')

/* tutti i dati degli impiegati con età compresa tra 20 e 30*/
SELECT *
FROM Impiegato
WHERE eta BETWEEN 20 AND 30  /*OPPURE eta >= 20 and eta <= 30 */

/* per ogni acquisto il nome del cliente e il prezzo del prodotto */
SELECT c.nome,a.prezzo
FROM Acquisto a, Cliente c
where a.idCliente = c.IdCliente


