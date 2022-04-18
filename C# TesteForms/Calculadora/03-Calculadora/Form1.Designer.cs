namespace _03_Calculadora
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
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.Location = new System.Drawing.Point(200, 19);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(172, 20);
            this.lblCalculadora.TabIndex = 0;
            this.lblCalculadora.Text = "Calculadora Simples";
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero1.Location = new System.Drawing.Point(12, 111);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(120, 13);
            this.lblnumero1.TabIndex = 1;
            this.lblnumero1.Text = "Digite um numero 1:";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero2.Location = new System.Drawing.Point(12, 153);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(124, 13);
            this.lblnumero2.TabIndex = 2;
            this.lblnumero2.Text = "Digite um numero 2: ";
            // 
            // btnsoma
            // 
            this.btnsoma.BackColor = System.Drawing.SystemColors.Window;
            this.btnsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoma.Location = new System.Drawing.Point(450, 101);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(75, 23);
            this.btnsoma.TabIndex = 3;
            this.btnsoma.Text = "Somar";
            this.btnsoma.UseVisualStyleBackColor = false;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsubtrair
            // 
            this.btnsubtrair.BackColor = System.Drawing.SystemColors.Window;
            this.btnsubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtrair.Location = new System.Drawing.Point(450, 148);
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnsubtrair.TabIndex = 4;
            this.btnsubtrair.Text = "Subtrair";
            this.btnsubtrair.UseVisualStyleBackColor = false;
            this.btnsubtrair.Click += new System.EventHandler(this.btnsubtrair_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.SystemColors.Window;
            this.btnmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmulti.Location = new System.Drawing.Point(450, 196);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(75, 23);
            this.btnmulti.TabIndex = 5;
            this.btnmulti.Text = "Multiplicar";
            this.btnmulti.UseVisualStyleBackColor = false;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.SystemColors.Window;
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(450, 245);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 6;
            this.btndiv.Text = "Divisão";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(225, 351);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(113, 23);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.lblCalculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnlimpar;
    }
}

