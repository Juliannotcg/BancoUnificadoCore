CREATE PROCEDURE spCheckApresentante
	@Documento VARCHAR(14)
AS
	SELECT CASE WHEN EXISTS (
		SELECT [Id]
		FROM [Apresentante]
		WHERE [Documento] = @Documento
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT) END