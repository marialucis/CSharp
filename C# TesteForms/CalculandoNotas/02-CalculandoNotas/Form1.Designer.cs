namespace _02_CalculandoNotas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.lblnota4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de Notas";
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.Location = new System.Drawing.Point(23, 110);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(93, 13);
            this.lblnota1.TabIndex = 1;
            this.lblnota1.Text = "Digite sua nota 1: ";
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.Location = new System.Drawing.Point(23, 146);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(93, 13);
            this.lblnota2.TabIndex = 2;
            this.lblnota2.Text = "Digite sua nota 2: ";
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.Location = new System.Drawing.Point(23, 183);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(93, 13);
            this.lblnota3.TabIndex = 3;
            this.lblnota3.Text = "Digite sua nota 3: ";
            // 
            // lblnota4
            // 
            this.lblnota4.AutoSize = true;
            this.lblnota4.Location = new System.Drawing.Point(23, 217);
            this.lblnota4.Name = "lblnota4";
            this.lblnota4.Size = new System.Drawing.Size(93, 13);
            this.lblnota4.TabIndex = 4;
            this.lblnota4.Text = "Digite sua nota 4: ";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(140, 107);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(140, 143);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(140, 180);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 7;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(140, 214);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(53, 319);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(177, 319);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblnota4);
            this.Controls.Add(this.lblnota3);
            this.Controls.Add(this.lblnota2);
            this.Controls.Add(this.lblnota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.Label lblnota4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}

