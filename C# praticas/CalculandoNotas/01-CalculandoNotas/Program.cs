using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CalculandoNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declando variaveis
            string nome;
            double nota1, nota2, nota3, nota4;
            double media;

            Console.WriteLine("************************");
            Console.WriteLine("****Calculando Notas****");
            Console.WriteLine("************************\n");

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Infome sua primeira nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Infome sua segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Infome sua terceira nota: ");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Infome sua quarta nota: ");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 6) //SE media maior ou igual a 6 entra no primeiro IF
            {
                Console.WriteLine(nome + " Aprovada, sua nota é: " + media);

            }

            else if (media >= 5) //SENAO SE media maior ou igual a 5 entra nessa condição
            {
                Console.WriteLine(nome + " Recuperação Final, sua nota é:  " + media);
            }

            else //SENAO atender nenhuma das condições, entra no else e está reprovado
            {
                Console.WriteLine(nome + " Reprovada, sua nota é:  " + media);
            }

            Console.ReadLine();
        }
    }
}
