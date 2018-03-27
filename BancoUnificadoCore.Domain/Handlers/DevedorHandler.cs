using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class DevedorHandler : CommandCreateDevedor
    {
        private readonly IDevedorRepositoryEntity _repository;

        public DevedorHandler(IDevedorRepositoryEntity repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CommandCreateDevedor command)
        {
            command.IsValid();
            var nome = new Nome(command.Nome, command.SobreNome);
            var documento = new Documento(command.TipoDocumento, command.NumeroDocumento);
            var endereco = new Endereco(command.Endereco, command.Bairro, command.Cidade, command.Uf, command.CEP);
            var devedor = new Devedor(nome, documento, endereco);

            //enviando para o repositorio para ser salvo.
            _repository.Add(devedor);

            return new CommandResult(true, "Carga diária processada com sucesso.");
        }
    }
}
