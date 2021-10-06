using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Pagamentos
    {
        public String NomeCliente { get; set; }

        public String IdentificacaoFilme { get; set; }

        public DateTime PrazoEntrega { get; set; }

        public Int32 Valor { get; set; }
    }
}
