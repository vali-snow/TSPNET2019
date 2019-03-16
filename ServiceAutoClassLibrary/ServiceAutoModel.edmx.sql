
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/14/2019 14:56:48
-- Generated from EDMX file: C:\Code\TSPNET\ServiceAutoClassLibrary\ServiceAutoModel.edmx
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

-- Creating table 'Autoturisme'
CREATE TABLE [dbo].[Autoturisme] (
    [AutoId] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(10)  NOT NULL,
    [SasiuId] int  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [ClientId] int  NOT NULL
);
GO

-- Creating table 'Sasiuri'
CREATE TABLE [dbo].[Sasiuri] (
    [SasiuId] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Mecanici'
CREATE TABLE [dbo].[Mecanici] (
    [MecanicId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Materiale'
CREATE TABLE [dbo].[Materiale] (
    [MaterialId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(10,2)  NOT NULL,
    [Pret] decimal(10,2)  NOT NULL,
    [DataAprovizionare] datetime  NOT NULL
);
GO

-- Creating table 'Imagini'
CREATE TABLE [dbo].[Imagini] (
    [ImagineId] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Foto] varbinary(max)  NOT NULL,
    [DetaliiComanda_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'Operatii'
CREATE TABLE [dbo].[Operatii] (
    [OperatieId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(6,2)  NOT NULL
);
GO

-- Creating table 'Comenzi'
CREATE TABLE [dbo].[Comenzi] (
    [ComandaId] int IDENTITY(1,1) NOT NULL,
    [AutoId] int  NOT NULL,
    [StareComanda] nvarchar(max)  NOT NULL,
    [DataSystem] nvarchar(max)  NOT NULL,
    [DataProgramare] nvarchar(max)  NOT NULL,
    [DataFinalizare] nvarchar(max)  NOT NULL,
    [KmBord] int  NOT NULL,
    [Descriere] nvarchar(max)  NOT NULL,
    [ValoarePiese] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetaliiComenzi'
CREATE TABLE [dbo].[DetaliiComenzi] (
    [DetaliuComandaId] int IDENTITY(1,1) NOT NULL,
    [ComandaId] int  NOT NULL,
    [MecanicId] int  NOT NULL,
    [Operatie_OperatieId] int  NOT NULL
);
GO

-- Creating table 'Clienti'
CREATE TABLE [dbo].[Clienti] (
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

-- Creating table 'DetaliComandaMaterial'
CREATE TABLE [dbo].[DetaliComandaMaterial] (
    [DetaliiComanda_DetaliuComandaId] int  NOT NULL,
    [Materiale_MaterialId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AutoId] in table 'Autoturisme'
ALTER TABLE [dbo].[Autoturisme]
ADD CONSTRAINT [PK_Autoturisme]
    PRIMARY KEY CLUSTERED ([AutoId] ASC);
GO

-- Creating primary key on [SasiuId] in table 'Sasiuri'
ALTER TABLE [dbo].[Sasiuri]
ADD CONSTRAINT [PK_Sasiuri]
    PRIMARY KEY CLUSTERED ([SasiuId] ASC);
GO

-- Creating primary key on [MecanicId] in table 'Mecanici'
ALTER TABLE [dbo].[Mecanici]
ADD CONSTRAINT [PK_Mecanici]
    PRIMARY KEY CLUSTERED ([MecanicId] ASC);
GO

-- Creating primary key on [MaterialId] in table 'Materiale'
ALTER TABLE [dbo].[Materiale]
ADD CONSTRAINT [PK_Materiale]
    PRIMARY KEY CLUSTERED ([MaterialId] ASC);
GO

-- Creating primary key on [ImagineId] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [PK_Imagini]
    PRIMARY KEY CLUSTERED ([ImagineId] ASC);
GO

-- Creating primary key on [OperatieId] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [PK_Operatii]
    PRIMARY KEY CLUSTERED ([OperatieId] ASC);
GO

-- Creating primary key on [ComandaId] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [PK_Comenzi]
    PRIMARY KEY CLUSTERED ([ComandaId] ASC);
GO

-- Creating primary key on [DetaliuComandaId] in table 'DetaliiComenzi'
ALTER TABLE [dbo].[DetaliiComenzi]
ADD CONSTRAINT [PK_DetaliiComenzi]
    PRIMARY KEY CLUSTERED ([DetaliuComandaId] ASC);
GO

-- Creating primary key on [ClientId] in table 'Clienti'
ALTER TABLE [dbo].[Clienti]
ADD CONSTRAINT [PK_Clienti]
    PRIMARY KEY CLUSTERED ([ClientId] ASC);
GO

-- Creating primary key on [DetaliiComanda_DetaliuComandaId], [Materiale_MaterialId] in table 'DetaliComandaMaterial'
ALTER TABLE [dbo].[DetaliComandaMaterial]
ADD CONSTRAINT [PK_DetaliComandaMaterial]
    PRIMARY KEY CLUSTERED ([DetaliiComanda_DetaliuComandaId], [Materiale_MaterialId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SasiuId] in table 'Autoturisme'
ALTER TABLE [dbo].[Autoturisme]
ADD CONSTRAINT [FK_SasiuAuto]
    FOREIGN KEY ([SasiuId])
    REFERENCES [dbo].[Sasiuri]
        ([SasiuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SasiuAuto'
CREATE INDEX [IX_FK_SasiuAuto]
ON [dbo].[Autoturisme]
    ([SasiuId]);
GO

-- Creating foreign key on [AutoId] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_AutoComanda]
    FOREIGN KEY ([AutoId])
    REFERENCES [dbo].[Autoturisme]
        ([AutoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoComanda'
CREATE INDEX [IX_FK_AutoComanda]
ON [dbo].[Comenzi]
    ([AutoId]);
GO

-- Creating foreign key on [ClientId] in table 'Autoturisme'
ALTER TABLE [dbo].[Autoturisme]
ADD CONSTRAINT [FK_ClientAuto]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clienti]
        ([ClientId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAuto'
CREATE INDEX [IX_FK_ClientAuto]
ON [dbo].[Autoturisme]
    ([ClientId]);
GO

-- Creating foreign key on [DetaliiComanda_DetaliuComandaId] in table 'DetaliComandaMaterial'
ALTER TABLE [dbo].[DetaliComandaMaterial]
ADD CONSTRAINT [FK_DetaliComandaMaterial_DetaliiComanda]
    FOREIGN KEY ([DetaliiComanda_DetaliuComandaId])
    REFERENCES [dbo].[DetaliiComenzi]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Materiale_MaterialId] in table 'DetaliComandaMaterial'
ALTER TABLE [dbo].[DetaliComandaMaterial]
ADD CONSTRAINT [FK_DetaliComandaMaterial_Material]
    FOREIGN KEY ([Materiale_MaterialId])
    REFERENCES [dbo].[Materiale]
        ([MaterialId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliComandaMaterial_Material'
CREATE INDEX [IX_FK_DetaliComandaMaterial_Material]
ON [dbo].[DetaliComandaMaterial]
    ([Materiale_MaterialId]);
GO

-- Creating foreign key on [DetaliiComanda_DetaliuComandaId] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [FK_DetaliComandaImagine]
    FOREIGN KEY ([DetaliiComanda_DetaliuComandaId])
    REFERENCES [dbo].[DetaliiComenzi]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliComandaImagine'
CREATE INDEX [IX_FK_DetaliComandaImagine]
ON [dbo].[Imagini]
    ([DetaliiComanda_DetaliuComandaId]);
GO

-- Creating foreign key on [Operatie_OperatieId] in table 'DetaliiComenzi'
ALTER TABLE [dbo].[DetaliiComenzi]
ADD CONSTRAINT [FK_DetaliComandaOperatie]
    FOREIGN KEY ([Operatie_OperatieId])
    REFERENCES [dbo].[Operatii]
        ([OperatieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliComandaOperatie'
CREATE INDEX [IX_FK_DetaliComandaOperatie]
ON [dbo].[DetaliiComenzi]
    ([Operatie_OperatieId]);
GO

-- Creating foreign key on [ComandaId] in table 'DetaliiComenzi'
ALTER TABLE [dbo].[DetaliiComenzi]
ADD CONSTRAINT [FK_ComandaDetaliComanda]
    FOREIGN KEY ([ComandaId])
    REFERENCES [dbo].[Comenzi]
        ([ComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaDetaliComanda'
CREATE INDEX [IX_FK_ComandaDetaliComanda]
ON [dbo].[DetaliiComenzi]
    ([ComandaId]);
GO

-- Creating foreign key on [MecanicId] in table 'DetaliiComenzi'
ALTER TABLE [dbo].[DetaliiComenzi]
ADD CONSTRAINT [FK_MecanicDetaliiComanda]
    FOREIGN KEY ([MecanicId])
    REFERENCES [dbo].[Mecanici]
        ([MecanicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MecanicDetaliiComanda'
CREATE INDEX [IX_FK_MecanicDetaliiComanda]
ON [dbo].[DetaliiComenzi]
    ([MecanicId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------