using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TesteForms
{
    public partial class TestandoForm : Form
    {
        public TestandoForm()
        {
            InitializeComponent();
        }

        //trecho de codigo do botao    
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá,Mundo");
        }
    }
}
