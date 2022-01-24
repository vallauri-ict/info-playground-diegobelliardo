CREATE VIEW Vista1 AS
SELECT m.NomeMuseo,m.Citta,o.Titolo
FROM Opere o, Musei m
WHERE m.NomeMuseo=o.NomeMuseo