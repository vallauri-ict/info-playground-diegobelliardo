--Query 1 - Visualizza tutti i libri con il loro titolo, autore e categoria.

SELECT Libri.Titolo, Autori.NomeAutore, Categorie.NomeCategoria
FROM Libri
JOIN Autori ON Libri.AutoreID = Autori.IDAutore
JOIN Categorie ON Libri.CategoriaID = Categorie.IDCategoria;

--Query 2 - Trova il nome dell'autore che ha scritto più libri.

SELECT TOP 1 NomeAutore, CognomeAutore
FROM Autori
JOIN Libri ON Autori.IDAutore = Libri.AutoreID
GROUP BY NomeAutore, CognomeAutore
ORDER BY COUNT(Libri.IDLibro) DESC;

--Query 3 - Mostra il titolo e l'autore dei libri non disponibili al momento

SELECT Libri.Titolo, Autori.NomeAutore
FROM Libri
JOIN Autori ON Libri.AutoreID = Autori.IDAutore
WHERE Libri.Disponibilita = 0;	

--Query 4 - Conta il numero di prestiti effettuati da ciascun utente e visualizza il risultato in ordine decrescente.

SELECT IDUtente, COUNT(IDPrestito) AS NumeroPrestiti
FROM Prestiti
GROUP BY IDUtente
ORDER BY NumeroPrestiti DESC;

--Query 5 - Trova la categoria con la più alta percentuale di libri non disponibili 
-- al momento. Mostra il nome della categoria e la percentuale di libri 
-- non disponibili rispetto al totale dei libri in quella categoria.

SELECT Categorie.NomeCategoria,
       SUM(CASE WHEN Libri.Disponibilita = 0 THEN 1 ELSE 0 END) * 100.0 / COUNT(Libri.IDLibro) AS PercentualeNonDisponibili
FROM Categorie
JOIN Libri ON Categorie.IDCategoria = Libri.CategoriaID
GROUP BY Categorie.NomeCategoria
ORDER BY PercentualeNonDisponibili DESC;

SELECT TOP 1 c.NomeCategoria, count(*)*100.0/ (SELECT COUNT(*) FROM Libri l1, Categorie c1 
                                    Where l1.CategoriaID=c1.IDCategoria AND c1.NomeCategoria=c.NomeCategoria) as percentuale
FROM Categorie c, Libri l
Where l.CategoriaID=c.IDCategoria
AND l.Disponibilita=0
GROUP BY c.NomeCategoria
order by percentuale DESC


<<<<<<< HEAD

--Query 6 - Restituisci i primi 5 autori con la media di libri pubblicati 
-- per categoria di libri. Considera solo le categorie con almeno 3 libri.

WITH MediaLibriPerCategoria AS (
    SELECT Categorie.NomeCategoria, AVG(Disponibilita) AS MediaLibri
    FROM Categorie
    JOIN Libri ON Categorie.IDCategoria = Libri.CategoriaID
    GROUP BY Categorie.NomeCategoria
    HAVING COUNT(Libri.IDLibro) >= 3
)
SELECT TOP 5 Autori.NomeAutore, Autori.CognomeAutore, MediaLibriPerCategoria.NomeCategoria, MediaLibri
FROM Autori
JOIN Libri ON Autori.IDAutore = Libri.AutoreID
JOIN Categorie ON Libri.CategoriaID = Categorie.IDCategoria
JOIN MediaLibriPerCategoria ON Categorie.NomeCategoria = MediaLibriPerCategoria.NomeCategoria
ORDER BY MediaLibri DESC;










=======
>>>>>>> 6ea154c (Ripristino situazione da PC)
SELECT  NomeAutore, CognomeAutore, COUNT(Libri.IDLibro)
FROM Autori
JOIN Libri ON Autori.IDAutore = Libri.AutoreID
GROUP BY NomeAutore, CognomeAutore
ORDER BY COUNT(Libri.IDLibro) DESC;

SELECT  NomeAutore, CognomeAutore
FROM Autori a
GROUP BY NomeAutore, CognomeAutore
HAVING MAX(COUNT(*)) >(SELECT Count(*) FROM Libri l WHERE l.AutoreID= a.IDAutore)
