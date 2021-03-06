CREATE TABLE [PesPessoa]
(
	[PesId] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	[PesNome] VARCHAR(100) NOT NULL,
	[PesSobreNome] VARCHAR(100) NOT NULL,
	[PesTipoDocumento] INT NOT NULL,
	[PesDocumento] VARCHAR(20) NOT NULL,
	[PesEndereco] VARCHAR(100) NOT NULL,
	[PesBairro] VARCHAR(100) NOT NULL,
	[PesCidade] VARCHAR(60) NOT NULL,
	[PesUf] VARCHAR(2) NOT NULL,
	[PesCEP] INT NOT NULL
)

CREATE TABLE [AprApresentante]
(
	[AprId] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	[Apr_PesId] UNIQUEIDENTIFIER NOT NULL,
	[AprCodigoApresentante] VARCHAR(20) NOT NULL
	FOREIGN KEY ([Apr_PesID]) REFERENCES [PesPessoa]([PesId])
)

CREATE TABLE [TitTitulo]
(
	[TitId] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	[Tit_PesID] UNIQUEIDENTIFIER NOT NULL,
	[Tit_AprId] UNIQUEIDENTIFIER NOT NULL,
	[TitProtocolo] VARCHAR(50) NOT NULL,
	[TitDataProtocolo] DATETIME NOT NULL DEFAULT(GETDATE()),
	[TitLivro] VARCHAR(20) NOT NULL,
	[TitFolha] VARCHAR(20) NOT NULL,
	[TitDataProtesto] DATETIME NOT NULL DEFAULT(GETDATE()),
	[TitNumeroProtesto] INT NOT NULL,
	[TitDataEmissao] DATETIME NOT NULL DEFAULT(GETDATE()),
	[TitDataVencimento] DATETIME NOT NULL DEFAULT(GETDATE()),
	[TitEspecie] VARCHAR(20) NOT NULL,
	[TitNumero] INT NOT NULL,
	[TitNossoNumero] VARCHAR(100) NOT NULL,
	[TitValor] DECIMAL(10, 2) NOT NULL,
	[TitSaldo] DECIMAL(10, 2) NOT NULL,
	[TitEndosso] VARCHAR(100) NOT NULL,
	[TitAceite] VARCHAR(20) NOT NULL,
	[TitFinsFalimentares] BIT NOT NULL,
	[TitMotivoProtesto] VARCHAR(100) NOT NULL,
	[TitAcao] INT NOT NULL,
	[TitDataAcao] DATETIME NOT NULL DEFAULT(GETDATE()),
	[TitSequencial] INT NOT NULL,
	FOREIGN KEY ([Tit_PesID]) REFERENCES [PesPessoa]([PesId]),
	FOREIGN KEY ([Tit_AprId]) REFERENCES [AprApresentante]([AprId])
)



   
            
          
           
          
    

