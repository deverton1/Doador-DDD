using Doador.Domain.Commands;
using Doador.Domain.Enums;
using Doador.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpGet]
        [Route("Listar-Produtos")]
        public async Task<IActionResult> GetProdutosDisponiveis()
        {
            return Ok(await _produtoService.GetProdutosDisponiveis());
        }

        [HttpPost]
        [Route("Cadastrar-Produto")]
        public async Task<IActionResult> CadastrarProduto([FromBody] ProdutoCommand command, ECategoriaProduto ECategoria)
        {
            return Ok(await _produtoService.CadastrarProduto(command, ECategoria));
        }
    }
}
