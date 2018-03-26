CREATE PROCEDURE spSelectDevedorDocumento
	@DocumentoDevedor VARCHAR(100)
AS
BEGIN
   SELECT [Nome], [SobreNome], [TipoDocumento], [Documento]
	FROM [Devedor]
   WHERE [Documento] = @DocumentoDevedor
END
		
	
