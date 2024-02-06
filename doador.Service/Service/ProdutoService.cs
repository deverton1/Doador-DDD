using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoService _produtoService;
        public ProdutoService(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        public async Task<IEnumerable<ProdutoCommand>> GetProdutosDisponiveis()
        {
            return await _produtoService.GetProdutosDisponiveis();
        }
    }
}
