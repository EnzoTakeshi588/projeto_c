namespace MeuApp
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
            lblMensagem = new Label();
            button1 = new Button();
            lbl = new Label();
            btnCheckBox = new Button();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(121, 132);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(91, 200);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 1;
            button1.Text = "Mostar Mensgame";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(127, 132);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 15);
            lbl.TabIndex = 2;
            // 
            // btnCheckBox
            // 
            btnCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckBox.Location = new Point(12, 12);
            btnCheckBox.Name = "btnCheckBox";
            btnCheckBox.Size = new Size(79, 51);
            btnCheckBox.TabIndex = 3;
            btnCheckBox.Text = "CheckBoxe";
            btnCheckBox.UseVisualStyleBackColor = true;
            btnCheckBox.Click += btnCheckBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 251);
            Controls.Add(btnCheckBox);
            Controls.Add(lbl);
            Controls.Add(button1);
            Controls.Add(lblMensagem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagem;
        private Button button1;
        private Label lbl;
        private Button btnCheckBox;
    }
}
