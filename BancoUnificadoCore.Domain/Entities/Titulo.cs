﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Titulo
    {
        public int TitId { get; set; }
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
        public int FinsFalimentares { get; set; }
        public int MotivoProtesto { get; set; }
        public int Acao { get; set; }
        public DateTime DataAcao { get; set; }
        public int Sequencial { get; set; }
        public List<Pessoa> pessoa { get; set; }
        public Apresentante apresentante { get; set; }
    }
}
