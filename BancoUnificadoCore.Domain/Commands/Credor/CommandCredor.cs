using BancoUnificadoCore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Commands.Credor
{
    public class CommandCredor : Command
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string NumeroDocumento { get; set; }
        public ETipoDocumento TipoDocumento { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string CEP { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}