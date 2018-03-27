using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Entities;
using System;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Apresentante : Entity
    {
        public Apresentante(string codigoApresentante , Nome nome, Documento documento, Endereco endereco)
        {
            CodigoApresentante = codigoApresentante;
            Nome = nome;
            Endereco = endereco;
            Documento = documento;
        }
        protected Apresentante() { }

        public string CodigoApresentante { get; private set; }
        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
