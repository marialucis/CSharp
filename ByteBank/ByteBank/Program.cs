using System;
using ByteBank; //importando o namespace da classe ContaCorrente já que vamos ultila-la aqui nessa classe
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


            //já que criei a classe ContaCorrete e defini seus atributos, vamos instanciar o objeto a partir dessa classe
            ContaCorrente conta1 = new ContaCorrente(); //instanciei o objeto conta e acessei as referencias dos atributos/propriedades
            conta1.titular = "Luci Sousa";
            conta1.saldo = 100.50;

            var dataSessao = DateTime.Now; //criei a variavel dataSessao e atribui a propriedade/funcao DataTime.Now pegando a data e hora atual do pc

            Console.WriteLine("Ola, "  + conta1.titular + "!" + " Seu Ultumo Acesso: " + dataSessao  + "\n");  //DateTime.Now retorna a data e hora atual
            Console.WriteLine("Saldo : " +conta1.saldo);

            Console.ReadLine();

        }
    }
}
