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
using View.viewFilme;

namespace View
{
    public partial class FrmCadFilme : Form
    {
        public FrmCadFilme()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAlterarFilme form = new FrmAlterarFilme();

            form.ShowDialog();

            MessageBox.Show("Filme Alterado com sucesso!");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var nomeF = nomeFilme.Text.ToString();
            var generoF = generoFilme.Text.ToString();
            var idF = idFilme.Text.ToString();
            Filme filme = new Filme();
            filme.IDFilme = Int32.Parse(idF);
            filme.Genero = generoF;
            filme.NomeFilme = nomeF;
            ListaFilmes listaFilme = new ListaFilmes();
            listaFilme.AdicionaFilmeNaLista(filme);



            MessageBox.Show("Filme Salvo com sucesso!");
        }

        private void FrmCadFilme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDeletarFilme form = new FrmDeletarFilme();

            form.ShowDialog();

            MessageBox.Show("Filme Deletado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVizualizarFilme form = new FrmVizualizarFilme();

            form.ShowDialog();

         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }

