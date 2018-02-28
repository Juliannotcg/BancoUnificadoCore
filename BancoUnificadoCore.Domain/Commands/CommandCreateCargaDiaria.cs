using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;
using System;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateCargaDiaria : Notifiable, ICommand
    {

        public Guid Id { get; set; }
        public string Protocolo { get; set; }
        public DateTime DataProtocolo { get; set; }
        public int Livro { get; set; }
        public int Folha { get; set; }
        public DateTime DataProtesto { get; set; }
        public int NumeroProtesto { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Especie { get; set; }
        public int Numero { get; set; }
        public int NossoNumero { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
        public string Endosso { get; set; }
        public string Aceite { get; set; }
        public bool FinsFalimentares { get; set; }
        public int MotivoProtesto { get; set; }
        public EAcao Acao { get; set; }
        public DateTime DataAcao { get; set; }
        public int Sequencial { get; set; }
        public string CodigoApresentante { get; set; }
        public int CodigoCartorio { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public Documento Documento { get; set; }
        public ETipoEnvolvido TipoEnvolvido { get; set; }
        public Endereco Endereco { get; set; }


        //Fail, Fast, Validation
        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
