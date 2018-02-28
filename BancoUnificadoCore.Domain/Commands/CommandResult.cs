using BancoUnificadoCore.Shared.Commands;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(){}

        public CommandResult(bool succes, string mensagem)
        {
            Succes = succes;
            Mensagem = mensagem;
        }

        public bool Succes { get; set; }
        public string Mensagem { get; set; }
    }
}
