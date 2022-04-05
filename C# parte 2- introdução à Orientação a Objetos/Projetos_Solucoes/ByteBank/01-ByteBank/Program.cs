using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando e instanciando o objeto
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Luci";
            conta.agencia =666;
            conta.numero =6665238; 

            Console.WriteLine(conta.titular);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Número: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);


            Console.ReadLine();
          
        }
    }
}
