CREATE PROCEDURE spCreateCredor
	@Id UNIQUEIDENTIFIER,
	@Documento VARCHAR(50),
	@TipoDocumento VARCHAR(10),
	@Bairro VARCHAR(50),
	@CEP VARCHAR(20),
	@Cidade VARCHAR(50),
	@Logradouro VARCHAR(150),
	@UF VARCHAR(2),
	@Nome VARCHAR(150),
	@SobreNome VARCHAR(150)
AS
    INSERT INTO [Credor] (
        [Id], 
        [Documento],
		[TipoDocumento],
		[Bairro],
		[CEP],
		[Cidade],
		[Logradouro],
		[UF],
		[Nome],
		[SobreNome]
    ) VALUES (
        @Id,
        @Documento,
		@TipoDocumento,
		@Bairro,
		@CEP,
		@Cidade,
		@Logradouro,
		@UF,
		@Nome,
		@SobreNome
    )
