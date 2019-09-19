# taskAPI - API De TASK
Esta aplicação é uma simples ferramenta de cadastdro de tarefas (Tasks) para o seu dia a dia.

## Introdução
A Aplicação foi desenvolvida a pedido da Supero Tecnologia para avaliação de qualidade profissional.

### Pré-requisitos

O sistema utiliza as tecnologias ferramentas e as versões:

* [.NET Core](https://github.com/dotnet/core) - Versão 2.2
* [Angular](https://angular.io/) - Versão 6.0.8
* [NodeJS](https://nodejs.org/en/) - Versão 10.16.0
* [EntityFrameworkCore](https://github.com/aspnet/EntityFrameworkCore) - Versão 2.2.6
* [Bootstrap](https://getbootstrap.com/) - Versão 4.0.3
* [Microsoft SQL Server](https://www.microsoft.com/pt-br/sql-server/) - Versão 12


### Comamndos necessários para rodar o projeto

Para inicializar o projeto, é necessário criar um Banco de Dados no servidor do SQL Server e rodar o script que cria a tabela. Após isso, 
ir na IDE do Visual Studio ou no Console do .NET Core (como foi neste projeto) instalar a ferramenta do Entity Framework para Design, da
biblioteca do SQL Server e o pacote Tools. O comando SQL está no diretório taskApi/SQL.
Depois será necessário instalar as dependências do Angular com o gerenciador de pacotes NPM na pasta ClientApp. Após a instalação dos pa-
cotes do Angular, ir na pasta taskApi e rodar o comando dotnet build e, por fim, dotnet run.

...
cd taskApi\ClientApp
npm install
cd ..
dotnet build
dotnet run
...

## Autor
* **Jeferson Job Ribeiro dos Santos** - Desenvolvedor de Sistemas - [jefersonjob1212](https://github.com/jefersonjob1212/)
