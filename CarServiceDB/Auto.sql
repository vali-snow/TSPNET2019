CREATE TABLE [dbo].[Auto]
(
	[AutoId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [NumarAuto] NVARCHAR(10) NULL, 
    [SasiuId] INT NULL, 
    [SerieSasiu] NVARCHAR(25) NULL
)
