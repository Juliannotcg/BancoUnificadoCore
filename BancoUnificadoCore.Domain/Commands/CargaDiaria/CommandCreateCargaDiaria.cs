using BancoUnificadoCore.Domain.Commands.CargaDiaria;
using BancoUnificadoCore.Domain.Commands.Credor;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.Validations.CargaDiaria;
using BancoUnificadoCore.Shared.Commands;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateCargaDiaria : CommandCargaDiaria
    {
        public override bool IsValid()
        {
            ValidationResult = new NewCreateCargaDiariaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
