<div Align="center">

# Entendendo o Strategy

</div>

## A visão geral do padrão
Defini uma família de algoritmos que executam uma mesma coisa com formas diferentes. Dito isto, a visão geral é alocar essas diferentes formas de executar uma mesma coisa em classes diferentes permitindo que o código cliente use qualquer uma delas, e também, altere entre elas. Em outras palavras, é um padrão comportamental que vai focar na execução de uma mesma coisa de formas diferentes.

Podemos imaginar como um sistema de GPS (Exemplo do Refactoring Guru) que dado um ponto de partida e um de chegada calcula uma rota. Na versão inicial só faria isso em rodovias, mas com o sucesso surge a necessidade de criar rotas de ônibus, de ciclismo, de motos, de caminhada, etc. Neste sentido, só adicionar na classe responsável por calcular a rota pode gerar um código grande, complexo e com uma péssima qualidade para ser estendido.

O padrão Strategy vai pegar essa família de códigos que calculam rotas e dividir em classes diferentes para que se torne mais fácil de chamar, alterar e estender o comportamento para novas rotas.

## Como o padrão faz isso?
Extrai os códigos que fazem coisas específicas de maneiras diferentes e os aloca em classes denominadas estratégias. Um classe denominada contexto vai ter referência a abstração de estratégia delegando o trabalho de executar qualquer uma das classes estratégias sem que o contexto tenha os detalhes de implementação (a abstração pode ser uma interface, por exemplo). As estratégias concretas vão implementar a abstração para as diferentes variações do algoritmo.

O cliente defini a estratégia para o contexto que pode alterar segundo o desejo do código cliente ou só chamar um método geral que delega a função para a Estratégia. Ele não conhece de fato a implementação, só chama e seta a Estratégia conforme lhe é passado.

## Características do padrão
- 

## Estrutura do código
`UML DO CÓDIGO`

## Aplicabilidade
- Utilize quando tiver varições de um código que e diferem somente pela execução do comportamento.
- Utillize quando você tiver essas variantes e precisar alterar o algoritmo durante a execução.
- Utilize o padrão quando você tiver uma condicional muito grande com váarios algoritmos os isolando em classes separadas.

## Prós e contras do uso do Factory Method
### Prós
- 
 
### Contras
- 