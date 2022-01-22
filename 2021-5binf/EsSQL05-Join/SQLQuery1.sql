SELECT *
FROM Continenti c, Nazioni n
WHERE c.Id=n.codContinente

SELECT *
FROM Continenti c INNER JOIN Nazioni n ON c.Id=n.codContinente

SELECT *
FROM Continenti c LEFT JOIN Nazioni n ON  c.Id=n.codContinente