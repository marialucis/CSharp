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

            //criando objeto
            Notas notas = new Notas();
            notas.nota1 = 7;
            notas.nota2 = 2;
            notas.nota3 = 3;
            notas.nota4 = 8;

         
            ///objeto aluno
            Aluno aluno1= new Aluno();
            aluno1.nome = "MariaTeste \n";

            Console.WriteLine("-------Dados notas Aluno-------");
            Console.WriteLine("Nome: " +aluno1.nome);
            Console.WriteLine("Nota 1: " +notas.nota1);
            Console.WriteLine("Nota 2: " +notas.nota2);
            Console.WriteLine("Nota 3: " +notas.nota3);
            Console.WriteLine("Nota 4: " +notas.nota4);

            Console.WriteLine("\nCalculando media...");
            Console.WriteLine(notas.CalcMedia(notas.nota1 + notas.nota2 + notas.nota3 + notas.nota4 / 4)); //metodo calcula passando os parametros
            Console.ReadLine();



        }
    }
}
