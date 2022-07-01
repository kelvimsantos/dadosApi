using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosAPI.Controllers.Model
{//essa classe é um modelo que passa entrecontroller e service
    public class PessoaResponse
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
