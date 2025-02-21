/*
SP che esegue operazioni su più tabelle con gestione transazioni errori:
Inserire un nuovo studente e registrarlo sulla tabella Enrollments
In caso di errore annullare tutto
*/


CREATE PROCEDURE InsertStudentWithEnrollment
	@StudentName VARCHAR(50),
	@CourseID int
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		INSERT INTO Students (StudentName,CourseID)
		VALUES (@StudentName,@CourseID);

		/*****   Recupero l'ID dell'ultima insert    *****/
		DECLARE @StudentID int = SCOPE_IDENTITY();

		/*
		INSERT INTO Enrollments (StudentID)
		VALUES (@StudentID);
		*/
		
		INSERT INTO Enrollments (StudentID, CourseID)
		VALUES (@StudentID,@CourseID);
		

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;

	END CATCH
END;