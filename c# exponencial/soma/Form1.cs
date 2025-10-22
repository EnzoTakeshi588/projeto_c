namespace soma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCaucular_Click(object sender, EventArgs e)
        {
            double Nota1, Nota2;

            Nota1 = double.Parse(txtNota1.Text);
            Nota2 = double.Parse(txtNota2.Text);
     

            double MediaFinal = (Nota1 + Nota2) /2;

            txtMediaFinal.Text = MediaFinal.ToString();

            if (lblRecuperacao.Text == "")
            {
                if (MediaFinal >= 7)
                {
                    lblRecuperacao.Text = "Aprovado";
                    lblRecuperacao.ForeColor = Color.Blue;
                }
                else
                {
                    lblRecuperacao.Text = "Reprovado";
                    lblRecuperacao.ForeColor = Color.Red;
                }
            }
        }
    }
}