using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using BancoUnificadoCore.Shared.Handlers;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class ApresentanteHandler :
        Notifiable,
        IHandler<CommandCreateApresentante>
    {
        private readonly IApresentanteRepository _repository;

        public ApresentanteHandler(IApresentanteRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CommandCreateApresentante command)
        {
            command.Validate();
            //Gerando os VO's Nome
            var nome = new Nome(command.Nome, command.SobreNome);
            //Gerando os VO's Documento
            var documento = new Documento(command.TipoDocumento, command.NumeroDocumento);
            //Gerando os VO's Endereco
            var endereco = new Endereco(command.Endereco, command.Bairro, command.Cidade, command.Uf, command.CEP);
            //Gerando os Entities Pessoa
            var pessoa = new Pessoa(nome, documento, endereco, command.TipoEnvolvido);
            //Gerando os Entities Apresentante 
            var apresentante = new Apresentante(command.CodigoApresentante, pessoa);

            //enviando para o repositorio para ser salvo.
            _repository.Save(apresentante);

            return new CommandResult(true, "Carga diária processada com sucesso.");
        }
    }
}
