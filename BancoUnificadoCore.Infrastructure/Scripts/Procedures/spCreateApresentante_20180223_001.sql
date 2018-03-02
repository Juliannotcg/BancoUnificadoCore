CREATE PROCEDURE spCreateApresentante
    @AprId UNIQUEIDENTIFIER,
	@Apr_PesId UNIQUEIDENTIFIER,
    @CodigoApresentante VARCHAR(160)
AS
    INSERT INTO [Apresentante] (
        [AprId], 
        [Apr_PesId], 
        [CodigoApresentante]
    ) VALUES (
        @AprId,
        @PrimeiroNome,
        @SegundoNome,
        @Documento,
        @CodigoApresentante
    )