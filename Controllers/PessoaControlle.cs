using DadosAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosAPI.Controllers
{
    [Route("[controller]")]//rota http:// nosso caso sera um local host :porta/Pessoa/metodo 
    //vai acessar o nome da controller: no caso "Pessoa"  por que o nome do arquivo é PessoaControlle
    public class PessoaControlle
    {
        private IPessoaService _pessoaSevice;

        //metodo construtor
        //se tivesse varios comportamentos diferentes seria possivell criar outros metodos com parametros diferente e com comportamento diferente
        //injeção de dependencia
        public PessoaControlle(IPessoaService pessoaService)
        {
            _pessoaSevice = pessoaService;
        }

        //retorna um pacote guest,modo de comunicar entre quem ta pedindo e quem esta enviando
        //conceito rest

        [HttpGet("listar")] //pESSOA/lISTAR VAI ACESSAR ESSE METODO 
        public IActionResult Listar() //será chaado o listar da interface service que vai chaar o listar da repository
        {
            var response = _pessoaSevice.Listar();
            return new ObjectResult(response) { StatusCode = 200 };   //vai devolver o pacote result  do action enviando response, e retornando o status code
                                    //response conteudo . se statrus for 200
        }


        [HttpGet("obter")] //pESSOA/lISTAR VAI ACESSAR ESSE METODO 
        public IActionResult Obter([FromQuery]int id)//será chaado o listar da interface service que vai chaar o listar da repository
        {
            var response = _pessoaSevice.Obter(id);
            return new ObjectResult(response) { StatusCode = 200 };   //vai devolver o pacote result  do action enviando response, e retornando o status code
                                                                      //response conteudo . se statrus for 200
        }
    }
}
