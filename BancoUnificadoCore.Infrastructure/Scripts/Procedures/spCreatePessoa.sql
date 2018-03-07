CREATE PROCEDURE spCreatePessoa
    @PesId UNIQUEIDENTIFIER,
	@PesNome VARCHAR(100),
	@PesSobreNome VARCHAR(100),
	@PesTipoDocumento INT,
	@PesDocumento VARCHAR(20),
	@PesEndereco VARCHAR(100),
	@PesBairro VARCHAR(100),
	@PesCidade VARCHAR(60),
	@PesUf VARCHAR(2),
	@PesCEP INT
AS
    INSERT INTO [PesPessoa] (
		[PesId],
		[PesNome],
		[PesSobreNome],
		[PesTipoDocumento],
		[PesDocumento],
		[PesEndereco],
		[PesBairro],
		[PesCidade],
		[PesUf],
		[PesCEP]
    ) VALUES (
		@PesId,
		@PesNome,
		@PesSobreNome,
		@PesTipoDocumento,
		@PesDocumento,
		@PesEndereco,
		@PesBairro,
		@PesCidade,
		@PesUf,
		@PesCEP
    )