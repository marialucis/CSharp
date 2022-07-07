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
        static void main()
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

            Console.ReadKey();

        }
    }
}
