using System;
using ProjetoBank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBank
{
    class TestaValorPadrao
    {
        static void Main(string[] args)
        {
            //objetos
            Conta conta = new Conta();
            Console.WriteLine("Valores padrao");
            Console.WriteLine("Numero: " +conta.numero);
            Console.WriteLine("Saldo: " +conta.saldo);
            Console.WriteLine("Limite: " +conta.limite);

            Console.ReadLine();
        }
    }
}
