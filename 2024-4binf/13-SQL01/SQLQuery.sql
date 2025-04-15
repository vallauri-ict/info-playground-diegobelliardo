-- 1) Selezionare il nome, l’età e il salario degli 
-- impiegati con più di 50 anni

SELECT i.nome, i.eta, i.salario AS Stipendio
FROM Impiegato i
WHERE i.eta > 50;

-- 2) Estrarre tutte le informazioni relative agli 
-- acquisti di tende (cioè dove item=Tenda)

SELECT *
FROM Acquisto a
WHERE a.item = 'Tenda';

-- 3) Di tutti i prodotti comprati dal cliente con 
-- id=1 mostrare nome, prezzo e id del cliente

SELECT c.nome, a.prezzo, a.cliente_id
FROM Acquisto a, Cliente c