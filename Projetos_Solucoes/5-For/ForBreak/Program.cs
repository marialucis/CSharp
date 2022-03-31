using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break; //para a instrucao for
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
