using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Entities;
using Doador.Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace Doador.Repository.Repository
{
    public class DoadorRepository : IDoadorRepository
    {
        private readonly string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doacao;Trusted_Connection=True;MultipleActiveResultSets=true";

        public async Task<string> CadastrarDoador(DoadorCommand command)
        {
            string queryCadastroDoador = @"INSERT INTO Doador (NomeDoador,Cidade,Estado,CEP,Email,Telefone)
                                           VALUES (@NomeDoador,@Cidade,@Estado,@CEP,@Email,@Telefone)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryCadastroDoador, new
                {
                    NomeDoador = command.NomeDoador,
                    Cidade = command.Cidade,
                    Estado = command.Estado,
                    CEP = command.CEP,
                    Email = command.Email,
                    Telefone = command.Telefone
                });

                return "cadastrado realizado com sucesso!!!";
            }
        }

        public async Task<IEnumerable<DoadorCommand>> GetDoadores()
        {
            string queryMostrarDoadores = "select * from Doador";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return await conn.QueryAsync<DoadorCommand>(queryMostrarDoadores);
            }
        }
        
    }

}
