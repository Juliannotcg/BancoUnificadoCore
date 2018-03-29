CREATE PROCEDURE spSelectTituloProtocolo
	@Protocolo VARCHAR(100)
AS
BEGIN
   SELECT 
		[Id], 
		[Acao],
		[Aceite],
		[ApresentanteId],
		[CredorId],
		[DataAcao],
		[DataEmissao],
		[DataProtesto],
		[DataProtocolo],
		[DataVencimento],
		[Endosso],
		[Especie],
		[FinsFalimentares],
		[Folha],
		[Livro],
		[MotivoProtesto],
		[NossoNumero],
		[Numero],
		[NumeroProtesto],
		[Protocolo],
		[Saldo],
		[Sequencial],
		[Valor]
	FROM [Titulo]
   WHERE [Protocolo] = @Protocolo
END
		
	
