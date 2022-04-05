using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variavel
            int x;
            

            Console.WriteLine("**********************");
            Console.WriteLine("********Tabuada*******");
            Console.WriteLine("**********************");

            Console.WriteLine("Digite um numero:\n ");
            x = int.Parse(Console.ReadLine());

            //enquanto i
            for (int i = 0; i <=10; i++)
            {
              
                Console.WriteLine(x + " * " + i + " = " + x * i);

            }

            Console.ReadLine();

        }
    }
}
