using BancoUnificadoCore.Domain.Commands.Titulo;
using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateCargaDiaria : Notifiable, ICommand
    {
        public CommandCreateTitulo Titulo { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
            );
        }
    }
}
