using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definindo os objetos
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            //dados cliente
            cliente.Nome = "Luci";
            cliente.CPF ="100.000.000-00" ;
            cliente.Profissao = "Desenvolvedora .NET";

            //referenciando 
            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(conta.Saldo);
            

            Console.ReadLine();

        }
    }
}
