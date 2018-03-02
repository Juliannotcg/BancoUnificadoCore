using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;
using System;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateApresentante: Notifiable, ICommand
    {
        public string CodigoApresentante { get;  set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string NumeroDocumento { get; set; }
        public ETipoDocumento TipoDocumento { get; set; }
        public ETipoEnvolvido TipoEnvolvido { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string CEP { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
