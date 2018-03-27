CREATE PROCEDURE spCreateCargaDiaria
    @Id UNIQUEIDENTIFIER,
	@tituloId UNIQUEIDENTIFIER
AS
INSERT INTO [CargaDiaria] (
[Id],
[tituloId]
	
) VALUES (
@Id,
@tituloId
)
