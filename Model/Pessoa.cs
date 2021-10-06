using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Pessoa
    {
        public class Pessoas : BasePessoa
        {

            public String Nome { get; set; }

            public Int64 Telefone { get; set; }

            public DateTime Nascimento { get; set; }

            public String Sexo { get; set; }

            public Endereco Endereco { get; set; }
        }
    }
}
