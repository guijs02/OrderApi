## Visão Geral  
O **OrderApi** é uma API construída em .NET, com foco em operações de pedidos (orders) e integração com domínio financeiro e operacional. O projeto está organizado em múltiplos módulos para garantir separação de responsabilidades, escalabilidade e manutenção eficiente.

---

## Arquitetura  
- **OrderApi.sln** — solução principal que reúne todos os projetos.  
- **OrderApi.Core** — projeto de núcleo (core) que contém modelos de domínio, interfaces, serviços abstratos e lógica compartilhada.  
- **OrderApi** — projeto Web API, onde ficam os controladores, endpoints REST, DI (injeção de dependência), configurações e startup.

Este formato segue princípios como CleanCode para garantir código organizado e de fácil evolução.

---

## Funcionalidades Principais  
- Criação, consulta, atualização e exclusão de pedidos (`orders`).  
- Rotas RESTful com ASP.NET Core.  
- Camada de domínio desacoplada da camada de infraestrutura.  
- Configuração de DI (injeção de dependência) para serviços e repositórios.  
- Padrões como Repositório (Repository), Unidade de Trabalho e serviços de domínio.  

---

## Como Começar

### Pré-requisitos  
- [.NET 6/7/8 SDK](https://dotnet.microsoft.com/download) (conforme alvo do projeto)  
- Visual Studio 2022 / Rider / VS Code com extensão C#  
- Banco de dados (ex: SQL Server, PostgreSQL) conforme configuração  
- Ferramentas de linha de comando: `dotnet cli`

### Instruções  
1. Clone o repositório:  
   ```bash
   git clone https://github.com/guijs02/OrderApi.git
