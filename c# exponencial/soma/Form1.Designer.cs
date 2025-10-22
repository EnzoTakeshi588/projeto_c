namespace soma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            btnCaucular = new Button();
            txtMediaFinal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLimpa = new Button();
            lblRecuperacao = new Label();
            SuspendLayout();
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(36, 123);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 0;
            txtNota1.TextChanged += textBox1_TextChanged;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(195, 123);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 1;
            // 
            // btnCaucular
            // 
            btnCaucular.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCaucular.Location = new Point(70, 303);
            btnCaucular.Name = "btnCaucular";
            btnCaucular.Size = new Size(89, 63);
            btnCaucular.TabIndex = 2;
            btnCaucular.Text = "Caucular";
            btnCaucular.UseVisualStyleBackColor = true;
            btnCaucular.Click += btnCaucular_Click;
            // 
            // txtMediaFinal
            // 
            txtMediaFinal.Enabled = false;
            txtMediaFinal.Location = new Point(116, 213);
            txtMediaFinal.Name = "txtMediaFinal";
            txtMediaFinal.Size = new Size(100, 23);
            txtMediaFinal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 99);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 5;
            label1.Text = "Primeiro Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(181, 99);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 6;
            label2.Text = "Segundo Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 215);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 7;
            label3.Text = "Media:";
            // 
            // btnLimpa
            // 
            btnLimpa.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpa.Location = new Point(181, 303);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(90, 63);
            btnLimpa.TabIndex = 2;
            btnLimpa.Text = "Limpa";
            btnLimpa.UseVisualStyleBackColor = true;
            btnLimpa.Click += btnCaucular_Click;
            // 
            // lblRecuperacao
            // 
            lblRecuperacao.AutoSize = true;
            lblRecuperacao.Location = new Point(136, 263);
            lblRecuperacao.Name = "lblRecuperacao";
            lblRecuperacao.Size = new Size(0, 15);
            lblRecuperacao.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 380);
            Controls.Add(lblRecuperacao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMediaFinal);
            Controls.Add(btnLimpa);
            Controls.Add(btnCaucular);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota1;
        private TextBox txtNota2;
        private Button btnCaucular;
        private TextBox txtMediaFinal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLimpa;
        private Label lblRecuperacao;
    }
}
