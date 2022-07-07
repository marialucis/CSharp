using System;
using Escola;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class TestaTurma
    {
        static void Main()
        {

            //criando objeto turma
            Turma turma1 = new Turma();
            turma1.periodo = "Primeiro semestre";
            turma1.serie = "1 Ano medio";

            //criando objeto aluno , mas antes adicionei o atributo na classe classe
            Aluno aluno = new Aluno();
            aluno.matricula = 001;
            aluno.nome = "Teste";

            Aluno aluno2 = new Aluno();
            aluno2.matricula = 002;
            aluno2.nome = "Teste2";


            //criando o objeto funcionario/professor(a)
            Funcionario funcionario = new Funcionario();
            funcionario.profissao = "Professor(a)";
            funcionario.nome = "ProfTeste";

            Console.WriteLine("-------Dados da Turma-------\n");
            Console.WriteLine("Professor(a): " + funcionario.nome);
            Console.WriteLine("Periodo: " + turma1.periodo);
            Console.WriteLine("Serie: " + turma1.serie);
            Console.WriteLine( "Nome aluno: " + aluno.nome + " / " + "Matricula: " + aluno.matricula);
            Console.WriteLine("Nome aluno: " + aluno2.nome + " / " + "Matricula: " + aluno2.matricula);

            Console.ReadLine();
        }
        
        
    }
}
