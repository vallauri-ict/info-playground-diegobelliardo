-- 4

SELECT Nome, Cognome, Titolo
FROM Autore a, Romanzo r
WHERE a.Id = r.Autore
ORDER BY Cognome, Nome

-- 7
SELECT Nome, Cognome, Titolo, AnnoPubblicazione
FROM Autore a, Romanzo r
WHERE a.Id = r.Autore and YEAR(a.DataNascita) BETWEEN 1900 AND 2000
ORDER BY Cognome, Nome, AnnoPubblicazione

-- 9
SELECT Titolo
FROM Romanzo r, Autore a
WHERE r.Autore = a.Id AND (a.DataMorte IS NULL OR (a.LuogoMorte != 'Torino' AND a.LuogoMorte IS NOT NULL))

-- 12
SELECT Titolo
FROM Romanzo
WHERE Titolo LIKE '%sposi%'

-- 13
SELECT Titolo
FROM Romanzo 
WHERE Titolo LIKE '%i'

-- 18
SELECT DISTINCT Titolo
FROM Romanzo, Autore
WHERE Romanzo.Autore = Autore.Id AND Autore.Nome = 'Luigi' AND Autore.Cognome = 'Pirandello'
-- 18b
SELECT Titolo
FROM Romanzo, Autore
WHERE Romanzo.Autore = Autore.Id AND Autore.Nome = 'Luigi' AND Autore.Cognome = 'Pirandello'
GROUP BY Titolo

-- 19
SELECT Titolo t
FROM Romanzo, Personaggio, PersonaggioRomanzo
WHERE Romanzo.Id = PersonaggioRomanzo.Romanzo 
AND Personaggio.Id = PersonaggioRomanzo.Personaggio 
AND Personaggio.Nome = 'Renzo' 
AND Personaggio.Cognome = 'Tramaglino'