using DadosAPI.Controllers.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DadosAPI.Controllers.Interface;

namespace DadosAPI.Controllers.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        public string _connectionString = "Server=DSK-PCH-HD_0001\\SQLEXPRESS;Database=dadosAPI;Trusted_Connection=True;";

        public List<Pessoa> Listar() 
        {
            //aqui vou listar todas pessoas sem filtro
            string query = @"SELECT [ID]
                                    ,[Nome]
                                    ,[CPF]
                                    FROM[dbo].[Pessoa]";
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn.Query<Pessoa>(query).ToList();
              
        }

        public Pessoa Obter(int id)
        {
            //aqui vou listar todas pessoas sem filtro
            string query = @"SELECT [ID]
                                    ,[Nome]
                                    ,[CPF]
                                    FROM[dbo].[Pessoa]
                                    WHERE [id] = @id";
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn.QueryFirstOrDefault<Pessoa>(query, new { id }); //retorna para a classe que esta esperando esse retorno

        }

    }
}
