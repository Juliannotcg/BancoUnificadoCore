using BancoUnificadoCore.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Commands.Titulo
{
    public class CommandCreateTituloResult : ICommandResult
    {
        public CommandCreateTituloResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
