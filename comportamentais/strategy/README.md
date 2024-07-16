<div Align="center">

# Entendendo o Strategy

</div>

## A vis�o geral do padr�o
Defini uma fam�lia de algoritmos que executam uma mesma coisa com formas diferentes. Dito isto, a vis�o geral � alocar essas diferentes formas de executar uma mesma coisa em classes diferentes permitindo que o c�digo cliente use qualquer uma delas, e tamb�m, altere entre elas. Em outras palavras, � um padr�o comportamental que vai focar na execu��o de uma mesma coisa de formas diferentes.

Podemos imaginar como um sistema de GPS (Exemplo do Refactoring Guru) que dado um ponto de partida e um de chegada calcula uma rota. Na vers�o inicial s� faria isso em rodovias, mas com o sucesso surge a necessidade de criar rotas de �nibus, de ciclismo, de motos, de caminhada, etc. Neste sentido, s� adicionar na classe respons�vel por calcular a rota pode gerar um c�digo grande, complexo e com uma p�ssima qualidade para ser estendido.

O padr�o Strategy vai pegar essa fam�lia de c�digos que calculam rotas e dividir em classes diferentes para que se torne mais f�cil de chamar, alterar e estender o comportamento para novas rotas.

## Como o padr�o faz isso?
Extrai os c�digos que fazem coisas espec�ficas de maneiras diferentes e os aloca em classes denominadas estrat�gias. Um classe denominada contexto vai ter refer�ncia a abstra��o de estrat�gia delegando o trabalho de executar qualquer uma das classes estrat�gias sem que o contexto tenha os detalhes de implementa��o (a abstra��o pode ser uma interface, por exemplo). As estrat�gias concretas v�o implementar a abstra��o para as diferentes varia��es do algoritmo.

O cliente defini a estrat�gia para o contexto que pode alterar segundo o desejo do c�digo cliente ou s� chamar um m�todo geral que delega a fun��o para a Estrat�gia. Ele n�o conhece de fato a implementa��o, s� chama e seta a Estrat�gia conforme lhe � passado.

## Caracter�sticas do padr�o
- 

## Estrutura do c�digo
`UML DO C�DIGO`

## Aplicabilidade
- Utilize quando tiver vari��es de um c�digo que e diferem somente pela execu��o do comportamento.
- Utillize quando voc� tiver essas variantes e precisar alterar o algoritmo durante a execu��o.
- Utilize o padr�o quando voc� tiver uma condicional muito grande com v�arios algoritmos os isolando em classes separadas.

## Pr�s e contras do uso do Factory Method
### Pr�s
- 
 
### Contras
- 