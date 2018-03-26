CREATE PROCEDURE spSelectApresentante
AS
BEGIN
   SELECT [Nome]
	FROM [Apresentante]
	INNER JOIN Pessoa ON Pessoa.Id = PessoaId
END
		
	
