-- 1) Selezionare il nome, l’età e il salario degli impiegati 
--		con più di 50 anni

SELECT nome,eta,salario 
FROM Impiegato where eta>50

-- 2) Estrarre tutte le informazioni relative agli acquisti 
--		di tende (cioè dove item=Tenda)

SELECT * 
FROM Acquisto 
WHERE item='Tenda'

-- 3) Di tutti i prodotti comprati dal cliente con id=1 
--		mostrare nome, prezzo e id del cliente

SELECT c.nome, a.prezzo, c.id 
FROM Cliente c, Acquisto a
WHERE c.Id=a.idCliente
AND c.Id=1

-- 4) Trovare il nome, il titolo e il dipartimento degli impiegati 
--		il cui titolo comincia con “Ing”
SELECT nome, titolo, dipartimento
FROM Impiegato
WHERE titolo LIKE 'Ing%';

-- 5) Nome, titolo e salario di tutti coloro che hanno 
--	il titolo di programmatore e un salario >= 50000
SELECT nome, titolo, salario
FROM Impiegato
WHERE titolo='Programmatore'
AND salario>=50000

-- 6) Nome e salario di tutti coloro che lavorano al 
--	dipartimento ‘Vendite' o 'Programmazione'
SELECT nome, salario
FROM Impiegato
WHERE dipartimento='Vendite'
OR dipartimento='Programmazione'
