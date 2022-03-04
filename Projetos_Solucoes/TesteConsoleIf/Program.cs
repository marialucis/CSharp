using System;

namespace TesteConsoleIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 40;

            if(idade ==20){ //verifica se a condicao é verdadeira, se sim, executa o if
                Console.WriteLine("É 20");
            } else { //se não, é falsa e executa o else
                Console.WriteLine("Numero diferente de 20");
            }

                Console.WriteLine("Finalizou o programa");

        }
    }
}
