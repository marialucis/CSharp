using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemostraKey
{
    public partial class Frm_DemostracaoKey : Form
    {
        public Frm_DemostracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {


            Txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "Código da tecla: " + ((int)e.KeyCode) + "\r\n");
            Txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");

            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Txt_Input.Text = "";

            Lbl_Upper.Text = "";
            Lbl_Lower.Text = "";
        }
    }
}
