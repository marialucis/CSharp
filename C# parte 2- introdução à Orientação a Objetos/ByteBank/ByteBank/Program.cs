using System;
using ByteBank; //importando o namespace da classe ContaCorrente já que vamos ultila-la aqui nessa classe principal 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao seu banco, ByteBank!");
            Console.WriteLine(Environment.NewLine); // também pula linha

            //Console.WriteLine("\n"); //pulalinha

            /*variaveis para a conta

            string titular = "Luci Sousa";
            string conta = "10123-x";
            int numero_agencia = 23;
            string nome_agencia = "Agencia Central";
            double saldo = 93.50;
            */
            var dataSessao = DateTime.Now; //criei a variavel dataSessao e atribui a propriedade/funcao DataTime.Now pegando a data e hora atual do pc

            //já que criei a classe ContaCorrete e defini seus atributos, vamos instanciar o objeto a partir dessa classe
            ContaCorrente conta1 = new ContaCorrente(); //instanciei o objeto conta e acessei as referencias dos atributos/propriedades
            conta1.titular = "Luci Sousa";
            conta1.conta = "101016-x";
            conta1.saldo = 100.50;

            //exibindo resultados conta1
            Console.WriteLine("Ola, " + conta1.titular + "!" + " Seu Ultumo Acesso: " + dataSessao + "\n");  //DateTime.Now retorna a data e hora atual
            Console.WriteLine("Conta : " + conta1.conta);
            Console.WriteLine("Saldo : " + conta1.saldo);
            Console.WriteLine("\n");


            //criando/instanciando um novo objeto conta2
            ContaCorrente conta2 = new ContaCorrente();
            conta2.conta = "101017-x";
            conta2.titular = " teste conta";
            conta2.saldo = 15.50;

            ////exibindo resultado connta2

            Console.WriteLine("ola, " + conta2.titular + "!" + " seu ultumo acesso: " + dataSessao + "\n");  //datetime.now retorna a data e hora atual
            Console.WriteLine("conta : " + conta2.conta);
            Console.WriteLine("saldo : " + conta2.saldo);
            Console.WriteLine("\n");


            ////criando/instanciando um novo objeto conta3 para testar valores padroes
            //contacorrente conta3 = new contacorrente();
            //console.writeline($"titular da conta: {conta3.titular}");
            //console.writeline($"número da conta: {conta3.conta}");
            //// console.writeline($"agência: {conta.agencia}");
            //console.writeline($"saldo r$ {string.format("{0:0.00}", conta3.saldo)}");

            //exibindo saque da conta
            Console.WriteLine("Saldo Inicial: " +conta1.saldo + "\n");
            Console.WriteLine("Iniciando saque..." + "\n");

            bool sque = conta1.Sacar(25);
            Console.WriteLine("Valor sacado?: " + sque + "\n");

            //exibindo deposito
            Console.WriteLine("Saldo pós saque: " + conta1.saldo + "\n");
            conta1.Depositar(600);
            Console.WriteLine("Iniciando deposito..." + "\n");
            Console.WriteLine("Valor atual com o deposito: " + conta1.saldo + "\n");

            //realizando transferencia
            Console.WriteLine("Iniciando transferencia..." + "\n");
            Console.WriteLine("Valor pré - transferencia conta 1: " + conta1.saldo);
            Console.WriteLine("Valor pré - transferencia conta 2: " + conta2.saldo);
            conta1.Transferir(300, conta2);
            Console.WriteLine("Valor pós - transferencia conta 1: " + conta1.saldo);
            Console.WriteLine("Valor pós - transferencia conta 2: " + conta2.saldo + "\n");

            //dados do cliente
            //instanciando objeto
            Cliente cliente = new Cliente();
            cliente.nome = "Lux";
            cliente.cpf = "11942482418";
            cliente.profissao = "Programadora C3 ";

            Console.WriteLine(cliente.nome);
            Console.WriteLine();

            
            Console.ReadKey();



        }
    }
}
