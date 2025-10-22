namespace MeuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Olá Mundo";
            lblMensagem.ForeColor = Color.Blue;
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {  
            frmCheckBoxe Propriedades = new frmCheckBoxe();
            Propriedades.ShowDialog();
        }
    }
}
