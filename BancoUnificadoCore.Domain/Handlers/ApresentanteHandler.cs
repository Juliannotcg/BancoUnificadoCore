using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using BancoUnificadoCore.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class ApresentanteHandler : CommandCreateApresentante
    {
        private readonly IApresentanteRepositoryEntity _repository;

        public ApresentanteHandler(IApresentanteRepositoryEntity repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CommandCreateApresentante command)
        {
            command.IsValid();
            var nome = new Nome(command.Nome, command.SobreNome);
            var documento = new Documento(command.TipoDocumento, command.NumeroDocumento);
            var endereco = new Endereco(command.Endereco, command.Bairro, command.Cidade, command.Uf, command.CEP);
            var apresentante = new Apresentante(command.CodigoApresentante, nome, documento, endereco);

            _repository.Add(apresentante);

            return new CommandResult(true, "O Apresentante foi salvo com sucesso.");
        }
    }
}
