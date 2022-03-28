using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {

            int idadeLuci = 15; /*Declarando variavel*/
            int qtdPessoa = 2;

            Console.WriteLine("Testando Condicionais 2");

            if (idadeLuci >= 18) /*condicao SE*/
            {
                Console.WriteLine("Voce possui mais de 18 anos. Pode entrar.");
            }
            else /*Condicao SENAO*/

            {
                Console.WriteLine("Voce não possui 18 anos, não pode entrar");
            }


            Console.ReadLine();
        }
    }
}


