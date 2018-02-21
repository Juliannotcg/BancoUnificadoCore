using BancoUnificadoCore.Shared.Entities;
using System;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Apresentante : Entity
    {
        public Apresentante(){}

        public Apresentante(Guid id,string codigoApresentante)
        {
            Id = id;
            CodigoApresentante = codigoApresentante;
        }

        public string CodigoApresentante { get; private set; }
        public Pessoa pessoa { get; set; }
    }
}
