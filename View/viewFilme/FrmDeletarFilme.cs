using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.viewFilme
{
    public partial class FrmDeletarFilme : Form
    {
        public FrmDeletarFilme()
        {
            InitializeComponent();
        }

        private void FrmDeletarFilme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var idF = idFilme.Text.ToString();
            Filme filme = new Filme();
            filme.IDFilme = Int32.Parse(idF);
           
            ListaFilmes listaFilme = new ListaFilmes();
            listaFilme.RemoveFilmesNaLista(filme.IDFilme);
            MessageBox.Show("Filme Deletado com sucesso!");
        }
    }
}
