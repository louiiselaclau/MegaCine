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
using View.viewPessoa;

namespace View
{
    public partial class FrmCadPessoa : Form
    {
        public FrmCadPessoa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Nascimento_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadPessoa_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmAlterarPessoa form = new FrmAlterarPessoa();

            form.ShowDialog();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.ShowDialog();

           
        }

        private void button2_Click(object sender, EventArgs e)
        { 
                    MessageBox.Show("Cliente Salvo com sucesso!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmVizualizarPessoas form = new FrmVizualizarPessoas();

            form.ShowDialog();


            


        }
    }
}
