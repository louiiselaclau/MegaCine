using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.viewPagamento
{
    public partial class FrmAlterarPagamentos : Form
    {
        public FrmAlterarPagamentos()
        {
            InitializeComponent();
        }

        private void FrmAlterarPagamentos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Pagamento Alterado com sucesso!");
        }
    }
}
