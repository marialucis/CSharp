using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for (int n= 1; n < 11 ; n++)
            {
                fatorial *= n;
                Console.WriteLine("Fatorial de " + n + " = " + fatorial);
            }

            Console.ReadLine();
        }

    }
}
