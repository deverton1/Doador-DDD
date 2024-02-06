using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Doador.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorservice;
        public DoadorController(IDoadorService doadorService)
        {
            _doadorservice = doadorService;
        }

        [HttpGet]
        [Route("Total-Doadores")]
        public async Task<IActionResult> GetDoadores()
        {
            return Ok(await _doadorservice.GetDoadores());
        }
        [HttpPost]
        [Route("Cadastrar-Doador")]
        public async Task<IActionResult> CadastrarDoador([FromBody] DoadorCommand command)
        {
            return Ok(await _doadorservice.CadastrarDoador(command));
        }
    }
}
