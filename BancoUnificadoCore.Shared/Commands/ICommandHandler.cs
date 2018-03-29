namespace BancoUnificadoCore.Shared.Commands
{
    public interface ICommandHandler<T>
    {
        ICommandResult Handle(T command);
    }
}
