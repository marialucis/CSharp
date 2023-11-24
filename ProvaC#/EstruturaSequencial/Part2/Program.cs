using System.Globalization;
// See https://aka.ms/new-console-template for more information

/*
Programador(a): Luci Sousa
Data: 19/11/23

Açao:
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo 
com quatro casas decimais conforme exemplos.
Fórmula:  = 
Considere o valor de π = 3.14159

*/

//variaveis
double pi = 3.14159;
double raio ;
double area;




Console.WriteLine("Digite o valor do raio: ");
raio = double.Parse(Console.ReadLine());

area = (pi * (raio * raio));

Console.WriteLine("Area: " +area.ToString("F4",  CultureInfo.InvariantCulture));

Console.ReadLine();
