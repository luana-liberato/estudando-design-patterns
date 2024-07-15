<div Align="center">

# Entendendo o Strategy

</div>

## A vis�o geral do padr�o
Defini uma fam�lia de algoritmos que s�o colocadas em classes diferentes e permite que o c�digo cliente possa usar qualquer uma delas podendo tamb�m alterar os objetos. Em outras palavras, � um padr�o comportamental que vai focar na execu��o de uma mesma coisa de formas diferentes (ou estrat�gias diferentes).

Podemos imaginar como um sistema de GPS que dado um ponto de partida e um de chegada ele calcula uma rota. Na vers�o inicial s� faria isso em rodovias, mas com o sucesso surge a necessidade de criar rotas de �nibus, ciclistas, motos, caminhada, etc. Neste sentido, s� adicionar pode gerar um c�digo grande, complexo e com uma p�ssima qualidade para ser estendido.

O padr�o Strategy vai pegar essa fam�lia de c�digos que calculam rotas e dividir em classes diferentes para que se torne mais f�cil de chamar, alterar e estender o comportamento para novas rotas.

## Como o padr�o faz isso?
Extrai os c�digos que fazem coisas espec�ficas de maneiras diferentes e os coloca em classes denominadas estrat�gias. Um classe chamada Contexto vai ter uma refer�ncia de alguma abstra��o de Estrat�gia delegando o trabalho de executar para esse objeto (uma interface, pro exemplo). As estrat�gias concretas v�o implementar a abstra��o para as diferentes varia��es do algoritmo.

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