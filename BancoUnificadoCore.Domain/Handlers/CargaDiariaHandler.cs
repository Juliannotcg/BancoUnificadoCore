using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Shared.Commands;
using BancoUnificadoCore.Shared.Handlers;
using Flunt.Notifications;
using System;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class CargaDiariaHandler :
        Notifiable,
        IHandler<CreateCargaDiaria>
    {
        public ICommandResult Handle(CreateCargaDiaria command)
        {
            throw new NotImplementedException();
        }
    }
}
