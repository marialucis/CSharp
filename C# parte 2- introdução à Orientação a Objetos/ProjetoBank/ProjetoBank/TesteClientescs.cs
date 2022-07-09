using System;
using ProjetoBank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBank
{
    class TesteClientescs
    {
        static void Main(string[] args)
        {
            //criando objeto
            Clientes clientes1 = new Clientes();
            clientes1.codigo = 10105;
            clientes1.nome = "Teste";

            Clientes clientes2 = new Clientes();
            clientes2.codigo = 10106;
            clientes2.nome = "Teste2";

            Console.WriteLine("Dados do primeiro cliente: ");
            Console.WriteLine("Codigo: " + clientes1.codigo);
            Console.WriteLine("Nome: " + clientes1.nome);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Dados do segundo cliente: ");
            Console.WriteLine("Codigo: " + clientes2.codigo);
            Console.WriteLine("Nome: " + clientes2.nome);

            Console.ReadLine();
        }
       
        

    }
}
