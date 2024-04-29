<div Align="center">

# Entendendo o Factory Method

</div>

## A visão geral do padrão
Podemos pensar como se fosse uma fábrica da área de logística dos recursos de uma empresa que é responsável pela construção de objetos (classes) com uma mesma intenção de servir como meios de transporte (ou seja, vão possuir métodos com mesma assinatura, mas a implementação diferente).

O cliente (classe que necessita do objeto) pede a criação de um objeto específico como um barco e a fábrica vai delegar essa reponsabilidade para as subáreas dela (subclasses).

## Como o padrão faz isso?
O Factory Method fornece uma interface para criar objetos em uma superclasse (que pode ser abstrata ou não). Ela faz o contrato com essa interface, mas não é responsável pelos datalhes da criação do objeto ela na verdade chama os construtores das subclasses que alteram os tipos de objetos que são criados com suas especificações próprias.

No fim, o código cliente não saberá o que está acontecendo. Ele vai tratar o que é gerado pela fábrica como a superclasse, mas não saberá necessariamente o que é o tipo de objeto.

## Estrutura do código