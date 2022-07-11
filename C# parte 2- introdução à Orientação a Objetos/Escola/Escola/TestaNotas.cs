using System;
using Escola;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class TestaNotas
    {
        static void Main()
        {

            //criando objeto notaA1
            Notas notasA1 = new Notas();
            notasA1.nota1 = 7;
            notasA1.nota2 = 5;
            notasA1.nota3 = 6;
            notasA1.nota4 = 8;

         
            ///objeto aluno
            Aluno aluno1= new Aluno();
            aluno1.nome = "MariaTeste ";

            Console.WriteLine("-------Dados notas do primeiro aluno-------");
            Console.WriteLine("Nome: " + aluno1.nome);
            Console.WriteLine("Nota 1: " +notasA1.nota1);
            Console.WriteLine("Nota 2: " +notasA1.nota2);
            Console.WriteLine("Nota 3: " +notasA1.nota3);
            Console.WriteLine("Nota 4: " +notasA1.nota4);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Calculando media do primeiro aluno...");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Aluno: " +aluno1.nome);
            notasA1.CalcMedia(notasA1.nota1 + notasA1.nota2 + notasA1.nota3 + notasA1.nota4 / 4); //metodo calcula notas passando os parametros

            Console.WriteLine(Environment.NewLine);

            //criando objeto
            Notas notasA2 = new Notas();
            notasA2.nota1 = 1;
            notasA2.nota2 = 3;
            notasA2.nota3 = 1;
            notasA2.nota4 = 8;


            //objeto aluno2
            Aluno aluno2 = new Aluno();
            aluno2.nome = "TesteLux";


            Console.WriteLine("-------Dados notas do segundo aluno-------");
            Console.WriteLine("Nome: " + aluno2.nome);
            Console.WriteLine("Nota 1: " + notasA2.nota1);
            Console.WriteLine("Nota 2: " + notasA2.nota2);
            Console.WriteLine("Nota 3: " + notasA2.nota3);
            Console.WriteLine("Nota 4: " + notasA2.nota4);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Calculando media do segundo aluno...");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Aluno: " + aluno2.nome);
            notasA2.CalcMedia(notasA2.nota1 + notasA2.nota2 + notasA2.nota3 + notasA2.nota4 / 4); //metodo calcula notas passando os parametros




            Console.ReadLine();



        }
    }
}
