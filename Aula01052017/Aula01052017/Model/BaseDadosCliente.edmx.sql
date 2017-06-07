
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2017 20:45:41
-- Generated from EDMX file: C:\Users\JoãoPaulo\Source\Repos\AspNetAulas\Aula01052017\Aula01052017\Model\BaseDadosCliente.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BaseClientes];
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

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [SobreNome] nvarchar(80)  NOT NULL,
    [CPF] nvarchar(15)  NOT NULL,
    [endereco] nvarchar(max)  NULL,
    [TipoClienteId] int  NOT NULL
);
GO

-- Creating table 'TiposCliente'
CREATE TABLE [dbo].[TiposCliente] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(30)  NOT NULL,
    [Descricao] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TiposCliente'
ALTER TABLE [dbo].[TiposCliente]
ADD CONSTRAINT [PK_TiposCliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TipoClienteId] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_TipoClienteCliente]
    FOREIGN KEY ([TipoClienteId])
    REFERENCES [dbo].[TiposCliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoClienteCliente'
CREATE INDEX [IX_FK_TipoClienteCliente]
ON [dbo].[Clientes]
    ([TipoClienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------