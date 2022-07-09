using System;
using ProjetoBank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBank
{
    class TestaAgencia
    {
        static void Main(string[] args)
        {
            //objetos
            Agencia agencia = new Agencia();
            agencia.numero = 1159;

            Agencia agencia2 = new Agencia();
            agencia2.numero = 1160;

            Console.WriteLine("Dados da primeira Agencia");
            Console.WriteLine("Numero Agencia: " + agencia.numero);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Dados da segunda Agencia");
            Console.WriteLine("Numero Agencia: " + agencia2.numero);

            Console.ReadLine();

        }
    }
}
