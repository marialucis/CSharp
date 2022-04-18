using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //acao botao somar
        private void btnsoma_Click(object sender, EventArgs e)
        {
            //declarando variaveis
            int num1, num2;
            int soma;
            //convertendo
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            soma = (num1 + num2);
            MessageBox.Show("O resultado é: " +soma);
        }
        //acao botao subtrair
        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            //declarando variaveis
            int num1, num2;
            int sub;
            //convertendo
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            sub = (num1 - num2);
            MessageBox.Show("O resultado é: " + sub);
        }
        //acao botao multiplicar
        private void btnmulti_Click(object sender, EventArgs e)
        {
            //declarando variaveis
            int num1, num2;
            int mult;
            //convertendo
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            mult = (num1 * num2);
            MessageBox.Show("O resultado é: " + mult);
        }
        //acao botao dividir
        private void btndiv_Click(object sender, EventArgs e)
        {
            //declarando variaveis
            int num1, num2;
            int div;
            //convertendo
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            div = (num1 / num2);
            MessageBox.Show("O resultado é: " + div);
        }
        //acao botao limpar
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
