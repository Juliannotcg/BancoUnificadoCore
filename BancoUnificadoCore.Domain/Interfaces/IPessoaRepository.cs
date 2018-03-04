using BancoUnificadoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        void Save(Pessoa pessoa);
    }
}
