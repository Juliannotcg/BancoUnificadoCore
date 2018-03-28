using BancoUnificadoCore.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Validations.CargaDiaria
{
    public class NewCreateCargaDiariaCommandValidation : CargaDiariaValidation<CommandCreateCargaDiaria>
    {
        public NewCreateCargaDiariaCommandValidation()
        {
            ValidateCargaDiaria();
        }
    }
}
