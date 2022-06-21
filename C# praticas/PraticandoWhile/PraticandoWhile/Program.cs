using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando  variavel
            int cont = 0;
            int x;

            //solicita os dados de entrada para o usuario digitr um numero qualquer (x)

            Console.WriteLine("Digfite um numero: ");
            x = int.Parse(Console.ReadLine());


            //enquanto contador for <= 10 imprima na tela o valor de x * contador 
            while (cont <= 10)
            {
                Console.WriteLine( x + " * " + cont + " = " + (x * cont));
                cont = cont + 1;
               
            }

            Console.ReadLine();
        } 
    }
}


