/*
Creare una SP che accetti un parametro per filtrare i dati
*/

CREATE PROCEDURE getStudentByCourse
	@CourseID int
AS
BEGIN
	SELECT * FROM Students
	Where CourseID=@CourseID
END;
