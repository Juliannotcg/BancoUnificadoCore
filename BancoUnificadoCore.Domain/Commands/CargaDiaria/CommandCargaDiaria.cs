using BancoUnificadoCore.Domain.Commands.Credor;
using BancoUnificadoCore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Commands.CargaDiaria
{
    public class CommandCargaDiaria : Command
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
        public CommandApresentante Apresentante { get; set; }
        public CommandCredor Credor { get; set; }
        public List<CommandDevedor> Devedor { get; set; }

        public DateTime DataProtocolo { get; set; }
        public DateTime DataProtesto { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataAcao { get; set; }

        public EAcao Acao { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
