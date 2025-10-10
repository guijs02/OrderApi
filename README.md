# 🧾 OrderApi

API para gerenciamento de pedidos (**Order Management**), construída em **C#/.NET**, com foco em **escalabilidade**, **separação de responsabilidades** e **boas práticas arquiteturais**.

---

## 🧭 Sumário

1. [Visão Geral](#visão-geral)  
2. [Funcionalidades](#funcionalidades)  
3. [Tecnologias e Arquitetura](#tecnologias-e-arquitetura)  
4. [Como Rodar Localmente](#como-rodar-localmente)  

---

## 🚀 Visão Geral

O **OrderApi** é uma aplicação backend responsável por:

- Criar, consultar e atualizar pedidos  
- Aplicar regras de negócio específicas do domínio  
- Separar responsabilidades entre camadas (Core / API)  
- Facilitar manutenção, testes e evolução futura  

Ela serve como base sólida para sistemas de **e-commerce** ou **microserviços de pedidos**.

---

## ⚙️ Funcionalidades

- Criação de novo pedido  
- Consulta de pedido por ID  
- Listagem de pedidos  
- Atualização de status  
- Validações de domínio (ex: impedir avanço para status inválido)  
- Estrutura em camadas para melhor organização e testabilidade  

---

## 🧱 Tecnologias e Arquitetura

- **.NET / C#**
- **ASP.NET Core Web API**
- **Arquitetura em camadas**, seguindo princípios de **Clean Architecture** e **SOLID**
- **Injeção de dependência**
- **Validações de domínio**
- Separação entre:
  - **OrderApi.Core** → lógica de negócio, entidades, interfaces, regras  
  - **OrderApi** → API REST, controllers, configuração, DTOs, mapeamentos  

Essa estrutura promove **baixo acoplamento** e **alta coesão**, permitindo evoluções futuras sem impactar o núcleo da aplicação.

---

## 💻 Como Rodar Localmente

1. **Clone o repositório**

   ```bash
   git clone https://github.com/guijs02/OrderApi.git
   cd OrderApi
   OrderApi.sln
   dotnet restore
   dotnet run --project OrderApi


