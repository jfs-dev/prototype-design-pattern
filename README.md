# prototype-design-pattern
Usando Prototype Design Pattern para a criação de objetos, reduzindo a sobrecarga associada à criação direta de novas instâncias e promovendo um baixo acoplamento entre clientes e protótipos usando C#

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como usar o Prototype Design Pattern para a criação de objetos, reduzindo a sobrecarga associada à criação direta de novas instâncias e promovendo um baixo acoplamento entre clientes e protótipos usando C#.

Alguns benefícios de usar o Prototype Design Pattern:

**Redução da sobrecarga de criação de objetos:** Em situações em que a criação de objetos é custosa em termos de desempenho ou complexidade, o padrão Prototype permite criar novos objetos duplicando um objeto existente. Isso pode reduzir significativamente a sobrecarga associada à criação de objetos, especialmente quando a inicialização de objetos é intensiva em recursos.

**Flexibilidade na criação de objetos:** O padrão Prototype oferece flexibilidade na criação de novos objetos, permitindo que os clientes criem novas instâncias de objetos complexos por meio da clonagem de protótipos existentes. Isso é especialmente útil quando a estrutura e a configuração dos objetos podem variar e não são conhecidas antecipadamente.

**Isolamento de clientes e protótipos:** Os clientes que usam o padrão Prototype não precisam estar cientes das complexidades envolvidas na criação de objetos. Eles simplesmente solicitam a clonagem de um protótipo existente para obter uma nova instância. Isso promove um baixo acoplamento entre clientes e classes de protótipo, facilitando a manutenção e a evolução do código.

**Suporte a cópias superficiais e profundas:** O padrão Prototype pode suportar tanto cópias superficiais quanto profundas de objetos, dependendo dos requisitos do aplicativo. Isso oferece flexibilidade para escolher o tipo de clonagem mais apropriado para a situação específica.

**Melhor desempenho em comparação com a criação direta:** Em muitos casos, a clonagem de um objeto existente pode ser mais eficiente em termos de desempenho do que a criação direta de um novo objeto. Isso é especialmente verdadeiro quando a inicialização de objetos envolve operações intensivas em termos de recursos, como consultas a bancos de dados, operações de rede ou cálculos complexos.

<div align="center">
    <img src="https://github.com/jfs-dev/prototype-design-pattern/assets/54154628/d162907f-c12f-4cba-9e2e-f26cc3dc7371"</img>
</div>

## Referências
https://refactoring.guru/design-patterns/prototype/

https://dotnettutorials.net/lesson/prototype-design-pattern/

## Licença
GPL-3.0 license
