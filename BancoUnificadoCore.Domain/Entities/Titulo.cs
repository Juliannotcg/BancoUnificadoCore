using BancoUnificadoCore.Shared.Entities;
using System;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Titulo : Identifier
    {
        public Titulo()
        {

        }

        public string Protocolo { get; private set; }
        public DateTime DataProtocolo { get; private set; }
        public int Livro { get; private set; }
        public int Folha { get; private set; }
        public DateTime DataProtesto { get; private set; }
        public int NumeroProtesto { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public string Especie { get; private set; }
        public int Numero { get; private set; }
        public int NossoNumero { get; private set; }
        public decimal Valor { get; private set; }
        public decimal Saldo { get; private set; }
        public string Endosso { get; private set; }
        public string Aceite { get; private set; }
        public bool FinsFalimentares { get; private set; }
        public int MotivoProtesto { get; private set; }
        public int Acao { get; private set; }
        public DateTime DataAcao { get; private set; }
        public int Sequencial { get; private set; }
        public List<Pessoa> pessoa { get; private set; }
        public Apresentante apresentante { get; private set; }
    }
}
