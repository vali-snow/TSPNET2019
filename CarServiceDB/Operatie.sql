CREATE TABLE [dbo].[Operatie]
(
	[OperatieId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Denumire] NVARCHAR(256) NULL, 
    [TimpExecutie] NUMERIC(6, 2) NULL
)
