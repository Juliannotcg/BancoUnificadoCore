CREATE PROCEDURE spCheckCredor
	@Documento VARCHAR(14)
AS
  SELECT [Id]
	FROM [Credor]
WHERE [Documento] = @Documento
	