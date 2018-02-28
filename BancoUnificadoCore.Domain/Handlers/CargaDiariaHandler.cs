using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using BancoUnificadoCore.Shared.Handlers;
using Flunt.Notifications;
using System;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class CargaDiariaHandler :
        Notifiable,
        IHandler<CommandCreateCargaDiaria>
    {
        public ICommandResult Handle(CommandCreateCargaDiaria command)
        {

            //Alimentando os VO's
            var nome = new Nome(command.Nome, command.SobreNome);

            throw new NotImplementedException();
        }
    }
}
