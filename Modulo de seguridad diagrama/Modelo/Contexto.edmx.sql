
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/30/2022 16:13:41
-- Generated from EDMX file: c:\users\radium rocket\documents\visual studio 2017\Projects\Modulo de seguridad\Modelo\Contexto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Modulo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GrupoUsuario_Grupo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GrupoUsuario] DROP CONSTRAINT [FK_GrupoUsuario_Grupo];
GO
IF OBJECT_ID(N'[dbo].[FK_GrupoUsuario_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GrupoUsuario] DROP CONSTRAINT [FK_GrupoUsuario_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilPermiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permisos] DROP CONSTRAINT [FK_PerfilPermiso];
GO
IF OBJECT_ID(N'[dbo].[FK_FormularioPerfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Formularios] DROP CONSTRAINT [FK_FormularioPerfil];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilGrupo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grupos] DROP CONSTRAINT [FK_PerfilGrupo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Grupos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grupos];
GO
IF OBJECT_ID(N'[dbo].[Perfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfiles];
GO
IF OBJECT_ID(N'[dbo].[Permisos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permisos];
GO
IF OBJECT_ID(N'[dbo].[Formularios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formularios];
GO
IF OBJECT_ID(N'[dbo].[GrupoUsuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GrupoUsuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Clave] nvarchar(max)  NOT NULL,
    [Habilitado] bit  NOT NULL
);
GO

-- Creating table 'Grupos'
CREATE TABLE [dbo].[Grupos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PerfilId] int  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripción] nvarchar(max)  NOT NULL,
    [Habilitado] bit  NOT NULL
);
GO

-- Creating table 'Perfiles'
CREATE TABLE [dbo].[Perfiles] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Permisos'
CREATE TABLE [dbo].[Permisos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PerfilId] int  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Formularios'
CREATE TABLE [dbo].[Formularios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- Creating table 'GrupoUsuario'
CREATE TABLE [dbo].[GrupoUsuario] (
    [Grupo_Id] int  NOT NULL,
    [Usuario_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'Grupos'
ALTER TABLE [dbo].[Grupos]
ADD CONSTRAINT [PK_Grupos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [PK_Perfiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Permisos'
ALTER TABLE [dbo].[Permisos]
ADD CONSTRAINT [PK_Permisos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Formularios'
ALTER TABLE [dbo].[Formularios]
ADD CONSTRAINT [PK_Formularios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Grupo_Id], [Usuario_Id] in table 'GrupoUsuario'
ALTER TABLE [dbo].[GrupoUsuario]
ADD CONSTRAINT [PK_GrupoUsuario]
    PRIMARY KEY CLUSTERED ([Grupo_Id], [Usuario_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Grupo_Id] in table 'GrupoUsuario'
ALTER TABLE [dbo].[GrupoUsuario]
ADD CONSTRAINT [FK_GrupoUsuario_Grupo]
    FOREIGN KEY ([Grupo_Id])
    REFERENCES [dbo].[Grupos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Usuario_Id] in table 'GrupoUsuario'
ALTER TABLE [dbo].[GrupoUsuario]
ADD CONSTRAINT [FK_GrupoUsuario_Usuario]
    FOREIGN KEY ([Usuario_Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GrupoUsuario_Usuario'
CREATE INDEX [IX_FK_GrupoUsuario_Usuario]
ON [dbo].[GrupoUsuario]
    ([Usuario_Id]);
GO

-- Creating foreign key on [PerfilId] in table 'Permisos'
ALTER TABLE [dbo].[Permisos]
ADD CONSTRAINT [FK_PerfilPermiso]
    FOREIGN KEY ([PerfilId])
    REFERENCES [dbo].[Perfiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilPermiso'
CREATE INDEX [IX_FK_PerfilPermiso]
ON [dbo].[Permisos]
    ([PerfilId]);
GO

-- Creating foreign key on [PerfilId] in table 'Grupos'
ALTER TABLE [dbo].[Grupos]
ADD CONSTRAINT [FK_PerfilGrupo]
    FOREIGN KEY ([PerfilId])
    REFERENCES [dbo].[Perfiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilGrupo'
CREATE INDEX [IX_FK_PerfilGrupo]
ON [dbo].[Grupos]
    ([PerfilId]);
GO

-- Creating foreign key on [Perfil_Id] in table 'Formularios'
ALTER TABLE [dbo].[Formularios]
ADD CONSTRAINT [FK_PerfilFormulario]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[Perfiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilFormulario'
CREATE INDEX [IX_FK_PerfilFormulario]
ON [dbo].[Formularios]
    ([Perfil_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------