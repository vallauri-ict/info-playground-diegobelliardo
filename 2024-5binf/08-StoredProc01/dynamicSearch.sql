/*
SP con SQL dinamico
la SP riceve il nome di una tabella, di una colonna e di un valore di ricerca
per costruire la query
*/

CREATE PROCEDURE dynamicSearch
	@tableName VARCHAR(50),
	@ColumnName VARCHAR(50),
	@SearchValue VARCHAR(50)
AS
BEGIN
	DECLARE @SQL VARCHAR(MAX);

	SET @SQL='SELECT * FROM '+@tableName+
	' WHERE '+@ColumnName+' LIKE ''%'+@SearchValue+'%''';

	EXEC sp_sqlexec @SQL;
END;
