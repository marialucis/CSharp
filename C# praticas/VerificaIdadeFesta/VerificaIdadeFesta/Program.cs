/* Aplicação que vai checar se é maior de idade para entrar na festa;
 * Caso não possua a maior idade, vai checar se está acompanhado;
 * Se não for maior de idade e não estiver acompanhado, não tem permissão para entrar na festa;
 * 
    Desenvolvedor(a): Luci Sousa
                      17/06/2022  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaIdadeFesta
{
    class Program
    {

        static void Main(string[] args)
        {
            //declarando variaveis

            int idade;
            int verificaQtdPessoa = 2;


            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de Pessoas: ");
            verificaQtdPessoa = int.Parse(Console.ReadLine());

            //condicionais

            if (idade >= 18)
            {
                Console.WriteLine("Pode entrar! Curta bastante a festa!!");
            }
            else if(idade <= 18 && verificaQtdPessoa > 1)
            {
                Console.WriteLine("Está acompanhando, pode entrar!");
            }
            else
            {
                Console.WriteLine("É menor de idade e não está acompanhado, não pode entrar!");
            }

            Console.WriteLine("Próximo...");
            Console.ReadLine();

        }
    }
}

