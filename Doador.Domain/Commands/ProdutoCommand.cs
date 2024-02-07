using Doador.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Commands
{
    public class ProdutoCommand
    {
        public int ProdutoId { get; set; }
        public string NomeProd { get; set; }
        public string DescriProd { get; set; }
        public ECategoriaProduto ECategoria { get; set; }
        public bool Disponivel { get; set; }
        public int DoadorId { get; set; } //chave estrangeira
    }
}
