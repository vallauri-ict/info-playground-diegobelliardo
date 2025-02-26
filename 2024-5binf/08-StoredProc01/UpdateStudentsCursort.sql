CREATE PROCEDURE UpdateStudentsCursort
AS
BEGIN
	DECLARE @StudentID INT, @CourseID INT, @Status VARCHAR(50)

	DECLARE StudentCursor CURSOR LOCAL FAST_FORWARD FOR 
	SELECT StudentID, CourseID FROM Students

	OPEN StudentCursor;
	
	FETCH NEXT FROM StudentCursor INTO @StudentID, @CourseID;

	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @CourseID < 5


	END


END;