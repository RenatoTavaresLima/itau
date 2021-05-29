# Desafio: itidigital / backend-challenge

## Algumas informações
* A API foi desenvolvida em .Net 5
* A arquitetura utilizada foi a MVC
* Os testes foram escritos utilizando o xUnit
* O editor de código utilizado foi o Visual Studio Code

## Minhas decisões
Baseado nos requisitos do projeto, identifiquei que o problema proposto poderia ser facilmente resolvido utilizando o _data annotation "RegularExpressionAttribute"_ e a **Regular Expression** correta; Um vez definida, a Regex fez todo o _"trabalho sujo"_ com o mínimo de código possível e, a partir disso, bastou escrever os testes que validassem a tese.

# Vamos começar? 

## Configuração inicial
* Baixe e instale o sdk através desse link: https://dotnet.microsoft.com/download/dotnet/5.0
* Clone o repositório
  
# Rodando os testes
* Abra um terminal de comando e navegue até a pasta root do projeto
* Execute os comandos abaixo:
```
cd integrationTests
dotnet test
```
> **Nota**: Os testes cobrem todos os exemplos citados no enunciado + alguns casos extras
 
# Rodando a API
* No terminal de comando, navegue até a pasta root do projeto
* Execute os comandos abaixo:
```
cd api
dotnet run
```
* Para testar, acesse o Swagger através desse link: https://localhost:5001/Swagger/
> **Atenção**: Confirme se a aplicação está rodando na porta 5001; Caso necessário, altere a porta na url para acessar o Swagger.

