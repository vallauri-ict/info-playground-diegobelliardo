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

SELECT  NomeAutore, CognomeAutore, COUNT(Libri.IDLibro)
FROM Autori
JOIN Libri ON Autori.IDAutore = Libri.AutoreID
GROUP BY NomeAutore, CognomeAutore
ORDER BY COUNT(Libri.IDLibro) DESC;

SELECT  NomeAutore, CognomeAutore
FROM Autori a
GROUP BY NomeAutore, CognomeAutore
HAVING MAX(COUNT(*)) >(SELECT Count(*) FROM Libri l WHERE l.AutoreID= a.IDAutore)
