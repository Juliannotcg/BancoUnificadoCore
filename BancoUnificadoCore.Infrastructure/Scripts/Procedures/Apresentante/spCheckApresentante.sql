CREATE PROCEDURE spCheckApresentante
	@Documento VARCHAR(14)
AS
  SELECT [Id]
	FROM [Apresentante]
WHERE [Documento] = @Documento
	