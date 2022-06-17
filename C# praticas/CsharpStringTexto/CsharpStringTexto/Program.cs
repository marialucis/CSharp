using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStringTexto
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis

            string nome;
            string sexo;
            string endereco;
            string telefone;
            string email;
            string cpf;



            Console.WriteLine("-----Cadastro de Pessoas-----");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Informe o Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            cpf = (Console.ReadLine());

            Console.WriteLine("Informe o Sexo: ");
            sexo = Console.ReadLine();

            Console.WriteLine("Informe o Endereço: ");
            endereco = Console.ReadLine();

            Console.WriteLine("Informe o Telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Informe o E-mail: ");
            email = Console.ReadLine();

            Console.WriteLine("\n\n");

            Console.WriteLine("Cadastro efetuado com sucesso...\n\n\n\n");


            Console.WriteLine("-----Informações do cadastro-----");
            Console.WriteLine("\n");
            Console.WriteLine("NOME COMPLETO: " +nome);
            Console.WriteLine("CPF: " +cpf);
            Console.WriteLine("SEXO: " +sexo);
            Console.WriteLine("ENDEREÇO: " +endereco);
            Console.WriteLine("TELEFONE: " +telefone);
            Console.WriteLine("E-MAIL: " +email);


            Console.ReadLine();

        }






    }



}
