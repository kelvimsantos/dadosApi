using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosAPI.Controllers.Entity
{
    public class Aplicacao
    {
        public int ID { get; set; }
        public DateTime DatHora { get; set; }
        public int PessoaID { get; set; }
        public int FornecedorID { get; set; }

    }
}
