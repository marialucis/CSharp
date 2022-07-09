using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBank
{
    class Conta
    {
        //atributos
        public int numero;
        public double saldo;
        public double limite = 100; //inicializando a variavel com valor padrao


        public Agencia Agencia; //adicionado atributo da classe agencia para usar os objtos na classe conta


        //metodos
        public void Deposita(double valor)
        {
            this.saldo = saldo + valor;
        }


        public void Saque(double valor)
        {

            this.saldo = saldo - valor;
        }


        public void ImprmeExtrato()
        {
            Console.WriteLine("Saldo: " + this.saldo);
        }


        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }


    }
}
