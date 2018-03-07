using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Infrastructure.Context;
using BancoUnificadoCore.Infrastructure.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Repository.EntityFramework
{
    public class PessoaRepositoryEntity : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepositoryEntity(ContextEntity context) 
            : base(context)
        {

        }
        public bool PessoaExist(Documento documento)
        {
            throw new NotImplementedException();
        }

        public void Save(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
