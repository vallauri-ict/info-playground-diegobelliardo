/*
Stored Procedure che recuperi tutte le righe della
tabella studenti
*/

CREATE PROCEDURE spGetAllStudents
AS
BEGIN
	SELECT * FROM Students;
END;
