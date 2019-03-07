CREATE TABLE [dbo].[Comanda]
(
	[ComandaId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [AutoId] NCHAR(10) NULL, 
    [ClientId] NCHAR(10) NULL, 
    [MecanicIdList] NCHAR(10) NULL, 
    [MaterialIdList] NCHAR(10) NULL, 
    [OperationIdList] NCHAR(10) NULL, 
    [ImagineIdList] NCHAR(10) NULL, 
    [StareComanda] NCHAR(10) NULL, 
    [DataSystem] NCHAR(10) NULL, 
    [DataProgramare] NCHAR(10) NULL, 
    [DataFinalizare] NCHAR(10) NULL, 
    [KmBord] NCHAR(10) NULL, 
    [Descriere] NCHAR(10) NULL, 
    [ValoarePiese] NCHAR(10) NULL
)
