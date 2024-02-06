using Doador.Domain.Commands;
using Doador.Domain.Interfaces;

namespace Doador.Service.Service
{
    public class DoadorService : IDoadorService
    {
        private readonly IDoadorRepository _doadorRepository;

        public DoadorService(IDoadorRepository doadorRepository)
        {
            _doadorRepository = doadorRepository;
        }

        public async Task<string> CadastrarDoador(DoadorCommand command)
        {
            return await _doadorRepository.CadastrarDoador(command);
        }

        public async Task<IEnumerable<DoadorCommand>>GetDoadores()
        {
            return await _doadorRepository.GetDoadores();
        }

    }
}
