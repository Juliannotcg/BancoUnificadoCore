namespace BancoUnificadoCore.Shared.Commands
{
    public interface ICommandHandler<T> : ICommand
    {
        ICommandResult Handle(T command);
    }
}
