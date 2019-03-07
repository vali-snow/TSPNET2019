CREATE TABLE [dbo].[Imagine]
(
	[ImagineId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [ComandaId] INT NULL, 
    [Titlu] NVARCHAR(15) NULL, 
    [Descriere] NVARCHAR(256) NULL, 
    [Data] DATETIME2 NULL, 
    [Foto] VARBINARY(MAX) NULL
)
