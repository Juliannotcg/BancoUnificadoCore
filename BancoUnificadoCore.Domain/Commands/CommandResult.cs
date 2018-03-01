using BancoUnificadoCore.Shared.Commands;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(bool succes, string mensagem)
        {
            Succes = succes;
            Mensagem = mensagem;
        }

        public bool Succes { get; set; }
        public string Mensagem { get; set; }
        public bool Success { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Message { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
