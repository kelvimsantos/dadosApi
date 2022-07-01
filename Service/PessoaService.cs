using DadosAPI.Controllers.Entity;
using DadosAPI.Controllers.Interface;
using DadosAPI.Controllers.Model;
using DadosAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosAPI.Controllers.Service
{
    public class PessoaService : IPessoaService
    {//propriedade de interface
        private IPessoaRepository _pessoaRepository;

        //metodo construtor dessa classe_obrigatorio*
        //esse metodo pega a instancia do tipo interface e joga para a variavel
        //injeção de dependencia
        //construtor cria uma instancia tipo interface e passa para prop
        public PessoaService(IPessoaRepository pessoaRepositury)
        {
            _pessoaRepository = pessoaRepositury;
            //vai setar a propriedade sempre que for chamado e passado o valor
        }

        //devolve lista de objeto response
        public List<PessoaResponse> Listar() //metodo que devolve uma lsita de objetos pessoa response que é model resposta
        {
            //variavel que vai pegar essa propriedade o metodo do repository
            var entity = _pessoaRepository.Listar();  //devolve uma lista de objeto pessoa para entity//vai acessar o listar do etodo da interface do repository 

            //CRIAMOS A instacia da LISTA do tipo pessoa response
            //vamos pegar todos itens dentro da lista entity =_pessoaRepository passar para model response
            List<PessoaResponse> response = new List<PessoaResponse>();

            //para converter essa lista precisamos criar um foreach
            //Para cada pessoa response da lista
            entity.ForEach(P =>
            { //para cada entity / repository , p representa item da drepository 

                //O QUE ESTOU FAZENDO É O MESMO QUE ISSO SÓ QUE REDUÇÃO DE LINHAS
                //cria uma instancia do objeto pessoa response para ir colocando na lista a cada iteração
                //PessoaResponse pessoaResponse = new PessoaResponse(); 
                //pessoaResponse.ID = P.ID;
                //pessoaResponse.CPF = P.CPF;
                //pessoaResponse.Nome = P.Nome;
                //response.Add(pessoaResponse);

                response.Add(new PessoaResponse()   //e addos itens de repository/ entity para response
                {   //adiciona o item ja preenchendo as props dele
                    ID = P.ID,
                    Nome = P.Nome,
                    CPF = P.CPF

                });
            });
            return response;//por fim , quando ler todos objetos da lista  ele retorna a lista

        }


            public PessoaResponse Obter (int id) {
                var entity = _pessoaRepository.Obter(id);

                //PessoaResponse response = new PessoaResponse();
                //response.ID = entity.ID;
                //response.Nome = entity.Nome;
                //response.CPF = entity.CPF;

                //a mesma coisa que é feita em cima de forma mais simples
                return new PessoaResponse()
                {
                    ID = entity.ID,
                    Nome = entity.Nome,
                    CPF = entity.CPF
                };
            }

        
    } }
