# nextia

## Integrantes

Bianca Barreto RM:551848

Julia Akemi RM:98032

Pedro Baraldi Sá RM:98060

Mateus Fattori RM:97904

## Arquiterura
Na arquitetura monolítica, toda a lógica de negócios, manipulação de dados e APIs são implementadas em um único projeto ou serviço. Em vez de dividir a aplicação em vários serviços ou micro-serviços, toda a funcionalidade reside em uma única aplicação.
A arquitetura monolítica é uma boa escolha para projetos menores ou médios onde a simplicidade e a coesão são mais importantes do que a escalabilidade e a flexibilidade de serviços independentes. Ela permite uma abordagem direta e eficiente para desenvolvimento e implantação.

## Design patterns utilizado

# Padão Singleton 
No contexto da sua aplicação, o padrão Singleton foi utilizado para o ConfigSettings. A ideia é garantir que as configurações sejam carregadas uma única vez e que a mesma instância de ConfigSettings seja utilizada em toda a aplicação.

# Padrão Repository
Foi utilizado o padrão Repository para separar o acesso a dados para Cliente, Produto, e Promocao. Cada repositório (como ClienteRepository, ProdutoRepository, PromocaoRepository) implementa a interface correspondente (por exemplo, IClienteRepository) e é responsável por todas as operações CRUD relacionadas a essa entidade.

# Padrão Dependency Injection (DI)
Foi configurado a Dependency Injection no Program.cs para injetar dependências, como o contexto do banco de dados e os repositórios. Isso permite que você tenha uma instância do contexto e dos repositórios disponíveis para as controllers e outros serviços.

# Padrão Factory
Em muitos frameworks, incluindo ASP.NET Core, a configuração de serviços e a criação de instâncias são gerenciadas por um ServiceProvider, que age como uma fábrica para criar instâncias de serviços conforme necessário.

## Instruções para rodar a API

# Verificar se o ambiente está preparado

- Instale o .NET SDK: Certifique-se de que o SDK do .NET 8.0 está instalado. Você pode baixar o SDK do site oficial da Microsoft.

- Instale o Oracle Database e Oracle Data Provider: Certifique-se de ter o Oracle Database em funcionamento e o Oracle Data Provider for .NET (ODP.NET) instalado, se necessário para a conexão.

- Verifique o Visual Studio: Certifique-se de que você está usando a versão mais recente do Visual Studio, com o suporte para .NET 8.0 e ASP.NET Core.

# Verifique os Pacotes NuGet

- Microsoft.EntityFrameworkCore
  
- Microsoft.EntityFrameworkCore.Tools
  
- Oracle.EntityFrameworkCore
  
- Swashbuckle.AspNetCore

# Abrir o Projeto no Visual Studio

- Abrior o arquivo nextia_challenge_api.sln no Visual Studio

- Verificar se o arquivo e as pastas estão corretas

# Rodar o aruivo 

- clique no botão de play dentro do Visual Studio localizado no topo do Visual Studio como mostra as Imagens

![image](https://github.com/user-attachments/assets/3d0bc0ad-76be-49f9-baab-9f6acc2aa92f)

![image](https://github.com/user-attachments/assets/04c4d56d-33c9-4630-9242-449688b73ab0)

- certifique se que está em https

# Abrir a Documentação do Swagger

- Ao rodar o projeto ele ira automaticamente para o Swagger 

- caso não for a rota é
https://localhost:7256/swagger/index.html

