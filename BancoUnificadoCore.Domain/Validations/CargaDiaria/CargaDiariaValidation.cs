using BancoUnificadoCore.Domain.Commands.CargaDiaria;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Validations.CargaDiaria
{
    public class CargaDiariaValidation<T> : AbstractValidator<T> where T : CommandCargaDiaria
    {
    }
}
