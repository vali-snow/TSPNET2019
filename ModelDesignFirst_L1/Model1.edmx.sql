
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/07/2019 22:32:56
-- Generated from EDMX file: C:\Code\TSPNET\ModelDesignFirst_L1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ServiceAutoDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [ClientId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(10)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] nvarchar(13)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Autos'
CREATE TABLE [dbo].[Autos] (
    [AutoId] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(10)  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [SasiuId] int  NOT NULL,
    [ClientId] int  NOT NULL
);
GO

-- Creating table 'Sasius'
CREATE TABLE [dbo].[Sasius] (
    [SasiuId] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nvarchar(max)  NOT NULL,
    [Denumire] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Mecanics'
CREATE TABLE [dbo].[Mecanics] (
    [MecanicId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Materials'
CREATE TABLE [dbo].[Materials] (
    [MaterialId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(10,2)  NOT NULL,
    [Pret] decimal(10,2)  NOT NULL,
    [DataAprovizionare] datetime  NOT NULL
);
GO

-- Creating table 'Imagines'
CREATE TABLE [dbo].[Imagines] (
    [ImagineId] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Foto] varbinary(max)  NOT NULL
);
GO

-- Creating table 'Operaties'
CREATE TABLE [dbo].[Operaties] (
    [OperatieId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(6,2)  NOT NULL
);
GO

-- Creating table 'Comands'
CREATE TABLE [dbo].[Comands] (
    [ComandaId] int IDENTITY(1,1) NOT NULL,
    [AutoId] int  NOT NULL,
    [StareComanda] nvarchar(max)  NOT NULL,
    [DataSystem] nvarchar(max)  NOT NULL,
    [DataProgramare] nvarchar(max)  NOT NULL,
    [DataFinalizare] nvarchar(max)  NOT NULL,
    [KmBord] nvarchar(max)  NOT NULL,
    [Descriere] nvarchar(max)  NOT NULL,
    [ValoarePiese] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ClientId] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([ClientId] ASC);
GO

-- Creating primary key on [AutoId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [PK_Autos]
    PRIMARY KEY CLUSTERED ([AutoId] ASC);
GO

-- Creating primary key on [SasiuId] in table 'Sasius'
ALTER TABLE [dbo].[Sasius]
ADD CONSTRAINT [PK_Sasius]
    PRIMARY KEY CLUSTERED ([SasiuId] ASC);
GO

-- Creating primary key on [MecanicId] in table 'Mecanics'
ALTER TABLE [dbo].[Mecanics]
ADD CONSTRAINT [PK_Mecanics]
    PRIMARY KEY CLUSTERED ([MecanicId] ASC);
GO

-- Creating primary key on [MaterialId] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [PK_Materials]
    PRIMARY KEY CLUSTERED ([MaterialId] ASC);
GO

-- Creating primary key on [ImagineId] in table 'Imagines'
ALTER TABLE [dbo].[Imagines]
ADD CONSTRAINT [PK_Imagines]
    PRIMARY KEY CLUSTERED ([ImagineId] ASC);
GO

-- Creating primary key on [OperatieId] in table 'Operaties'
ALTER TABLE [dbo].[Operaties]
ADD CONSTRAINT [PK_Operaties]
    PRIMARY KEY CLUSTERED ([OperatieId] ASC);
GO

-- Creating primary key on [ComandaId] in table 'Comands'
ALTER TABLE [dbo].[Comands]
ADD CONSTRAINT [PK_Comands]
    PRIMARY KEY CLUSTERED ([ComandaId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SasiuId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [FK_SasiuAuto]
    FOREIGN KEY ([SasiuId])
    REFERENCES [dbo].[Sasius]
        ([SasiuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SasiuAuto'
CREATE INDEX [IX_FK_SasiuAuto]
ON [dbo].[Autos]
    ([SasiuId]);
GO

-- Creating foreign key on [ClientId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [FK_ClientAuto]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([ClientId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAuto'
CREATE INDEX [IX_FK_ClientAuto]
ON [dbo].[Autos]
    ([ClientId]);
GO

-- Creating foreign key on [AutoId] in table 'Comands'
ALTER TABLE [dbo].[Comands]
ADD CONSTRAINT [FK_AutoComanda]
    FOREIGN KEY ([AutoId])
    REFERENCES [dbo].[Autos]
        ([AutoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoComanda'
CREATE INDEX [IX_FK_AutoComanda]
ON [dbo].[Comands]
    ([AutoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------