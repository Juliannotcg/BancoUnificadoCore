using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Shared.Entities
{
    public class Identifier : Notifiable
    {
        public Identifier()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
