using System;
using ProjetoBank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBank
{
    class TestaConta
    {
        static void Main(string[] args)
        {


            //objetos conta
            Conta conta1 = new Conta();
            conta1.numero = 1234;
            conta1.saldo = 100.50;
            conta1.limite = 500;

            //objeto agencia
            Agencia agencia = new Agencia();
            agencia.numero = 1015;

            //objeto cliente
            Clientes cliente = new Clientes();
            cliente.nome = "Maria";

            
            Console.WriteLine("Dados da primeira conta");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Nome: " + cliente.nome);
            Console.WriteLine("Agencia: " + agencia.numero);
            Console.WriteLine("Numero: " +conta1.numero);
            Console.WriteLine("Saldo: " + conta1.saldo);
            Console.WriteLine("Limite: " + conta1.limite);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Solicitando Deposito...");
            Console.WriteLine("Saldo Anterior: " + conta1.saldo);
            conta1.Deposita(100);//metodo
            Console.WriteLine("Saldo Atualizado: " +conta1.saldo);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Solicitando saque...");
            Console.WriteLine("Saldo disponivel para saque: " +conta1.saldo);
            conta1.Saque(50); //metodo
            Console.WriteLine("Saldo restante: " +conta1.saldo);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Imprimindo Extrato...");
            conta1.ImprmeExtrato(); //metodo

            Console.ReadLine();
        }
    }
}
