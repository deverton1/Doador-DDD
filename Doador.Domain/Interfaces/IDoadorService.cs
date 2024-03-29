﻿using Doador.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Interfaces
{
    public interface IDoadorService
    {
        Task<IEnumerable<DoadorCommand>> GetDoadores();
        Task<string> CadastrarDoador(DoadorCommand command);
    }
}
