## Praticando CSharp

### Introdução ao curso C#

Toda aplicação CSharp deve conter o bloco(funcao ou metodo) Main.

Console.WriteLine(); escreve na tela
Consele.ReadLine(); aguardar o teclado/recebe parametros do tecledo

WriteLine = escreve na tela e pula linha;
Write = Só escreve na tela; 




#### Variaves-

As variáveis são utilizadas para armazenar os dados que um programa deve manipular. Toda
variável possui um nome (identificador). Para acessar ou alterar o conteúdo de uma variável, é necessário utilizar o nome dessa variável.
Em C#, toda variável possui um tipo. O tipo de uma variável determina o que pode ou não ser
armazenado nela. Por exemplo, podemos determinar que uma variável só pode armazenar números
inteiros.

#### Tipos variaveis-

Double - admite valores com ponto e também admite números inteiros;
Float - admite pontos flutuantes e casas decimais 
Int - só admite números inteiros.

#### TIpo inteiros-

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
-Utilizamos uma constante para armazenar uma informação
-As constantes NÃO PODEM ser alteradas
ex:
const int IDADE_MINIMA; //Correto inica com ZERO
const int IDADE_MINIMA =23;



#### Tipos primitivos-
Definições:
-São tipos base cuso outros tipos(Complexos) irão derivar
-Definir o tipo correto otimiza a execuçãõ do programa
-São chamados de Tipos de valor
-Armazenam o valor e não a referencia para um item na memoria
-São classificados em:
    -Tipos Simples(Simple Types)
    -Enumeradores(Enum)
    -Estruturas(Structs)
    -Tipos Nulos(Nullable Types)



