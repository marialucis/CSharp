## Praticando CSharp

### Introdução ao curso C#

Toda aplicação CSharp deve conter o bloco(funcao ou metodo) Main.

 - Console.WriteLine(); escreve na tela
 - Consele.ReadLine(); aguardar o teclado/recebe parametros do tecledo

 - WriteLine = escreve na tela e pula linha;
 - Write = Só escreve na tela; 




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
 const int IDADE_MINIMA; //Correto inica com ZERO
 const int IDADE_MINIMA =23;



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
  bool usuarioJaCadastrado = false;
  bool pagamentoRecebido = true;


#### Char-
    Definições:
- Utilizado para armazenar apenas um caractere no formato Unicode
- Definido pela palavra reservada char
- A atribuição de um valor char é dada por aspas simples
- char(16-bit)

ex:
char primeiraLetraa = 'C';
char segundaLetra =  'D';


#### String-
    Definições:
- Armazena uma cadeia de caracteres
- Podemos pensar nele como uma lista de char
- Definido pela palavra reservada string
- A atribuição de um valor strinf é dada por aspas duplas
  
  ex:
  



    
