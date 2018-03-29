﻿using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;

namespace BancoUnificadoCore.Domain.Commands.Credor
{
    public class CommandCreateCredor : Notifiable, ICommand
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

        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
