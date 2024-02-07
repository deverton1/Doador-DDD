using Doador.Domain.Commands;
using Doador.Domain.Enums;
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
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<string> CadastrarProduto(ProdutoCommand command, ECategoriaProduto ECategoria)
        {
            return await _produtoRepository.CadastrarProduto(command,ECategoria);
        }

        public async Task<IEnumerable<ProdutoCommand>> GetProdutosDisponiveis()
        {
            return await _produtoRepository.GetProdutosDisponiveis();
        }
    }
}
