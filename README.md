# SalesWebMvc

Sistema web de gerenciamento de vendas, vendedores e departamentos desenvolvido durante o curso de C# do professor Nélio Alves.

## Tecnologias

- C# / .NET (ASP.NET Core MVC)
- Entity Framework Core
- SQL Server
- Bootstrap

## Funcionalidades

- Cadastro, edição, visualização e exclusão de departamentos e vendedores
- Operações assíncronas com banco de dados
- Povoamento inicial do banco de dados
- Busca de vendas por data (simples e agrupada)

## Como executar

1. Clone o repositório
2. Configure a string de conexão do SQL Server no arquivo `appsettings.json`
3. Execute o comando `dotnet ef database update` no terminal para criar o banco
4. Execute o projeto com `dotnet run`
