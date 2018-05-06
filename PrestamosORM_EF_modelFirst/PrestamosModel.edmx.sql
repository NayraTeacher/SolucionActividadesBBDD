
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2018 15:34:53
-- Generated from EDMX file: C:\Users\ndeniz\source\repos\SenderosDirecta\PrestamosORM_EF_modelFirst\PrestamosModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Prestamos];
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

-- Creating table 'UsuariosSet'
CREATE TABLE [dbo].[UsuariosSet] (
    [IdUser] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ArticulosSet'
CREATE TABLE [dbo].[ArticulosSet] (
    [IdArticulo] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [FechaDevolucion] datetime  NOT NULL,
    [numRenovaciones] int  NOT NULL,
    [PrestamosIdPrestamo] int  NOT NULL
);
GO

-- Creating table 'PrestamosSet'
CREATE TABLE [dbo].[PrestamosSet] (
    [IdPrestamo] int IDENTITY(1,1) NOT NULL,
    [Usuarios_IdUser] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdUser] in table 'UsuariosSet'
ALTER TABLE [dbo].[UsuariosSet]
ADD CONSTRAINT [PK_UsuariosSet]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdArticulo] in table 'ArticulosSet'
ALTER TABLE [dbo].[ArticulosSet]
ADD CONSTRAINT [PK_ArticulosSet]
    PRIMARY KEY CLUSTERED ([IdArticulo] ASC);
GO

-- Creating primary key on [IdPrestamo] in table 'PrestamosSet'
ALTER TABLE [dbo].[PrestamosSet]
ADD CONSTRAINT [PK_PrestamosSet]
    PRIMARY KEY CLUSTERED ([IdPrestamo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Usuarios_IdUser] in table 'PrestamosSet'
ALTER TABLE [dbo].[PrestamosSet]
ADD CONSTRAINT [FK_PrestamosUsuarios]
    FOREIGN KEY ([Usuarios_IdUser])
    REFERENCES [dbo].[UsuariosSet]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrestamosUsuarios'
CREATE INDEX [IX_FK_PrestamosUsuarios]
ON [dbo].[PrestamosSet]
    ([Usuarios_IdUser]);
GO

-- Creating foreign key on [PrestamosIdPrestamo] in table 'ArticulosSet'
ALTER TABLE [dbo].[ArticulosSet]
ADD CONSTRAINT [FK_PrestamosArticulos]
    FOREIGN KEY ([PrestamosIdPrestamo])
    REFERENCES [dbo].[PrestamosSet]
        ([IdPrestamo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrestamosArticulos'
CREATE INDEX [IX_FK_PrestamosArticulos]
ON [dbo].[ArticulosSet]
    ([PrestamosIdPrestamo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------