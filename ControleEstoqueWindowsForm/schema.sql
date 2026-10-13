-- =====================================================================
-- Oficina Master - script de criação do banco (SQL Server)
-- Se o nome do banco na sua connection string for outro, troque
-- "OficinaMasterDB" abaixo pelo mesmo nome.
-- =====================================================================

IF DB_ID('OficinaMasterDB') IS NULL
    CREATE DATABASE OficinaMasterDB;
GO

USE OficinaMasterDB;
GO

-- Evita que a numeração das OS (IDENTITY) pule de 1000 em 1000
-- quando o serviço do SQL Server é reiniciado (SQL Server 2017+)
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = OFF;
GO

-- ---------------------------------------------------------------------
-- Usuários (login e perfis de acesso)
-- ---------------------------------------------------------------------
CREATE TABLE usuario (
    id            INT IDENTITY(1,1) PRIMARY KEY,
    nome          NVARCHAR(100) NOT NULL,
    login         NVARCHAR(50)  NOT NULL,
    senha_hash    NVARCHAR(255) NOT NULL,
    ativo         BIT           NOT NULL DEFAULT 1,
    nivel_acesso  VARCHAR(20)   NULL,      -- 'Administrador' ou 'Funcionário'
    CONSTRAINT UQ_usuario_login UNIQUE (login)
);
GO

-- ---------------------------------------------------------------------
-- Clientes e veículos
-- ---------------------------------------------------------------------
CREATE TABLE clientes (
    id             INT IDENTITY(1,1) PRIMARY KEY,
    nome           NVARCHAR(150) NOT NULL,
    cpf            NVARCHAR(14)  NULL,     -- gravado só com números
    telefone       NVARCHAR(20)  NULL,     -- gravado só com números
    email          NVARCHAR(100) NULL,
    data_cadastro  DATETIME      NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Veiculos (
    Id         INT IDENTITY(1,1) PRIMARY KEY,
    ClienteId  INT           NOT NULL,
    Placa      VARCHAR(8)    NOT NULL,
    Modelo     NVARCHAR(100) NULL,
    Marca      NVARCHAR(100) NULL,
    Ano        INT           NULL,
    Cor        NVARCHAR(50)  NULL,
    CONSTRAINT FK_Veiculos_Clientes FOREIGN KEY (ClienteId) REFERENCES clientes(id)
);
GO

-- ---------------------------------------------------------------------
-- Estoque de peças e catálogo de serviços
-- ---------------------------------------------------------------------
CREATE TABLE produto (
    id          INT IDENTITY(1,1) PRIMARY KEY,
    nome        NVARCHAR(100) NOT NULL,
    quantidade  INT           NULL DEFAULT 0,
    valor       DECIMAL(10,2) NOT NULL DEFAULT 0      -- preço de venda
);
GO

CREATE TABLE Servicos (
    Id         INT IDENTITY(1,1) PRIMARY KEY,
    Descricao  NVARCHAR(200) NOT NULL,
    Valor      DECIMAL(10,2) NOT NULL,                 -- valor sugerido
    Ativo      BIT           NOT NULL DEFAULT 1,
    CONSTRAINT UQ_Servicos_Descricao UNIQUE (Descricao)
);
GO

-- ---------------------------------------------------------------------
-- Ordens de serviço
-- Status: ABERTA, EM ANDAMENTO, FINALIZADA, CANCELADA
-- ---------------------------------------------------------------------
CREATE TABLE OrdensServico (
    Id               INT IDENTITY(1,1) PRIMARY KEY,
    ClienteId        INT           NOT NULL,
    VeiculoId        INT           NOT NULL,
    DataAbertura     DATETIME      NOT NULL,
    DataFinalizacao  DATETIME      NULL,
    Descricao        NVARCHAR(500) NOT NULL,           -- problema relatado
    Status           NVARCHAR(20)  NOT NULL,
    CONSTRAINT FK_OS_Clientes FOREIGN KEY (ClienteId) REFERENCES clientes(id),
    CONSTRAINT FK_OS_Veiculos FOREIGN KEY (VeiculoId) REFERENCES Veiculos(Id)
);
GO

-- Serviços lançados na OS: o valor cobrado fica gravado aqui,
-- para não mudar se o preço do catálogo for alterado depois
CREATE TABLE OrdemServicoServicos (
    Id              INT IDENTITY(1,1) PRIMARY KEY,
    OrdemServicoId  INT           NOT NULL,
    ServicoId       INT           NOT NULL,
    Valor           DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_OSServicos_OS      FOREIGN KEY (OrdemServicoId) REFERENCES OrdensServico(Id),
    CONSTRAINT FK_OSServicos_Servico FOREIGN KEY (ServicoId)      REFERENCES Servicos(Id)
);
GO

-- Peças lançadas na OS: a baixa no estoque acontece só na finalização
CREATE TABLE OrdemServicoPecas (
    Id              INT IDENTITY(1,1) PRIMARY KEY,
    OrdemServicoId  INT           NOT NULL,
    ProdutoId       INT           NOT NULL,
    Quantidade      INT           NOT NULL,
    ValorUnitario   DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_OSPecas_OS      FOREIGN KEY (OrdemServicoId) REFERENCES OrdensServico(Id),
    CONSTRAINT FK_OSPecas_Produto FOREIGN KEY (ProdutoId)      REFERENCES produto(id)
);
GO

-- =====================================================================
-- Usuário inicial
-- Login: admin  |  Senha: admin123  (troque após o primeiro acesso)
-- A senha é armazenada como hash BCrypt.
-- =====================================================================
INSERT INTO usuario (nome, login, senha_hash, ativo, nivel_acesso)
VALUES ('Administrador', 'admin',
        '$2a$11$KXNUw7u0.0wfVBmuochvgedZq3VEOL.xrBMv8SkOCSqH99yizizGS',
        1, 'Administrador');
GO

-- =====================================================================
-- Dados de exemplo (opcional) - catálogo de serviços e estoque
-- =====================================================================
INSERT INTO Servicos (Descricao, Valor, Ativo) VALUES
('Troca de óleo e filtro',                  80.00, 1),
('Alinhamento',                             70.00, 1),
('Balanceamento (4 rodas)',                 60.00, 1),
('Troca de pastilhas de freio (dianteira)', 120.00, 1),
('Troca de correia dentada',                350.00, 1),
('Diagnóstico com scanner',                 120.00, 1),
('Revisão completa',                        400.00, 1);
GO

INSERT INTO produto (nome, quantidade, valor) VALUES
('Óleo de motor 5W30 sintético (1L)',   40,  45.00),
('Filtro de óleo',                      20,  35.00),
('Filtro de ar do motor',               15,  45.00),
('Pastilha de freio dianteira (jogo)',  12, 120.00),
('Correia dentada',                      5, 150.00),
('Vela de ignição',                     32,  30.00),
('Bateria 60Ah',                         5, 450.00);
GO
