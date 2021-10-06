using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListaFilmes
    {
        public static List<Filme> filmes = new List<Filme>();

        public void AdicionaFilmeNaLista(Filme filme)
        {
            filmes.Add(filme);
        }

        public List<Filme> BuscaFilmesNaLista()
        {
            return filmes;
        }

        public void AlteraFilmesNaLista(Filme filmeNovo)
        {
            foreach (Filme filmeDaLista in filmes)
            {
                if(filmeDaLista.IDFilme == filmeNovo.IDFilme)
                {
                    filmeDaLista.IDFilme = filmeNovo.IDFilme;            
                    filmeDaLista.Genero = filmeNovo.Genero;            
                    filmeDaLista.NomeFilme = filmeNovo.NomeFilme;            
                }
            }    
        }

        public void RemoveFilmesNaLista(Int32 idFilmeRemove)
        {
            try
            {

            foreach (Filme filmeDaLista in filmes)
            {
                if (filmeDaLista.IDFilme == idFilmeRemove)
                {
                    filmes.Remove(filmeDaLista);
                }
            }
            }
            catch
            {

            }
        }
    }
}
