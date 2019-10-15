using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Entities;
using Projeto.Data.Contracts;
using System.Data.SqlClient; //importando SQL
using Dapper; //importando Dapper
using System.Linq; //importando para trabalhar com o ToList

namespace Projeto.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        //atributo para receber a conexão do banco de dados
        private string connectionString;

        //construtor que irá receber da classe Startup.cs o caminho
        //da connectionstring do banco de dados
        public ProdutoRepository(string connectionString)
        {
            //this coloca a connectionstring no atributo criado
            this.connectionString = connectionString;
        }

        public void Inserir(Produto obj)
        {
            string query = "insert into Produtos(Nome, Preco, Quantidade, DataCadastro) " 
                 + "values(@Nome, @Preco, @Quantidade, GETDATE())";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Atualizar(Produto obj)
        {
            string query = "update Produtos set Nome = @Nome, Preco = @Preco, "
                         + "Quantidade = @Quantidade where IdProduto = @IdProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(int id)
        {
            string query = "delete from Produtos where IdProduto = @IdProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, new { IdProduto = id });
            }
        }

        public List<Produto> ObterTodos()
        {
            string query = "select * from Produtos";
                

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query).ToList();
            }
        }

        public Produto ObterPorId(int id)
        {
            string query = "select * from Produtos where IdProduto = @IdProduto";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query, new { IdProduto = id }).SingleOrDefault();
            }
        }

        public List<Produto> ObterPorNome(string nome)
        {
            //like = contém o nome no campo
            string query = "select * from Produtos where Nome like @Nome";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //sql para retornar o conteudo como o nome
                return connection.Query<Produto>(query, new { Nome = "%" + nome + "%" }).ToList();
            }
        }
    }
}
