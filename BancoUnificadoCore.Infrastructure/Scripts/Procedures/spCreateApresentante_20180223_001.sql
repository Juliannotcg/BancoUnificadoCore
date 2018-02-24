CREATE PROCEDURE spCreateApresentante
    @Id UNIQUEIDENTIFIER,
    @PrimeiroNome VARCHAR(40),
    @SegundoNome VARCHAR(40),
    @Documento INT(11),
    @CodigoApresentante VARCHAR(160)
AS
    INSERT INTO [Apresentante] (
        [Id], 
        [PrimeiroNome], 
        [SegundoNome], 
        [Documento], 
        [CodigoApresentante]
    ) VALUES (
        @Id,
        @PrimeiroNome,
        @SegundoNome,
        @Documento,
        @CodigoApresentante
    )