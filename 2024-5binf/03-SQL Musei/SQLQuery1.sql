--1- Il codice ed il titolo delle opere di Tiziano conservate alla “National Gallery”.

SELECT o.Id,o.titolo
FROM opere o
WHERE o.nomeA='Tiziano'
AND o.nomeM='National Gallery'

--2- Il nome dell’artista ed il titolo delle opere conservate alla “Galleria degli Uffizi” o alla
--“National Gallery”.

SELECT o.nomeA, o.titolo
FROM opere o
WHERE o.nomeM in ('Galleria degli Uffizi', 'National Gallery')

--3- Il nome dell’artista ed il titolo delle opere conservate nei musei di Firenze



--4- Le città in cui son conservate opere di Caravaggio
--5- Il codice ed il titolo delle opere di Tiziano conservate nei musei di Londra
--6- Il nome dell’artista ed il titolo delle opere di artisti spagnoli conservate nei musei di Firenze
--7- Il codice ed il titolo delle opere di artisti italiani conservate nei musei di Londra, in cui è
--rappresentata la Madonna
--8- Per ciascun museo di Londra, il numero di opere di artisti italiani ivi conservate
--9- Il nome dei musei di Londra che non conservano opere di Tiziano
--10- Il nome dei musei di Londra che conservano solo opere di Tiziano
--11- Per ciascun artista, il nome dell’artista ed il numero di sue opere conservate alla “Galleria
--degli Uffizi”