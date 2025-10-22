namespace MeuApp
{
    partial class frmCheckBoxe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkPesssoaJurudica = new CheckBox();
            chkPessoaFisica = new CheckBox();
            pnlPessoaFisica = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            pnlPessoaFisica.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // chkPesssoaJurudica
            // 
            chkPesssoaJurudica.AutoSize = true;
            chkPesssoaJurudica.Location = new Point(29, 181);
            chkPesssoaJurudica.Name = "chkPesssoaJurudica";
            chkPesssoaJurudica.Size = new Size(105, 19);
            chkPesssoaJurudica.TabIndex = 0;
            chkPesssoaJurudica.Text = "Pessoa Juridica";
            chkPesssoaJurudica.UseVisualStyleBackColor = true;
            chkPesssoaJurudica.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkPessoaFisica
            // 
            chkPessoaFisica.AutoSize = true;
            chkPessoaFisica.Location = new Point(29, 76);
            chkPessoaFisica.Name = "chkPessoaFisica";
            chkPessoaFisica.Size = new Size(94, 19);
            chkPessoaFisica.TabIndex = 1;
            chkPessoaFisica.Text = "Pessoa Fisica";
            chkPessoaFisica.UseVisualStyleBackColor = true;
            chkPessoaFisica.CheckedChanged += chkPessoaFisica_CheckedChanged;
            // 
            // pnlPessoaFisica
            // 
            pnlPessoaFisica.Controls.Add(textBox2);
            pnlPessoaFisica.Controls.Add(textBox1);
            pnlPessoaFisica.Controls.Add(label2);
            pnlPessoaFisica.Controls.Add(label1);
            pnlPessoaFisica.Location = new Point(180, 47);
            pnlPessoaFisica.Name = "pnlPessoaFisica";
            pnlPessoaFisica.Size = new Size(200, 67);
            pnlPessoaFisica.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 46);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "CPF :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(180, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 74);
            panel2.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(65, 44);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 13);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 42);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 1;
            label4.Text = "CNPJ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 13);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Nome :";
            // 
            // frmCheckBoxe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 248);
            Controls.Add(panel2);
            Controls.Add(pnlPessoaFisica);
            Controls.Add(chkPessoaFisica);
            Controls.Add(chkPesssoaJurudica);
            Name = "frmCheckBoxe";
            Text = "CheckBoxe";
            pnlPessoaFisica.ResumeLayout(false);
            pnlPessoaFisica.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPesssoaJurudica;
        private CheckBox chkPessoaFisica;
        private Panel pnlPessoaFisica;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
    }
}