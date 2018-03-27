using BancoUnificadoCore.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Validations.Devedor
{
    class NewCreateDevedorCommandValidation : DevedorValidation<CommandCreateDevedor>
    {
        public NewCreateDevedorCommandValidation()
        {
            ValidateNomeDevedor();
            ValidateSobreNomeDevedor();
            ValidateDocumentoDevedor();
        }
    }
}
