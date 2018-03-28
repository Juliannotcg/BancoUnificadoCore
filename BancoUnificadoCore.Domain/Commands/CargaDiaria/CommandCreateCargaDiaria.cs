﻿using BancoUnificadoCore.Domain.Commands.Credor;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.Validations.CargaDiaria;
using BancoUnificadoCore.Shared.Commands;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateCargaDiaria : ICommand
    {
        public ValidationResult ValidationResult { get; set; }

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

        public bool Valid()
        {
            ValidationResult = new NewCreateCargaDiariaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public bool ValidateDates()
        {
            if (DataProtocolo <= DataProtesto)
                return false;

            if (DataAcao < DataProtesto)
                return false;

            return true;
        }
     
    }
}
