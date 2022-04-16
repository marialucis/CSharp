//using _05_ByteBank;


namespace _07_ByteBank
{
    public class ContaCorrente
    {
        //definindo os campos/variaveis
        private Cliente _titular;
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;


        //propriedade get e set cliente
        public Cliente Titular { get; set; }

        //propriedades/metodo get e set saldo (get =obtem, set = definir )
        public double Saldo
        {
            get
            {
                return _saldo;
    
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        


        //declarando um funcao/metodo sacar
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        // declarando o metodo depositar onde void é um metodo sem retorno
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        //declarando o metodo transferir
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

