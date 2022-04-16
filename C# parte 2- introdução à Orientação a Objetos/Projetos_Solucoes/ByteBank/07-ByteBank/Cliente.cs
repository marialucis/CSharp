using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
   public class Cliente
    {
        //campo privado
        private string _cpf;

        //campos publicos
        public string Nome { get; set; }
        public string CPF
        {

            get {

                return _cpf;
            }

            set {
                //escrevendo a logica da validacao
                _cpf = value;

            }
        }
        public string Profissao { get; set; }


    }
}
