CREATE PROCEDURE spCreateApresentante
    @AprId UNIQUEIDENTIFIER,
	@Apr_PesId UNIQUEIDENTIFIER,
    @AprCodigoApresentante VARCHAR(160)
AS
    INSERT INTO [AprApresentante] (
        [AprId], 
        [Apr_PesId], 
        [AprCodigoApresentante]
    ) VALUES (
        @AprId,
		@Apr_PesId,
        @AprCodigoApresentante
    )
