using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            var usuario = Usuario.Text.ToString();
            var senha = Senha.Text.ToString();

            if (usuario == "louise" && senha == "louise")
            {
                this.Hide();
                FrmPrincipal home = new FrmPrincipal();
                home.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos!");
            }


        }


    }
}


