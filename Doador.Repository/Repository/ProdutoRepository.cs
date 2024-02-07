using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Enums;
using Doador.Domain.Interfaces;
using Microsoft.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doacao;Trusted_Connection=True;MultipleActiveResultSets=true";

        public async Task<string> CadastrarProduto(ProdutoCommand command, ECategoriaProduto ECategoria)
        {
            string QueryInsertProduto = @"insert into Produto (NomeProd,DescriProd,Categoria,Disponivel,DoadorId)
                                            values (@Nomeprod,@DescriProd,@Categoria,@Disponivel,@DoadorId)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(
                    QueryInsertProduto, new
                    {
                        NomeProd = command.NomeProd,
                        DescriProd = command.DescriProd,
                        Categoria = command.ECategoria,
                        Disponivel = command.Disponivel,
                        DoadorId = command.DoadorId
                    });
                return "Cadastro realizado com sucesso!";
            }
        }

        public async Task<IEnumerable<ProdutoCommand>> GetProdutosDisponiveis()
        {
            string queryGetAllProdutos = @"SELECT * FROM Produto";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return conn.QueryAsync<ProdutoCommand>(queryGetAllProdutos).Result.ToList();
            }
        }
    }
}
