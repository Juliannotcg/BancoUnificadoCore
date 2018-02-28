using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;
using System;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CreateCargaDiaria : Notifiable, ICommand
    {
        //Fail, Fast, Validation
        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
