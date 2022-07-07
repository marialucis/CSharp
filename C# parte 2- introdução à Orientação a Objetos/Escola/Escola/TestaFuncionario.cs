using System;
using Escola;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class TestaFuncionario
    {
        static void Main()
        {

            //CRIANDO O OBJETO
            Funcionario funcionario = new Funcionario();
            funcionario.nome = "Isabel";
            funcionario.profissao = "Professor(a)";
            funcionario.salario = 3250.50;


            //exibindo ojetos
            Console.WriteLine("Nome: " + funcionario.nome);
            Console.WriteLine("Nome: " + funcionario.profissao);
            Console.WriteLine("Salario: " + funcionario.salario);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Verificando salario para receber o reajuste...");
            funcionario.AumentoSalario(funcionario.salario); //metodo

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exibibdo dados do Funcionario...");
            funcionario.ExibeDados(); //metodo
            Console.ReadLine();

        }
    }
}
