# Sistema de Gerenciamento de academias

## Projeto desenvolvido para o programa de Est�gio em Desenvolvimento de Aplica��es da VOLVO.

## Autores
Phillip Dylan e Rodrigo Kenji

## Tecnologias utilizadas
1. Back-end: .NET e Entity Framework
2. Banco de dados: SQL Server
3. Front-end: Windows Forms

## Sobre o programa:
O projeto consiste em um sistema de gerenciamento de academia, contendo v�rias funcionalidades que podem ser necess�rias para uma boa gest�o de seus alunos, planos, funcionarios e financias.

Pelo programa � poss�vel realizar o CRUD (Create, Read, Update e Delete) de alunos, funcionarios, planos, despesas e itens do inventario, al�m de gerar relat�rios de Faturamento, Vendas, Despesas, Lucro, Planos ativos e Planos a vencer, tudo por uma interface amig�vel e intuitiva ao usu�rio.

O C�digo foi criado com base nos padr�es de projeto MVC (Model-View-Controller) e Repository.

## Tutorial de utiliza��o:
Primeiramente fa�a o Download do projeto no github [Clique aqui para acessar o projeto](https://github.com/Rocket-Galaxy/Academia_GUI)

Trocar as vari�vies de ambiente (Arquivo ConfigResource.resx) e colocar em BaseApiURL o endere�o principal do backend (exemplo: https://localhost:5146?api) e no backend alterar em lauchSettings.json em "applicationUrl" em https e http o endere�o (exemplo: https://localhost:5146?api) 

Ao rodar a IDE, rode simultaneamente backend em HTTP o e o front-end normalmente.
