using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class frm_Teste : Form
    {
        public frm_Teste()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fecha aplicacao

        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_ConteudoLabel.Text;

        }

        
    }
}
