using System;
using Escola;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Funcionario
    {
        //atributos
        public string nome;
        public double salario;
        public string profissao;



        //metodos
        public bool AumentoSalario(double reajuste)
        {

            if (this.salario >= 3000.00)
            {
                //recebe reajuste de 25%
                reajuste = (this.salario * 25) / 100;
                Console.WriteLine("Salario com reajuste: " + (this.salario + reajuste));
                return true;
            }
            else if (this.salario >= 2500.00)
            {
                //reeajuste de 15%
                reajuste = (this.salario * 15) / 100;
                Console.WriteLine("Salario com reajuste: " + (this.salario + reajuste));
                return true;
            }
            else
            {
                Console.WriteLine("Não há reajuste");
                return false;
            }
        }


        public void ExibeDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Profissao: " + this.profissao);
            Console.WriteLine("Salario Anterior: " +this.salario);
            Console.WriteLine(AumentoSalario(salario));
        }
    }
}
