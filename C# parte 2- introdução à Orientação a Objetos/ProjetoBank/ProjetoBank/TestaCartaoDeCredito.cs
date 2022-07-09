using System;
using ProjetoBank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBank
{
    class TestaCartaoDeCredito
    {
        static void Main(string[] args)
        {
            //objeto
            CartaoDeCredito cartaoDeCredito = new CartaoDeCredito();
            cartaoDeCredito.numero = 8965;
            cartaoDeCredito.dataDeValidade = "10/05/2025";


            Console.WriteLine("Dados do primeiro cartão");
            Console.WriteLine("Numero: " +cartaoDeCredito.numero);
            Console.WriteLine("Data de validade: " + cartaoDeCredito.dataDeValidade);

            Console.ReadLine();
        }
    }
}
