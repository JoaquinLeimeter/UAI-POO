
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2022 11:54:57
-- Generated from EDMX file: C:\Users\joaquin\source\repos\TemplateMVC\Modelo\Contexto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TemplateMVC];
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

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Grupoes'
CREATE TABLE [dbo].[Grupoes] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'UsuarioGrupo'
CREATE TABLE [dbo].[UsuarioGrupo] (
    [Usuarios_Id] int  NOT NULL,
    [Grupoes_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Grupoes'
ALTER TABLE [dbo].[Grupoes]
ADD CONSTRAINT [PK_Grupoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Usuarios_Id], [Grupoes_Id] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [PK_UsuarioGrupo]
    PRIMARY KEY CLUSTERED ([Usuarios_Id], [Grupoes_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Usuarios_Id] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [FK_UsuarioGrupo_Usuario]
    FOREIGN KEY ([Usuarios_Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Grupoes_Id] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [FK_UsuarioGrupo_Grupo]
    FOREIGN KEY ([Grupoes_Id])
    REFERENCES [dbo].[Grupoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioGrupo_Grupo'
CREATE INDEX [IX_FK_UsuarioGrupo_Grupo]
ON [dbo].[UsuarioGrupo]
    ([Grupoes_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------