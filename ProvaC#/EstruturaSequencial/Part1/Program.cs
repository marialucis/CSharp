/*
Programador(a): Luci Sousa
Data: 19/11/23

Açao:
Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
Calcule e mostre o valor a ser pago.

*/

//variaveis
using System.Globalization;

int pc1;
int qtd1 = 0;
int pc2;
int qtd2 = 0;
double valorUnitarioPc1 , valorUnitarioPc2, valorAPagar1;



Console.WriteLine("***------------------***");
Console.WriteLine("*** Loja Peças Mania ***");
Console.WriteLine("***------------------***");

Console.WriteLine("Informe o codigo da primeira peça : ");
pc1 =int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de peças: ");
qtd1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor Unitario: ");
valorUnitarioPc1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Informe o codigo da segunda peça : ");
pc2 =int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de peças: ");
qtd2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor Unitario: ");
valorUnitarioPc2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

valorAPagar1 = (qtd1 * valorUnitarioPc1) + (qtd2 * valorUnitarioPc2);

Console.WriteLine("Valor a Pagar: " + valorAPagar1.ToString("F2",CultureInfo.InvariantCulture));

Console.ReadLine();
