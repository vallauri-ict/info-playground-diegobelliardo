-- Romanzi pubblicati a partire dal 1990
SELECT *
from Romanzo r
WHERE r.AnnoPubblicazione >= 1990

-- Romanzi del ventesimo secolo
SELECT *
FROM Romanzo r
WHERE r.AnnoPubblicazione >= 1901
AND r.AnnoPubblicazione <= 2000

SELECT *
FROM Romanzo r
WHERE r.AnnoPubblicazione BETWEEN 1901 and 2000

-- Autore (cognome e nome) e titolo di tutti i romanzi, ordinati per 
-- cognome e nome dell'autore
SELECT a.Cognome, a.Nome, r.Titolo
FROM Autore a, Romanzo r
WHERE r.IdAutore=a.Id
ORDER BY a.Cognome, a.Nome

-- Autore (cognome e nome) e titolo di tutti i romanzi russi,
-- ordinati per cognome e nome dell'autore
SELECT a.Cognome, a.Nome, r.Titolo
FROM Autore a, Romanzo r
WHERE r.IdAutore=a.Id
AND a.Nazionalità='Russa'
ORDER BY a.Cognome, a.Nome

-- Titolo dei romanzi di autori nati nel ventesimo secolo
-- ordinati per cognome e nome dell'autore e 
-- data di pubblicazione
SELECT *
FROM Autore a, Romanzo r
WHERE r.IdAutore=a.Id
AND a.DataNascita>='1901/01/01'
AND a.DataNascita<='2000/12/31'

SELECT *
FROM Autore a, Romanzo r
WHERE r.IdAutore=a.Id
AND YEAR(a.DataNascita) >= 1901
AND YEAR(a.DataNascita) <= 2000

--Titolo e anno pubblicazione romanzi di autori viventi
SELECT r.Titolo, r.AnnoPubblicazione
FROM Autore a, Romanzo r
WHERE r.IdAutore=a.Id
AND a.DataMorte is null

-- Romanzi di scrittori viventi, oppure morti ma non a Torino
SELECT r.Titolo, r.AnnoPubblicazione
FROM Autore a, Romanzo r
WHERE r.IdAutore=a.Id
AND (a.DataMorte is null
OR a.LuogoMorte <> 'Torino')

-- Romanzi con la parola sposi nel titolo
SELECT r.Titolo
FROM Romanzo r
WHERE r.Titolo like '%sposi%'

-- Case sensitive insensitive
SELECT SERVERPROPERTY('COLLATION')

SELECT name, description FROM sys.fn_helpcollations()
WHERE name like '%Lati%'

ALTER TABLE Romanzo
ALTER COLUMN Titolo VARCHAR(50)
COLLATE Latin1_General_CS_AS

-- Romanzi pubblicati prima del 1990 
-- con la parola sposi nel titolo 
-- scritta con l'iniziale maiuscola o minuscola
SELECT r.Titolo
FROM Romanzo r
WHERE (r.Titolo like '%sposi%'
OR r.Titolo like '%Sposi%')
AND r.AnnoPubblicazione < 1990

-- Titolo dei romanzi di Don Delillo escludendo i duplicati
SELECT distinct r.Titolo
FROM Autore a, Romanzo r
WHERE r.IdAutore=a.Id
AND a.Cognome='Delillo'
and a.Nome='Don'

-- Romanzi con il personaggio Benjamin
SELECT r.Titolo, p.*
FROM Personaggio p, PersonaggioRomanzo pr,
	Romanzo r
WHERE p.Id=pr.IdPersonaggio
AND pr.IdRomanzo=r.Id
AND p.Nome='Benjamin'
AND p.Cognome='Malaussène'