CREATE TRIGGER [NuovaAuto]
	ON Auto
	INSTEAD OF INSERT
	AS
	BEGIN
--		SET NOCOUNT ON
		DECLARE @targa as VARCHAR(7)
		DECLARE @cilindrata as INT
		DECLARE @prezzo as float
		DECLARE @modello as VARCHAR(50)
		DECLARE @colore as VARCHAR(50)
		DECLARE @marca as VARCHAR(50)
		DECLARE @alimentazione as VARCHAR(50)

		SET @targa = (SELECT targa from inserted)
		SET @cilindrata = (SELECT cilindrata from inserted)
		SET @prezzo = (SELECT prezzo from inserted)
		SET @modello = (SELECT modello from inserted)
		SET @colore = (SELECT colore from inserted)
		SET @marca = (SELECT marca from inserted)
		SET @alimentazione = (SELECT alimentazione from inserted)

		if (@cilindrata<900)
			SET @cilindrata = 900

		if (@cilindrata>4800)
			SET @cilindrata = 4800

		INSERT INTO Auto Values
		(@targa,@cilindrata,@prezzo,@modello,@colore,@marca,@alimentazione)

	END
