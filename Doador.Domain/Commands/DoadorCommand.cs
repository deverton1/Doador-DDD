namespace Doador.Domain.Commands
{
    public class DoadorCommand
    {
        public int DoadorId { get; set; }
        public required string NomeDoador { get; set; }
        public required string Cidade { get; set; }
        public required string Estado { get; set; }
        public required int CEP { get; set; }
        public required string Email { get; set; }
        public required int Telefone { get; set; }
    }
}
