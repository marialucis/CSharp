using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Notas
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;
        
        
        public Aluno aluno;

        //metodo para caluclar media
        public bool CalcMedia(double media)
        {
            media = (nota1 + nota2 + nota3 + nota4) / 4; 

            if (media >= 6)
            {
                Console.WriteLine("Aprovado");
                return true;
            }
            else if (media <= 5)
            {
                Console.WriteLine("Recuperação");
                return false;
            }


            else
            {
                Console.WriteLine("Reprovado");
                return false;
            }
           


        }

    }
}
