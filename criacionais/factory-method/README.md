<div Align="center">

# Entendendo o Factory Method

</div>

## A visão geral do padrão
Podemos pensar como se fosse uma fábrica da área de logística dos recursos de uma empresa que é responsável pela construção de objetos (classes) com uma mesma intenção de servir como meios de transporte (ou seja, vão possuir métodos com mesma assinatura, mas a implementação diferente).

O cliente (classe que necessita do objeto) pede a criação de um objeto específico como um barco e a fábrica vai delegar essa reponsabilidade para as subáreas dela (subclasses).

## Como o padrão faz isso?
O Factory Method fornece uma interface para criar objetos em uma superclasse (que pode ser abstrata ou não). Ela faz o contrato com essa interface, mas não é responsável pelos datalhes da criação do objeto ela na verdade chama os construtores das subclasses que alteram os tipos de objetos que são criados com suas especificações próprias.

No fim, o código cliente não saberá o que está acontecendo. Ele vai tratar o que é gerado pela fábrica como a superclasse, mas não saberá necessariamente o que é o tipo de objeto.

## Características do padrão
- Oculta a lógica de instanciação do objeto do código cliente, desclopando o código que cria do código que usa;
- É obtido através da herança;
- Dá flexibilidade podendo criar código novo sem mexer no código já escrito que está em consonância com o princípio do OCP;
- Pode usar parâmetros para fazermos o que quiser, determinar o tipo, repassar algo para o objeto que está sendo criado, etc.

## Estrutura do código
`UML DO CÓDIGO`

## Aplicabilidade
- Use o Factory Method quando não souber de antemão as dependências de objetos que o projeto usará. Como se trata de um código que permite a extensão é bem simples adicionar um novo produto, basta criar uma subclasse;
- Use o Factory Method quando deseja permitir que pessoas que estejam usando a biblioteca ou framework que você criou estenda os componentes internos e faça alterações criando ou alterando produtos;
- Use o Factory Method quando deseja economizar recursos do sistema reutilizando objetos existentes em vez de criá-los novamente;
- Use o Factory Method para desaclopar o código da classe que cria da classe que usa respeitando o princípio SRP;
- Use o Factory Method quando queremos que as subclasses tenham a lógica da implementação de criação de objetos;
- Use o Factory Method para eliminar duplicação de código.

## Prós e contras do uso do Factory Method
### Prós
- Evita acoplamentos entre o código de criador e produto;
- Corresponde ao princípio de responsabilidade única permitindo que seu código esteja bem definido podendo ser mudado para outros lugares sem prejudicar o código e permitindo uma melhor manutenção;
- Corresponde ao princípio do aberto/fechado permitindo a criação de novos produtos sem gerar problemas na classe ou código cliente.
 
### Contras
- O código pode futuramente se tornar muito complexo com o número grande de subclasses implementadas.
