--SELECT i.nome,i.eta,i.salario
--FROM Impiegato i
--WHERE i.eta>50

--SELECT *
--FROM Acquisto a
--WHERE a.item='Tenda'

--SELECT a.item,a.prezzo,a.idCliente
--FROM Acquisto a
--WHERE a.idCliente=1

--SELECT i.nome,i.titolo, i.salario
--FROM Impiegato i
--WHERE i.salario>1800

--SELECT DISTINCT i.eta
--FROM Impiegato i

--SELECT AVG(i.salario)
--FROM Impiegato i

--SELECT *
--FROM Impiegato i
--WHERE i.dip='Vendite'
--ORDER BY i.salario ASC

--SELECT *
--FROM Impiegato i
--WHERE i.dip='Vendite'
--ORDER BY i.salario ASC, i.eta DESC

--SELECT *
--FROM Impiegato i
--WHERE i.eta >= 30
--AND i.eta <= 40

--SELECT *
--FROM Impiegato i
--WHERE i.eta BETWEEN 30 AND 40 

SELECT *
FROM Acquisto a, Cliente c
WHERE a.idCliente=c.Id
