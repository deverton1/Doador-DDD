using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Repository.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        //to do adicionar query do SQL
        public Task<IEnumerable<ProdutoCommand>> GetProdutosDisponiveis()
        {
            throw new NotImplementedException();
        }
    }
}
