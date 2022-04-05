using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando o objeto cliente
            Cliente Luci = new Cliente();

            Luci.nome = "Luci";
            Luci.profissao = "Desenvolvedora C#";
            Luci.cpf = "000000000000";


            //instanciando o objeto conta correte
            ContaCorrente conta = new ContaCorrente();
            conta.titular = Luci;
            conta.saldo = 1000;
            conta.agencia = 666;
            conta.numero = 66652381;

            
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine("O saldo de Luci : " +conta.saldo);

            Console.ReadLine();
        }
    }
}
