/*
Store Procedure con parametro in output per 
ritornare il numero di studenti
*/

CREATE PROCEDURE getStudentCountByCourse
	@CourseID int,
	@StudentCount INT OUTPUT
AS
BEGIN
	SELECT @StudentCount=count(*)
	FROM Students
	WHERE CourseID=@CourseID

END;