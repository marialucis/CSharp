using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto Calcula Poupança");
            //declarando variavel
            double valorInvestido = 1000;
            int contadorMes = 1;
            
            //while = enquanto
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "  + contadorMes +  " meses  você terá R$ " + valorInvestido);
                contadorMes++;
            }


            Console.ReadLine();
        }
            
    }
}

