using BancoUnificadoCore.Domain.Commands.Credor;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Commands.Titulo
{
    public class CommandCreateTitulo : Notifiable, ICommand
    { 
        public string Protocolo { get; set; }
        public int Livro { get; set; }
        public int Folha { get; set; }
        public int NumeroProtesto { get; set; }
        public string Especie { get; set; }
        public int Numero { get; set; }
        public int NossoNumero { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
        public string Endosso { get; set; }
        public string Aceite { get; set; }
        public bool FinsFalimentares { get; set; }
        public int MotivoProtesto { get; set; }
        public int Sequencial { get; set; }
        public int CodigoCartorio { get; set; }
        public CommandCreateApresentante Apresentante { get; set; }
        public CommandCreateCredor Credor { get; set; }
        public List<CommandDevedor> Devedor { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime DataProtesto { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataAcao { get; set; }

        public EAcao Acao { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
               .Requires()
               .IsNotNullOrEmpty(Protocolo,"Protocolo", "O protocolo deve ser preenchido.")
               .HasMaxLen(Protocolo, 10, "Protocolo", "O número do protocolo deve conter até 10 caracteres.")
           );
        }
    }
}
