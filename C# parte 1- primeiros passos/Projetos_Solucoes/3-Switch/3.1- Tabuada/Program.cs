using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1__Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variavel
            int num1, num2;
            int opc;
            int resultado;

            Console.WriteLine("------------------");
            Console.WriteLine(" Calculadora ");
            Console.WriteLine("------------------");

            Console.WriteLine("----------------------------");
            Console.WriteLine(" Escolha o tipo de operação ");
            Console.WriteLine("----------------------------");
            Console.WriteLine(" [1]- Adição ");
            Console.WriteLine(" [2]- Subtração ");
            Console.WriteLine(" [3]- Divisão ");
            Console.WriteLine(" [4]- Multiplicação \n");

            Console.WriteLine("Digite uma opção: ");
            opc = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            num2 = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:

                    resultado = num1 + num2;

                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case 2:
                   
                    resultado = num1 - num2;

                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;


                case 3:

                    resultado = num1 / num2;

                    Console.WriteLine("O resultado da Divisão é: " + resultado);
                    break;

                case 4:

                    resultado = num1 * num2;

                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.ReadLine();
            }
        }
    }

