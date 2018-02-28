using BancoUnificadoCore.Shared.Commands;

namespace BancoUnificadoCore.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}