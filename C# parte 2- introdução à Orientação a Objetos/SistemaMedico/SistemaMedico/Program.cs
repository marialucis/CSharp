using System;
using SistemaMedico;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------Sistema Medico---------- \n");

            //criando objeto
            Pessoa pessoa = new Pessoa();
            pessoa.id = 1;
            pessoa.nome = "testep";
            pessoa.idade = 24;
            pessoa.peso = 60.25;
            pessoa.altura = 1.52;

            //exbindo informações
            Console.WriteLine("Dados Paciente \n\n" +
               "ID: " + pessoa.id + "\n" +
               "Nome: " + pessoa.nome + "\n" +
               "Idade: " + pessoa.idade + "\n" +
               "Peso: " + pessoa.peso + "\n" +
               "Altura: " + pessoa.altura );


            Console.ReadLine();
        }
    }
}
