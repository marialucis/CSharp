using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando o objeto
            ContaCorrente conta = new ContaCorrente();
            conta.saldo = 200;
            Console.WriteLine(conta.saldo);
            

            conta.saldo += 100;
            Console.WriteLine(conta.saldo);
            

            //instanciando uma nova conta
            ContaCorrente novaconta = new ContaCorrente();
            novaconta.saldo = 50;

            Console.WriteLine("Primeira conta tem " +conta.saldo);
            Console.WriteLine("Segunda conta tem " +novaconta.saldo);

            Console.ReadLine();


        }
    }
}
