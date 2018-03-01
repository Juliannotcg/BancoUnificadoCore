CREATE PROCEDURE spCreateCargaDiaria
    @Id UNIQUEIDENTIFIER,
	@Cad_TitId UNIQUEIDENTIFIER
AS
    INSERT INTO [CadCargaDiaria] (
        [Id],
        [Cad_TitId]
    ) VALUES (
        @Id,
        @Cad_TitId
    )