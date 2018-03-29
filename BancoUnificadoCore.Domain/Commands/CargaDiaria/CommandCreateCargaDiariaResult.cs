using BancoUnificadoCore.Shared.Commands;
using FluentValidation.Results;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateCargaDiariaResult : ICommandResult
    {
        public CommandCreateCargaDiariaResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }

    }
}
