using System;
using EstoqueP;//importando a classe 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueSupermercado
{
    class Program //classe principal que contem o metodo Main
    {
        static void Main(string[] args)
        {
            //variavel
            string operadorEstq = "Admin";
            var dataSession = DateTime.Now; //variavel recebendo a hora e data atual do pc 

            Console.WriteLine("Bem vindo," +operadorEstq + "!" + " Sessão: " +dataSession + "\n") ;

            //instanciando o objeto da classe EstoqueProduto 
            EstoqueProduto estoqueproduto = new EstoqueProduto();
            estoqueproduto.nome = "ProdTest ";
            estoqueproduto.fabricante = "FabTeste";
            estoqueproduto.codBarras = "100010553000000000544";
            estoqueproduto.valorUni = 50.00;
            estoqueproduto.valorComp =  35.50;

            //exibindo saida 
            Console.WriteLine("------------Estoque Produtos------------ \n");
            Console.WriteLine(
                 "Nome: " + estoqueproduto.nome + "\n" 
                + "Fabricante: " +  estoqueproduto.fabricante + "\n"  
                + "Codigo de Barras: " + estoqueproduto.codBarras + "\n"
                + "Valor unitario: " + estoqueproduto.valorUni + "\n"
                + "Valor compra: " + estoqueproduto.valorComp);
            Console.ReadLine();
        }
    }
}
