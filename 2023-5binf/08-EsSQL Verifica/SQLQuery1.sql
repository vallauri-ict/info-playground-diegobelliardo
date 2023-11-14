SELECT Categorie.NomeCategoria,
       SUM(CASE WHEN Libri.Disponibilita = 0 THEN 1 ELSE 0 END) * 100.0 / COUNT(Libri.IDLibro) AS PercentualeNonDisponibili
FROM Categorie
JOIN Libri ON Categorie.IDCategoria = Libri.CategoriaID
GROUP BY Categorie.NomeCategoria
ORDER BY PercentualeNonDisponibili DESC;


SELECT c.NomeCategoria, count(*)/(SELECT COUNT(*) FROM Libri l1, Categorie c1 
                                    Where l1.CategoriaID=c1.IDCategoria AND c1.NomeCategoria=c.NomeCategoria)
FROM Categorie c, Libri l
Where l.CategoriaID=c.IDCategoria
AND l.Disponibilita=0
GROUP BY c.NomeCategoria
order by count(*) DESC

