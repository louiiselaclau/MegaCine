using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.viewPagamento;

namespace View
{
    public partial class Pagamentos : Form
    {
        public Pagamentos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAlterarPagamentos form = new FrmAlterarPagamentos();

            form.ShowDialog();

            MessageBox.Show("Pagamento Alterado com sucesso!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVizualizarPagamento form = new FrmVizualizarPagamento();

            form.ShowDialog();

            MessageBox.Show("Pagamento deletado com sucesso!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();

            form.ShowDialog();

            MessageBox.Show("Pagamento deletado com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento Salvo com sucesso!");
        }
    }
}
