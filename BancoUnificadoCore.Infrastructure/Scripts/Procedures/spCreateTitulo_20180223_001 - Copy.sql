CREATE PROCEDURE spCreateTitulo
    @TitId UNIQUEIDENTIFIER,
	@Tit_PesId UNIQUEIDENTIFIER,
	@TitProtocolo UNIQUEIDENTIFIER,
	@TitDataProtocolo DATETIME,
	@TitDataProtesto DATETIME,
	@TitDataEmissao DATETIME,
	@TitDataVencimento DATETIME,
	@TitDataAcao DATETIME,
	@TitLivro VARCHAR(20),
	@TitFolha VARCHAR(20),
	@TitNumeroProtesto INT,
	@TitEspecie VARCHAR(20),
	@TitNumero INT,
	@TitNossoNumero INT,
	@TitValor DECIMAL,
	@TitSaldo DECIMAL,
	@TitEndosso VARCHAR(20),
	@TitAceite VARCHAR(20),
	@TitFinsFalimentares BIT,
	@TitMotivoProtesto VARCHAR(50),
	@TitAcao INT,
	@TitSequencial INT
AS
    INSERT INTO [TitTitulo] (
    [TitId],
	[Tit_PesId],
	[TitProtocolo],
	[TitDataProtocolo],
	[TitDataProtesto],
	[TitDataEmissao],
	[TitDataVencimento],
	[TitDataAcao],
	[TitLivro],
	[TitFolha],
	[TitNumeroProtesto],
	[TitEspecie],
	[TitNumero],
	[TitNossoNumero],
	[TitValor],
	[TitSaldo],
	[TitEndosso],
	[TitAceite],
	[TitFinsFalimentares],
	[TitMotivoProtesto],
	[TitAcao],
	[TitSequencial]
    ) VALUES (
        @Id,
        @Cad_TitId
    )




        
            
          
           
            
            
           
           
            

            Sequencial = sequencial;
            _Pessoa = new List<Pessoa>();
