using System;
using Escola;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class TestaAluno
    {
        private static void Main(string[] args)
        {
            //criando objeto aluno
            Aluno aluno1 = new Aluno();
            aluno1.matricula = 0001;
            aluno1.nome = "MariaTeste";
            aluno1.rg = "9885786";
            aluno1.data.ToString("10/10/1998");

            //cirando objeto aluno2
            Aluno aluno2 = new Aluno();
            aluno2.matricula = 0002;
            aluno2.nome = "MariaTeste2";
            aluno2.rg = "9875756";
            aluno2.data.ToString("05/04/1998");

            Console.WriteLine("-------Dados do Aluno-------");
            Console.WriteLine("Nome: " + aluno1.nome);
            Console.WriteLine("Matricula: " + aluno1.matricula);
            Console.WriteLine("RG: " +aluno1.rg);
            Console.WriteLine("Data Nascimento: " + aluno1.data.ToString("10/10/1998"));

            Console.WriteLine(Environment.NewLine);
          
            Console.WriteLine("Nome: " + aluno2.nome);
            Console.WriteLine("Matricula: " + aluno2.matricula);
            Console.WriteLine("RG: " + aluno2.rg);
            Console.WriteLine("Data Nascimento: " + aluno2.data.ToString("05/04/1998"));

            Console.ReadLine();

        }
    }
}
