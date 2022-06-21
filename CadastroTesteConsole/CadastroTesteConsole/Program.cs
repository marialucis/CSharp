/*
 * Aplicação cadastro de pessoas
 
 * Desenvolvedor(a): Luci Sousa
                     19/06/2022

 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroTesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int opc;
            string nome;
            string sobrenome;
            string cpf;
            string email;
            string telefone;
            string sexo;


            Console.WriteLine("---------------------------------");
            Console.WriteLine("-------Cadastro de Pessoas-------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("1-Cadastrar");
            Console.WriteLine("2-Exibir cadastro");
            Console.WriteLine("3-Sair");
            Console.WriteLine("\n");

            Console.WriteLine("Digite a opção: ");
            opc = int.Parse(Console.ReadLine());

            //condicionais
            if (opc == 1)
            {
                Console.WriteLine("Digite seu NOME: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite seu SOBRENOME: ");
                sobrenome = Console.ReadLine();
                Console.WriteLine("Digite seu CPF: ");
                cpf = Console.ReadLine();
                Console.WriteLine("Digite seu E-MAIL: ");
                email = Console.ReadLine();
                Console.WriteLine("Digite seu TELEFONE: ");
                telefone = Console.ReadLine();
                Console.WriteLine("Digite seu SEXO: ");
                sexo = Console.ReadLine();

                Console.WriteLine("Salvando cadastro...");

               
            }
            else if (opc == 2)
            {
                Console.WriteLine("EM PROGRAMAÇÃO");
            }
            else if (opc == 3)
            {
                
                Environment.Exit(0);
                //sai da aplicaçao
            }

            Console.ReadLine();



        }
    }
}
