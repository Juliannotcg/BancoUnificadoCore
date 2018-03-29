using BancoUnificadoCore.Shared.Commands;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult()
        {

        }
        public CommandResult(bool succes, string mensagem)
        {
            Success = succes;
            Message = mensagem;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
