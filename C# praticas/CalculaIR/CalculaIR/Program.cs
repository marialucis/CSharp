/* Aplicação que vai verificar o valor do IR a deduzir no salario;
 
    Desenvolvedor(a): Luci Sousa
                      19/06/2022  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIR
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
             * De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
             * De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636;
            */

            double salario;

            Console.WriteLine("---------------------------");
            Console.WriteLine("---------Calcula IR--------");
            Console.WriteLine("---------------------------");


            Console.WriteLine("Informe o seu salario: ");
            salario = double.Parse(Console.ReadLine());


            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("O IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
                
            }
            else if (salario >= 2800.01 && salario <= 3751.0 )
            {
                Console.WriteLine("O  IR é de 15% e pode deduzir R$ 350");
            }


            else if (salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("O IR é de 22.5% e pode deduzir R$ 636");
            }

           Console.ReadLine();
        }

    }
    
}
