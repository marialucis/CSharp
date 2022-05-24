using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            

            int mes = 0;

            Console.WriteLine("Digite um mes do primeiro semestre");
            mes = int.Parse(Console.ReadLine());//recebdo do teclado

            switch (mes)

            {
                case 1: Console.WriteLine("Janeiro");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                default:Console.WriteLine("Apenas o primeiro Semestre");
                    break;
            }
                Console.ReadLine();
        }
        
        
    }
}
