CREATE PROCEDURE UpdateEnrolmentFromType
	@EnrolmentsUpdate EnrolmentType READONLY
AS
BEGIN
	UPDATE e
	SET e.StudentID = ee.StudentID
	FROM Enrollments e INNER JOIN @EnrolmentsUpdate ee ON e.EnrollmentID=ee.EnrolmentID
END;