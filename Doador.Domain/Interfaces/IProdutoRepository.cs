using Doador.Domain.Commands;
using Doador.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutoCommand>> GetProdutosDisponiveis();
        Task<string> CadastrarProduto(ProdutoCommand command, ECategoriaProduto ECategoria);
    }
}
