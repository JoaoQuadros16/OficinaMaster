-- Schema do banco de dados (SQL Server)
-- Nome do banco conforme a connection string em Classes/Conexao.cs

IF DB_ID('OficinaMasterDB') IS NULL
    CREATE DATABASE OficinaMasterDB;
GO

USE OficinaMasterDB;
GO

CREATE TABLE usuario (
    id          INT IDENTITY(1,1) PRIMARY KEY,
    nome        NVARCHAR(100) NOT NULL,
    login       NVARCHAR(50)  NOT NULL UNIQUE,
    senha_hash  NVARCHAR(255) NOT NULL,
    ativo       BIT           NOT NULL DEFAULT 1
);
GO

CREATE TABLE clientes (
    id          INT IDENTITY(1,1) PRIMARY KEY,
    nome        NVARCHAR(100) NOT NULL,
    cpf         NVARCHAR(14)  NOT NULL,
    telefone    NVARCHAR(15)  NULL,
    email       NVARCHAR(100) NULL
);
GO

CREATE TABLE veiculos (
    id          INT IDENTITY(1,1) PRIMARY KEY,
    ClienteId   INT           NOT NULL,
    placa       NVARCHAR(8)   NOT NULL,
    marca       NVARCHAR(50)  NOT NULL,
    modelo      NVARCHAR(50)  NOT NULL,
    ano         INT           NOT NULL,
    cor         NVARCHAR(30)  NULL,
    CONSTRAINT FK_veiculos_clientes FOREIGN KEY (ClienteId) REFERENCES clientes(id)
);
GO

CREATE TABLE produto (
    id          INT IDENTITY(1,1) PRIMARY KEY,
    nome        NVARCHAR(100) NOT NULL,
    quantidade  INT           NOT NULL DEFAULT 0
);
GO
