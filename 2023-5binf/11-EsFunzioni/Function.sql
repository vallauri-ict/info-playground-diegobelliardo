CREATE FUNCTION [dbo].[CercaPilota]
(
	@number int
)
RETURNS varchar(100)
AS
BEGIN
	RETURN (SELECT d.full_name FROM Driver d 
			WHERE d.number=@number)
END
