### Introdução ao curso C#

Toda aplicação CSharp deve conter o bloco(funcao ou metodo) Main.

 - Console.WriteLine(); escreve na tela
 - Consele.ReadLine(); aguardar o teclado/recebe parametros do tecledo

 - WriteLine = escreve na tela e pula linha;
 - Write = Só escreve na tela; 
 - 
#### Variaves-

     As variáveis são utilizadas para armazenar os dados que um programa deve manipular. Toda
     variável possui um nome (identificador). Para acessar ou alterar o conteúdo de uma variável, é necessário utilizar o nome dessa variável.
     Em C#, toda variável possui um tipo. O tipo de uma variável determina o que pode ou não ser
     armazenado nela. Por exemplo, podemos determinar que uma variável só pode armazenar números
     inteiros.

#### Tipos variaveis-

     - Double - admite valores com ponto e também admite números inteiros;
     - Float - admite pontos flutuantes e casas decimais 
     - Int - só admite números inteiros.

#### Tipo inteiros-

    int idade = 23; -cria e atribui o valor da variavel 
    int idade ; 

     Para concatenar valores no Console.WriteLine usamos o sinal + 
     exe: Console.WriteLine1976078("a idade é "+ idade + ", parabéns!");


#### Tipo double-

     double salario;
     double salario = 1220.78;


#### Tipo float-

     float altura;
     float altura = 1.80f


#### Constantes-
    Definições:
    - Utilizamos uma constante para armazenar uma informação
    - As constantes NÃO PODEM ser alteradas
     ex:
     -const int IDADE_MINIMA; //Correto inica com ZERO
     -const int IDADE_MINIMA =23;



#### Tipos primitivos-
    Definições:
    - São tipos base cuso outros tipos(Complexos) irão derivar
    - Definir o tipo correto otimiza a execuçãõ do programa
    - São chamados de Tipos de valor
    - Armazenam o valor e não a referencia para um item na memoria
    - São classificados em:
    - Tipos Simples(Simple Types)
    - Enumeradores(Enum)
    - Estruturas(Structs)
    - Tipos Nulos(Nullable Types)



 #### Byte-
    Definições:
    - O tipo byte é utilizado para representar um byte de fato
    - Em diversos casos precisamos da cadeia de bytes de um arquivo por exemplo
    - Temos também o sbyte que permite vvalores negativos
  
 #### Signed e Usigned-
    Valores com sinal como "-" por exemplo, são chamados de signed.


#### Numeros Inteiros-
     Definições:
     - Numeros inteiros, ou seja, sem pontuação, podem ser definidos pelos TIPOS
     - Int
     - Short
     - Long

#### Numeros Reais-
    Definições:
    - Numeros   que exigem uma maior precisam, ou seja, com pontuação
    - Float
    - double
    - decimal

#### Boolean-   
    Definições:
    - Tipo booliano armazena apenas true ou false(Verdadeiro ou False)
    - Definido pela palavra reservada bool
    - bool(8-bit)
    - true ou false
  
   ex:
   -bool usuarioJaCadastrado = false;
   -bool pagamentoRecebido = true;


#### Char-
    Definições:
    - Utilizado para armazenar apenas um caractere no formato Unicode
    - Definido pela palavra reservada char
    - A atribuição de um valor char é dada por aspas simples
    - char(16-bit)

    ex:
    - char primeiraLetraa = 'C';
    - char segundaLetra =  'D';


#### String-
    Definições:
    - Armazena uma cadeia de caracteres
    - Podemos pensar nele como uma lista de char
    - Definido pela palavra reservada string
    - A atribuição de um valor string é dada por aspas duplas
  
    ex:
    - string primeiraLetra = "L";
    - string text = "Meu texto";
    - var documento = "123456789";



 #### Var-
    Definições:
    - Substitui o nome de um tipo
    - Será do tipo do primeiro valor atribuido
    - Recomendado o uso

    ex:
    - var idade = 25; //sera do tipo int
    - var nome = "Andre"; //sera do tipo string
  


  #### Null-
      Definições:
    - Significa vazio, nada
    - Diferente de zero ou uma string vazia
    - Todo tipo, primitivo ou complexo pode receber o valor null
    - O tipo deve ser marcado como Nullable Type

    ex:
    - int? idade = null; //atribuindo null a variavel
    

  #### obs: void = vazio

  #### Alias-
      Definições:
    - Alias é um apelido
    - Como o C# é Case Sensitive, tanto faz escrevermos um ou outro
    - Porém o recomendado é sempre usar o alias

    ex:
    - int idade = 25; // alias


  #### Valores padrões-
      Definições:
    - Todo tipo built-in, já possui um valor padrão
    - Se nenhum valor for informado,seu valor padrão será utilizado
  
    ex:
    - int => 0
    - float => 0
    - decimal => 0
    - char => '\0'
    - string => ""
  

  #### Parse-
      Definições:
    - Metodo presentte em todo tipo primitivo
    - Usado para converter um caractere ou string para um tipo qualquer
    - Caso haja alguma incompatibilidade, gera um erro
  
    ex:
    - int inteiro = int.Parse("100");

  #### Convert-
      Definições:
    - Similar ao parse visto anteriormente
    - Porém permite converter vários tipos de valor
      - Não apenas string
    - Devemos informar o tipo na chamada da conversão

    ex:
      - int inteiro = Convert.ToInt32("100")   ;


  #### Operadores Aritméticos-
      Definições:
      - Soma => +
      - Subtração => -
      - Multiplicação => *
      - Divisão => /

      ex: 
      - Multiplicação e divisão são executadas primeiro
      - Caso queira executar em outra ordem, usar parentes
      - Aceita short, int, floart, double e decimal
  
      * int soma = 25 + 22; //47
      * int subtracao = 25 - 22; //3
      * int multiplicacao = 25 * 22; //550
      * int divisao = 22/5 //4 
  

  
  #### Operadores de atribuição-
      Definições:
      - Utilizamos igual para atribuir um valor
      - Porém, podemos utilizar igual junto a um operador aritmético
      - x += 5 é o mesmo que x = x + 5
  
  #### Operadores de comparação-
      Definições: A comparação sempre retorna True ou False
      - Igual ==
      - Diferente !=
      - Maior que >
      - Menor que <
      - Maior ou igual a >=
      - Menor ou igual que  <=

      ex:
       - var x = 5;
       - var y = 10;
       - Console.WriteLine(x<y);
  

 #### Operadores Lógicos-
     Definições:
     - Usado para operações condicionais
     - Retorna SEMPRE verdadeiro ou Falso
     - E - and
     - Deve atender TODAS as condições
     - &&
     - OU - or
     - Se atender uma condição já retorna verdadeiro
     - ||
     - NEGAÇÃO -not
     -  !
  
     ex:
      int x = 12;
      - bool and = (x < 25) && (x < 40); //false
      - bool ou = (x > 25) || (x < 40); //true
      - bool negacao = !( x < 25); //false



 #### Estrutura condicional: if
      Definições:
      - Tradução: "SE" ou seja, "Caso alguma condição seja atendida"
      - Utilizado para tomada de decisões
      - Utiliza os operadores lógicos
  
      - Complemento ao if
      - Caso a condição não seja atendida
      - Podemos ter
      - else if(codição)
      - Podemos ter apenas else para exexutar algo caso a condição seja atendida

      ex:
       - if(condicao){ //caso seja verdadeiro
       - } else{ //caso seja falso
       - }

       - if(condicao){ // caso seja verdadeiro
       - } else if(condicao){ //senao, testa outra condicao
       - } else if(condicao){ //senao,testa outra condicao
       - } else { //se nao acontecer nenhuma das anteriores

  ### Switch
      Definições:
      - Utilizado quando temos muitas decisões
      - Executado em cascata
      - Devemos parar manualmente a execução com o comando break
      - Possui uma execução padrão chamado default
  
    exe:
  int valor = 1;
  switch(valor)
  {
      case 1: Console.WriteLine("1");
       break;
      case 2: Console.WriteLine("2");
       break;
      case 3: Console.WriteLine("3");
       break;
      default: Console.WriteLine("4");// se não for 1,2 ou 3
      break;
  }



 ## Funções/metodos
    Definições:




"VOID SEMPRE RETORNA NULL"


 ## VALUE TYPES
  Definições:
    