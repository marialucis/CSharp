using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Digite um número para realizar a Tabuada");
            num = int.Parse( Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num+ " * " +i+ " = " + num * i);
             
            }
            Console.ReadLine();

        }
    }
}
