/*  Trovare le città da cui partono voli diretti a Roma, ordinate alfabeticamente- 
*/

SELECT v.cittaPartenza
FROM volo v
WHERE v.cittaArrivo='Roma'
ORDER BY v.cittaPartenza 

/* Trovare le città con un aeroporto di cui non è noto il numero di piste */

SELECT citta
FROM aeroporto
WHERE numpiste is null

/* Di ogni volo misto (merci e passeggeri) estrarre il codice e 
 i dati relativi al trasporto */

 SELECT *
 FROM volo 
 WHERE 