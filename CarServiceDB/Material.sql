CREATE TABLE [dbo].[Material]
(
	[MaterialId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Denumire] NVARCHAR(50) NULL, 
    [Cantitate] NUMERIC(10, 2) NULL, 
    [Pret] NUMERIC(10, 2) NULL, 
    [DataAprovizionare] DATETIME2 NULL
)
