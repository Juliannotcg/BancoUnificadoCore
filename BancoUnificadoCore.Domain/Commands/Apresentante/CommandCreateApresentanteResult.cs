using BancoUnificadoCore.Shared.Commands;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateApresentanteResult : ICommandResult
    {
        public CommandCreateApresentanteResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
