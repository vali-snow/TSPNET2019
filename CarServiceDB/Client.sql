CREATE TABLE [dbo].[Client]
(
	[ClientId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Nume] NVARCHAR(15) NULL, 
    [Prenume] NVARCHAR(15) NULL, 
    [Adresa] NVARCHAR(50) NULL, 
    [Localitate] NVARCHAR(10) NULL, 
    [Judet] NVARCHAR(10) NULL, 
    [Telefon] NUMERIC(13) NULL, 
    [Email] NVARCHAR(50) NULL
)
