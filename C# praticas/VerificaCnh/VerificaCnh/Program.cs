using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaCnh
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variaveis
        
            string nome;
            int idade;
            string temPermissao;

            Console.WriteLine("Dgite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem permissão para dirigir? 'S' ou 'N': ");
            temPermissao = Console.ReadLine();

            //condicionais

            if (idade >= 18 && temPermissao == "S")
            {
                Console.WriteLine(nome + ", você pode dirigir!!");
            }

            else if (idade >= 18 && temPermissao == "N")

            {
                Console.WriteLine(nome + ", você deve procurar uma Autoescola, não pode dirigir!!");

            }
            else
            {
                Console.WriteLine("Não pode dirigir, idade permitida a partir dos 18 ANOS!!!");
            }

            Console.ReadLine();
        }
    }
}
