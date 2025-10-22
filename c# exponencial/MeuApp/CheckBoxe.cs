using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuApp
{
    public partial class frmCheckBoxe : Form
    {
        public frmCheckBoxe()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPessoaFisica.Checked == true)
            {
                pnlPessoaFisica.Visible = true;
            }else
            {
}
