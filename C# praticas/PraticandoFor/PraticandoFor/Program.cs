using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel 
            int x;

            //entradas do usuario
            Console.WriteLine("Digite um numero: ");
            x = int.Parse(Console.ReadLine());

            //enquanto i for inicializada = 1 ; i será executado <= 10;  incremente i 
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x + " * " + i + " = " + (x * i));
            }

            Console.ReadLine();
        }
    }
}
