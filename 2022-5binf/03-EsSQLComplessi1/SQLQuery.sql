-- 1- Il nome di tutte le sale di Pisa

SELECT s.Nome
FROM Sale s
WHERE s.Citta='Fossano'

-- 2- Il titolo dei film di F. Fellini prodotti dopo il 1960.

SELECT f.Titolo
FROM Film f
WHERE f.AnnoProduzione>1960
AND f.Regista='Pietro Valsecchi'

-- 3- Il titolo e la durata dei film di fantascienza giapponesi o francesi prodotti dopo il 1990

SELECT f.Titolo
FROM Film f
WHERE f.Genere='Fantascienza'
AND (f.Nazionalita='Giapponese' OR f.Nazionalita='Francese')
AND f.AnnoProduzione>1990

-- 4- Il titolo dei film di fantascienza giapponesi prodotti dopo il 1990 oppure francesi

SELECT f.Titolo
FROM Film f
WHERE f.Genere='Fantascienza'
AND (f.Nazionalita='Giapponese' 
AND f.AnnoProduzione>1990)
OR f.Nazionalita='Francese'