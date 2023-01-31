DECLARE @fullNameRes varchar(100)
DECLARE @countryRes char(2)
EXEC dbo.SPInfoPilota  @number=1, @fullName=@fullNameRes output, 
								  @country=@countryRes output;

SELECT @fullNameRes,@countryRes