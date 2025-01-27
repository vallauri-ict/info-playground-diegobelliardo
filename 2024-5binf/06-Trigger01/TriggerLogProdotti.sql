CREATE TRIGGER [LogModifiche]
	ON Prodotti
	AFTER UPDATE
	AS
	BEGIN
		SET NOCOUNT ON

		INSERT INTO AuditLog (idProdotto,action,descrizione)
		SELECT inserted.Id,
		CONCAT('Update Prodotti: ',inserted.nome,
		'| vecchio Prezzo: ',deleted.prezzo,
		'| nuovo Prezzo: ',inserted.prezzo,


	END
