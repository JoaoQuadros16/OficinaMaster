# Oficina Master (versão desktop)

> **Status: descontinuado.** Esta foi a primeira versão do sistema, desenvolvida em Windows Forms.
> O projeto está sendo reconstruído como aplicação web em **MecanicaMaster**, com ASP.NET Core Web API e HTML/CSS/JavaScript. <!-- troque por link quando o repositório web estiver público -->

Sistema de gestão para oficina mecânica, com cadastro de clientes e veículos, controle de estoque de peças e login de usuários.
Criei este projeto para praticar **orientação a objetos em C#**, organização em camadas e integração com banco de dados.

## Tecnologias

- C# com Windows Forms (.NET Framework 4.7.2)
- SQL Server, com acesso via ADO.NET (`SqlConnection` / `SqlCommand` com consultas parametrizadas)
- BCrypt.Net-Next para hash de senhas

## Funcionalidades

- **Login** com senha armazenada como hash BCrypt e verificação de usuário ativo
- **Usuários:** cadastro com confirmação de senha
- **Clientes:** cadastro, listagem, edição e exclusão, com visualização dos veículos de cada cliente
- **Veículos:** cadastro e edição vinculados ao cliente, com busca por nome do cliente, placa, marca, modelo ou cor
- **Estoque de peças:** cadastro, listagem, busca, ajuste de quantidade, edição e exclusão de produtos

## Estrutura do projeto

O código está separado em camadas, cada uma com uma responsabilidade:

```
ControleEstoqueWindowsForm/
├── Models/     → entidades (Cliente, Veiculo, Produto, Usuario)
├── DAO/        → acesso ao banco de dados (SQL)
├── Services/   → regras de negócio e autenticação
├── Forms/      → telas, organizadas por módulo
└── Classes/    → conexão com o banco
```

As telas seguem um padrão: uma tela de **listagem** com pesquisa e grade de resultados, e uma tela **modal** separada para cadastro e edição.

## Capturas de tela

<!-- crie a pasta docs/img e adicione 3 ou 4 prints das telas principais -->

| Login | Clientes | Veículos |
|-------|----------|----------|
| ![Login](docs/img/login.png) | ![Clientes](docs/img/clientes.png) | ![Veículos](docs/img/veiculos.png) |

## Como executar

1. Clone o repositório e abra `ControleEstoqueWindowsForm.sln` no Visual Studio.
2. Crie o banco `OficinaMasterDB` no SQL Server com as tabelas `usuario`, `clientes`, `veiculos` e `produto`. <!-- se adicionar um script .sql, indique o caminho aqui -->
3. A conexão está em `Classes/Conexao.cs` e usa autenticação do Windows em `localhost`. Ajuste se o seu servidor for diferente.
4. Restaure os pacotes NuGet e execute o projeto.

## O que ficou pendente

- Módulos de Ordens de Serviço, Serviços, Financeiro, Dashboard e Configurações (os botões existem no menu, mas as telas não foram implementadas)
- Máscaras de entrada para CPF, telefone e placa
- Listas pré-definidas para marca, modelo e cor, em vez de texto livre
- Tratamento de erros mais completo
- Mover a string de conexão para o `App.config`

## Por que migrei para web

Durante o desenvolvimento percebi que um sistema desktop limitava o acesso a um único computador e me afastava do que eu mais queria aprender: **APIs, requisições HTTP e front-end**.
Por isso decidi recomeçar do zero em uma arquitetura web, usando este projeto como referência das regras de negócio.

## O que aprendi com este projeto

<!-- reescreva com suas palavras -->

- Aplicar orientação a objetos e separar o código em camadas (Models, DAO, Services, Forms)
- Fazer CRUD com ADO.NET usando consultas parametrizadas, que protegem contra SQL Injection
- Armazenar senhas com hash em vez de texto puro
- Migrar o banco de MySQL para SQL Server
- Avaliar quando uma tecnologia deixa de atender ao objetivo do projeto

---

Desenvolvido por **João Gabriel Rui de Quadros**, estudante de Análise e Desenvolvimento de Sistemas.
