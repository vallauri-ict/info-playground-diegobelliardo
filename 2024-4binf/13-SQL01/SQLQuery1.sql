--1) Selezionare il nome, l’età e il salario degli impiegati con più di 50 anni

SELECT i.nome, i.eta, i.salario
FROM Impiegato i
WHERE eta > 10

--2) Estrarre tutte le informazioni relative agli acquisti di tende (cioè dove item=Tenda)

SELECT *
FROM Acquisto a
WHERE a.item = 'Tenda'

-- 3) Di tutti i prodotti comprati dal cliente con id=4 mostrare nome, prezzo e id del cliente

SELECT p.item, p.prezzo, c.id
FROM Acquisto p
JOIN Cliente c ON p.idCliente = c.id
WHERE c.id = 5

-- 4) Trovare il nome, il titolo e il dipartimento 
-- degli impiegati il cui titolo comincia con “Ing”

SELECT *
FROM Impiegato i
WHERE i.Titolo LIKE 'Ing%'

-- 5) Nome, titolo e salario di tutti coloro che 
-- hanno il titolo di programmatore e un salario >= 50000

SELECT *
FROM Impiegato i
WHERE i.Titolo='Programmatore'
AND i.Salario >= 300