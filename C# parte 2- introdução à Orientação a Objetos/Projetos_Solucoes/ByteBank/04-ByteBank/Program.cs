using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando o objeto
            ContaCorrente contaLuci = new ContaCorrente();

            contaLuci.titular = "Luci";
            Console.WriteLine(contaLuci.saldo);
            //sacar
            bool resultadoSaque = contaLuci.Sacar(50);
            
            Console.WriteLine(contaLuci.saldo);
            Console.WriteLine(resultadoSaque);

            //depositar 
            contaLuci.Depositar(1000);
            Console.WriteLine(contaLuci.saldo);

            //transferir
            //criando nova instancia
            ContaCorrente contaLeticia = new ContaCorrente();
            contaLeticia.titular = "Leticia";

            Console.WriteLine("Saldo da Luci: " + contaLuci.saldo);
            Console.WriteLine("Saldo de Leticia: " + contaLeticia.saldo);

            //transferencia
            bool resultadoTransferencia = contaLuci.Transferir(300, contaLeticia);
            Console.WriteLine("Saldo da Luci " +contaLuci.saldo);
            Console.WriteLine("Saldo de Leticia " +contaLeticia.saldo);

            Console.WriteLine("Resultado transferencia: " +resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
