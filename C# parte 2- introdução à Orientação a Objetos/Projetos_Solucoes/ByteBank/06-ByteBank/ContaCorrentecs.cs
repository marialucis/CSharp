//using _05_ByteBank;


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private Cliente titular;
        private int agencia;
        private int numero;
        private double saldo = 100;


        //metodo para definir o saldo
        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }

            this.saldo = saldo;

        }


        //metodo para obter o saldo
        public double GetSaldo()
        {
            return saldo;
        }


        //declarando um funcao/metodo sacar
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        // declarando o metodo depositar onde void é um metodo sem retorno
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        //declarando o metodo transferir
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

