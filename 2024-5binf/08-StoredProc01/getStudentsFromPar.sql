CREATE PROCEDURE getStudentsFromPar
	@courseId INT = NULL
AS
BEGIN
	IF @courseId IS NULL
	BEGIN
		SELECT * FROM Students;
	END
	ELSE
	BEGIN
		SELECT *
		FROM Students WHERE CourseID=@courseId;
	END

	IF @@ROWCOUNT = 0
	BEGIN
		PRINT 'Nessun studente trovato'
	END
END;