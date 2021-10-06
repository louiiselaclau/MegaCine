using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadFilme form = new FrmCadFilme();

            form.ShowDialog();

            MessageBox.Show("Filme Cadastrado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();

            form.ShowDialog();

            MessageBox.Show("Cliente Cadastrado com sucesso!");
        }

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Pagamentos form = new Pagamentos();

            form.ShowDialog();

            MessageBox.Show("Pagamento efetuado com sucesso!");
        }
    }
}
