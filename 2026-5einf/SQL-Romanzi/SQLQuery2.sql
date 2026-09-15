SELECT Nome, Cognome, Titolo
FROM Autore a, Romanzo r
WHERE a.Id = r.Autore
ORDER BY Cognome, Nome

SELECT Nome, Cognome, Titolo, AnnoPubblicazione
FROM Autore a, Romanzo r
WHERE a.Id = r.Autore and YEAR(a.DataNascita) BETWEEN 1900 AND 2000
ORDER BY Cognome, Nome, AnnoPubblicazione

SELECT Titolo
FROM Romanzo r
WHERE r.Autore = (SELECT Autore.Id
FROM Autore
WHERE Id = r.Autore AND)