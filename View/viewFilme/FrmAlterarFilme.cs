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
    public partial class FrmAlterarFilme : Form
    {
        public FrmAlterarFilme()
        {
            InitializeComponent();
        }

        private void FrmAlterarFilme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nomeF = nomeFilme.Text.ToString();
            var generoF = generoFilme.Text.ToString();
            var idF = idFilme.Text.ToString();
            Filme filme = new Filme();
            filme.IDFilme = Int32.Parse(idF);
            filme.Genero = generoF;
            filme.NomeFilme = nomeF;
            ListaFilmes listaFilme = new ListaFilmes();
            listaFilme.AlteraFilmesNaLista(filme);
            MessageBox.Show("Filme Alterado com sucesso!");
        }
    }
}
