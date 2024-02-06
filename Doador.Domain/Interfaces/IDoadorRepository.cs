using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IDoadorRepository
    {
        Task<IEnumerable<DoadorCommand>> GetDoadores();
        Task<string> CadastrarDoador(DoadorCommand command);
    }
}
