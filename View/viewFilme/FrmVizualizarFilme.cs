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
    public partial class FrmVizualizarFilme : Form
    {
        public FrmVizualizarFilme()
        {
            
            InitializeComponent();
        }

        private void FrmVizualizarFilme_Load(object sender, EventArgs e)
        {
            this.CriaListaDeFilme();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CriaListaDeFilme()
        {
            ListaFilmes listaFilmes = new ListaFilmes();
            this.dataGridView1.Rows.Clear();
           
            foreach (Filme filme in listaFilmes.BuscaFilmesNaLista())
            {
     
                this.dataGridView1.Rows.Add(
                    new Object[]
                    {
                        filme.NomeFilme,
                        filme.Genero,
                        filme.IDFilme
                       
                    });
            }
      
        }
    }
}
