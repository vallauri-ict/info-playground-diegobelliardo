--SELECT nome,eta,salario
--FROM Impiegato i
--WHERE i.eta > 50

--SELECT *
--FROM Acquisto a
--WHERE a.item = 'Tenda'

--SELECT nome,prezzo,idCliente
--FROM Acquisto a, Cliente c
--WHERE a.IdCliente = c.Id AND c.Id = 10449

-- 4) Trovare il nome, il titolo e il dipartimento degli impiegati 
--    il cui titolo comincia con “Ing”
SELECT i.nome,i.titolo,i.dip
FROM Impiegato i
WHERE i.titolo LIKE 'Ing%'

-- 5) Nome, titolo e salario di tutti coloro che hanno il titolo 
--    di programmatore e un salario >= 50000

SELECT *
FROM Impiegato i
WHERE i.salario >= 1000
AND i.titolo='Programmatore'

-- 6) Nome e salario di tutti coloro che lavorano al dipartimento 
--	‘Vendite' o 'Programmazione'
SELECT i.nome, i.salario
FROM Impiegato i
WHERE i.dip=1 OR i.dip=2

-- 7) Selezionare tutte le diverse età degli impiegati
SELECT distinct i.eta
FROM Impiegato i
