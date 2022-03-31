using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto for Rendimento mensal");

            //declarando variavel
            double valorInvestido = 1000;

            //para contadorMes
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                //inicializacao varivel, atribuicao e incremento
            {
                valorInvestido *= 1.0036;
                Console.WriteLine(
                    "Após " + contadorMes + 
                    " Meses , você terá R$" + valorInvestido);

            }
            Console.ReadLine();
        }
    }
}
