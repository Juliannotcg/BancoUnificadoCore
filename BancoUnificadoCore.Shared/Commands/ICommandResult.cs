using System.Collections.Generic;

namespace BancoUnificadoCore.Shared.Commands
{
    public interface ICommandResult
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}
