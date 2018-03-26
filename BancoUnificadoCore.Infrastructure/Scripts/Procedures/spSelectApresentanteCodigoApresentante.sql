CREATE PROCEDURE spSelectApresentanteCodigoApresentante
	@CodigoApresentante VARCHAR(100)
AS
BEGIN
   SELECT [Nome]
	FROM [Apresentante]
	INNER JOIN Pessoa ON Pessoa.Id = PessoaId
   WHERE [CodigoApresentante] = @CodigoApresentante
END
		
	
