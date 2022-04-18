using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CalculandoNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //acao botao calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando as variaveix

            double nota1 , nota2, nota3, nota4;
            double media ;

             
            //convertendo 
            nota1 = Convert.ToInt32(txtNota1.Text);
            nota2 = Convert.ToInt32(txtNota2.Text);
            nota3 = Convert.ToInt32(txtNota3.Text);
            nota4 = Convert.ToInt32(txtNota4.Text);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            //logica do calculo de notas
            if (media >= 6)
            {
                MessageBox.Show("Aprovado: " + media);
            }
            else if (media >= 5)
            {
                MessageBox.Show("Recuperação: " + media);
            }
            else
            {
                MessageBox.Show("Reprovado: " + media);
            }
        }

        //acao botao limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
        }
    }
}
