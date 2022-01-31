CREATE TRIGGER [dbo].[StioricoUpdate]
    ON [dbo].[Driver]
    FOR UPDATE
    AS
    BEGIN
		DECLARE @Number int
		DECLARE @Name varchar(100)
		DECLARE @Country char(2)
		DECLARE @Dob date
		DECLARE @Team int
		DECLARE @nPodiums int
		DECLARE @NumberNew int
		DECLARE @NameNew varchar(100)
		DECLARE @CountryNew char(2)
		DECLARE @DobNew date
		DECLARE @TeamNew int
		DECLARE @nPodiumsNew int
		DECLARE @Data date

		SET @Number = (SELECT number FROM deleted)
		SET @Name = (SELECT full_name FROM deleted)
		SET @Country = (SELECT country FROM deleted)
		SET @Dob = (SELECT date_birth FROM deleted)
		SET @Team = (SELECT team_id FROM deleted)
		SET @nPodiums = (SELECT podiums_number FROM deleted)
		SET @NumberNew = (SELECT number FROM inserted)
		SET @NameNew = (SELECT full_name FROM inserted)
		SET @CountryNew = (SELECT country FROM inserted)
		SET @DobNew = (SELECT date_birth FROM inserted)
		SET @TeamNew = (SELECT team_id FROM inserted)
		SET @nPodiumsNew = (SELECT podiums_number FROM inserted)
		SET @Data = GETDATE()

		INSERT INTO StoricoAggiornamenti(number, full_name, country, date_birth, team_id, podiums_number, numberNew, full_nameNew, countryNew, date_birthNew, team_idNew, podiums_numberNew, [data])
			VALUES (@Number, @Name, @Country, @Dob, @Team, @nPodiums, @NumberNew, @NameNew, @CountryNew, @DobNew, @TeamNew, @nPodiumsNew, @Data)

    END
GO

CREATE TRIGGER [dbo].[StoricoDelete]
    ON [dbo].[Driver]
    FOR DELETE
    AS
    BEGIN
        SET NoCount ON

		DECLARE @Number int
		DECLARE @Name varchar(100)
		DECLARE @Country char(2)
		DECLARE @Dob date
		DECLARE @Team int
		DECLARE @nPodiums int
		DECLARE @Data date

		SET @Number = (SELECT number FROM deleted)
		SET @Name = (SELECT full_name FROM deleted)
		SET @Country = (SELECT country FROM deleted)
		SET @Dob = (SELECT date_birth FROM deleted)
		SET @Team = (SELECT team_id FROM deleted)
		SET @nPodiums = (SELECT podiums_number FROM deleted)
		SET @Data = GETDATE()

		INSERT INTO StoricoCancellazioni (number, full_name, country, date_birth, team_id, podiums_number, [data])
			VALUES (@Number, @Name, @Country, @Dob, @Team, @nPodiums, @Data)
    END