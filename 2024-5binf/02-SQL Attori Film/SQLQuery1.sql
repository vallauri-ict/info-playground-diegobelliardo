/* 1- Il nome di tutte le sale di Pisa  */

SELECT nome
FROM sale
WHERE citta='Pisa'

/* 2- Il titolo dei film di F. Fellini 
prodotti dopo il 1960. */

SELECT f.titolo
FROM Film f
WHERE f.regista='Fellini'
and f.annoProduzione>1960

/* 3- Il titolo e la durata dei film di fantascienza 
  giapponesi o francesi prodotti dopo il 1990 */

  SELECT film.titolo
  FROM film
  WHERE (nazionalita='Francese'
  OR (genere='Fantascienza'
  AND nazionalita='Giapponese'))
  AND annoProduzione>1990

  /* 4- Il titolo dei film di fantascienza giapponesi
    prodotti dopo il 1990 oppure francesi */

SELECT titolo
FROM film
WHERE (genere='Fantascienza'
AND nazionalita='Giapponese'
AND annoProduzione>1990)
OR (nazionalita='Francese')

/* 5- I titolo dei film dello stesso regista di “Casablanca” */
SELECT f1.titolo
FROM film f1
WHERE f1.regista = (SELECT f2.regista 
                    FROM film f2 
                    WHERE f2.titolo = 'Casablanca')

/* 6- Il titolo ed il genere dei film proiettati il giorno di 
    Natale 2004 */
SELECT f.titolo,f.genere
FROM film f 
JOIN proiezioni p ON f.codFilm = p.codFilm
WHERE p.dataProiezioni='2004-12-25'

SELECT f.titolo,f.genere
FROM film f, proiezioni p 
WHERE p.dataProiezioni='2004-12-25'
AND f.codFilm = p.codFilm

/* 7- Il titolo ed il genere dei film proiettati a 
Napoli il giorno di Natale 2004 */

SELECT film.titolo,film.genere
FROM proiezioni JOIN film ON proiezioni.codFilm = film.codFilm 
    JOIN sale ON proiezioni.codSala=sale.codSala
WHERE sale.citta='Napoli'
AND proiezioni.dataProiezioni = '2004/12/25'

/* 20- Per ogni regista e per ogni attore, il numero di film del regista 
con l’attore */
select f.regista,a.nome, COUNT(*) AS Numero_Film
FROM film f, attori a, recita r
WHERE f.codFilm=r.codFilm
AND r.codAttore=a.codAttore
GROUP BY f.regista,a.codAttore,a.nome

/* 21 - Il regista ed il titolo dei film in cui recitano 
meno di 6 attori */
SELECT f.regista, f.titolo
FROM Film f, recita r
WHERE f.codFilm=r.codFilm
GROUP BY f.titolo, f.regista
HAVING count(*)<6

/* SECONDA SOLUZIONE */
SELECT f.regista, f.titolo
FROM Film f
WHERE 6>(SELECT count(*)
         FROM recita r
         where r.codFilm=f.codFilm)

/* 22- Per ogni film prodotto dopo il 2000, il codice, il titolo e 
l’incasso totale di tutte le sue proiezioni */
SELECT f.codFilm,f.titolo,SUM(p.incasso) AS Incasso_Totale
FROM film f, proiezioni p
WHERE f.codFilm=p.codFilm
AND f.annoProduzione>2000
GROUP BY f.codFilm, f.titolo

/* 23 - Il numero di attori dei film in cui appaiono solo attori 
nati prima del 1970 */
SELECT f.titolo,count(*) AS Numero_Attori
FROM film f, attori a, recita r
WHERE f.codFilm=r.codFilm
AND r.codAttore=a.codAttore
GROUP BY f.titolo
HAVING MAX(a.annoNascita)<1970

/* 24- Per ogni film di fantascienza, il titolo e l’incasso totale 
di tutte le sue proiezioni */

SELECT f.titolo, SUM(p.incasso) AS Incasso_totale
FROM film f, proiezioni p
WHERE f.codFilm=p.codFilm
AND f.genere='Fantascienza'
GROUP BY f.titolo

/* 25- Per ogni film di fantascienza il titolo e l’incasso totale 
di tutte le sue proiezioni successive al 1/1/01 */
SELECT f.titolo, SUM(p.incasso) AS Incasso_totale
FROM film f, proiezioni p
WHERE f.codFilm=p.codFilm
AND p.dataProiezioni>'2001/01/01'
AND f.genere='Fantascienza'
GROUP BY f.titolo

/* 26- Per ogni film di fantascienza che non è mai stato proiettato 
prima del 1/1/01 il titolo e l’incasso totale di tutte le sue proiezioni */
SELECT f.titolo, SUM(p.incasso) AS Incasso_totale
FROM film f, proiezioni p
WHERE f.codFilm=p.codFilm
AND f.genere='Fantascienza'
GROUP BY f.titolo
HAVING min(p.dataProiezioni)>='2001/01/01'

/* 27- Per ogni sala di Pisa, che nel mese di gennaio 2005 ha incassato 
più di 20000 €, il nome della sala e l’incasso totale 
(sempre del mese di gennaio 2005) */
SELECT s.nome, SUM(p.incasso) as Incasso_totale
FROM sale s, proiezioni p
WHERE s.codSala=p.codSala
AND s.citta='Pisa'
AND p.dataProiezioni BETWEEN '2005/01/01' AND '2005/01/31'
GROUP BY s.codSala, s.nome
HAVING SUM(p.incasso)>200

/* 28- I titoli dei film che non sono mai stati proiettati a Pisa */
SELECT *
FROM film f
WHERE NOT EXISTS (SELECT *
                  FROM proiezioni p, sale s
                  WHERE p.codSala=s.codSala
                  AND f.codFilm=p.codFilm
                  AND s.citta='Pisa')

/* OPPURE */
SELECT *
FROM film f
WHERE 'Pisa' NOT IN (SELECT s.citta
                     FROM proiezioni p,sale s
                     WHERE p.codSala=s.codSala
                     AND p.codFilm=f.codFilm)


/* 29- I titoli dei film che sono stati proiettati solo a Pisa */
SELECT f.titolo
FROM film f
WHERE NOT EXISTS (SELECT *
                  FROM proiezioni p, sale s
                  WHERE p.codSala=s.codSala
                  AND f.codFilm=p.codFilm
                  AND s.citta<>'Pisa')

SELECT f.titolo
FROM film f
WHERE 'Pisa' = ALL (SELECT s.citta
                     FROM proiezioni p,sale s
                     WHERE p.codSala=s.codSala
                     AND p.codFilm=f.codFilm)


/* 30- I titoli dei film dei quali non vi è mai stata una proiezione 
con incasso superiore a 500 € */
SELECT *
FROM Film f
WHERE NOT EXISTS (SELECT *
                  FROM proiezioni p
                  WHERE f.codFilm=p.codFilm
                  AND p.Incasso>500)

SELECT *
FROM Film f
WHERE 500 >= ALL (SELECT p.Incasso
                    FROM proiezioni p
                    WHERE p.codFilm=f.codFilm)

SELECT f.titolo
FROM Film f, proiezioni p
WHERE f.codFilm=p.codFilm
GROUP BY f.titolo
HAVING MAX(p.incasso)<500

/* 31- I titoli dei film le cui proiezioni hanno sempre ottenuto un 
incasso superiore a 500 € */
SELECT *
FROM Film f
WHERE NOT EXISTS (SELECT *
                  FROM proiezioni p
                  WHERE f.codFilm=p.codFilm
                  AND p.Incasso<=500)

SELECT f.titolo
FROM Film f, proiezioni p
WHERE f.codFilm=p.codFilm
GROUP BY f.titolo
HAVING MIN(p.incasso)>500

/* 32- Il nome degli attori italiani che non hanno mai recitato in 
film di Fellini */
SELECT *
FROM attori a
WHERE a.nazionalita='Italiana'
and NOT EXISTS (SELECT *
                FROM film f, recita r
                WHERE f.codFilm=r.codFilm
                AND r.codAttore=a.codAttore
                AND f.regista='Fellini')