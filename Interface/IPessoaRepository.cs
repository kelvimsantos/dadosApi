using DadosAPI.Controllers.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosAPI.Controllers.Interface
{//a interface é uma casca , acesso simples para passar os dados  necessarios, ela sera implementada  para pessoaRepository// parecido com herança, mas em vez de herdar só aarra um ao outro
    public interface IPessoaRepository
    {
        //pegamos a assinatura da classe
        //quem quiser usar o metodo da classe não vaio instanciar mais a classe, vai instanciar a interface 
        List<Pessoa> Listar();

        Pessoa Obter(int id);
    }
}
