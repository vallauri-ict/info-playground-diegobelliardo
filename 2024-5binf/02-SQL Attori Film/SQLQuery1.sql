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

