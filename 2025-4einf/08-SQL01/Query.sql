/* 1) Selezionare il nome, l’età e il salario degli impiegati con più 
	di 50 anni */
	SELECT nome, eta, salario
	FROM Impiegato
	WHERE eta > 50

/* 2) Estrarre tutte le informazioni relative agli acquisti di tende 
	(cioè dove item=Tenda)*/
	SELECT *
	FROM Acquisto
	WHERE item='Tenda'

/* 3) Di tutti i prodotti comprati dal cliente con id=10449 mostrare nome, 
	prezzo e id del cliente*/
	SELECT prezzo,idCliente, nome
	FROM Acquisto, Cliente
	WHERE idCliente=1
	AND Cliente.Id=idCliente

/* 4) Trovare il nome, il titolo e il dipartimento degli impiegati il 
	cui titolo comincia con “Ing”*/
	SELECT nome,titolo,dip
	FROM Impiegato 
	/* WHERE dip LIKE 'Ingegneri_' */
	WHERE titolo LIKE 'Ing%'

/* 5) Nome, titolo e salario di tutti coloro che hanno il titolo di 
	programmatore e un salario >= 50000 */
	SELECT nome,titolo,salario
	FROM Impiegato
	WHERE salario >= 5000
/* 6) Nome e salario di tutti coloro che lavorano al dipartimento 
	‘Vendite' o 'Programmazione' */
	SELECT nome,salario
	FROM Impiegato
	WHERE dip LIKE 'Vendite' OR dip LIKE 'Programmazione' 
/* 7) Selezionare tutte le diverse età degli impiegati */
	SELECT DISTINCT eta
	FROM Impiegato 

/* 8) Selezionare lo stipendio medio degli impiegati */
	SELECT AVG (salario) as media_salari
	FROM Impiegato