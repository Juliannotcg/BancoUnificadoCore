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
            //Gerando os VO's Nome
           // var nome = new Nome(command.Nome, command.SobreNome);
           // //Gerando os VO's Documento
           // var documento = new Documento(command.TipoDocumento, command.NumeroDocumento);
           // //Gerando os VO's Endereco
           // var endereco = new Endereco(command.Endereco, command.Bairro, command.Cidade, command.Uf, command.CEP);
           // //Gerando os Entities Pessoa
           // //Gerando os Entities Apresentante 
           //// var apresentante = new Apresentante(command.CodigoApresentante, pessoa);

           // //enviando para o repositorio para ser salvo.
           // //_repository.Save(apresentante);

           // _repository.Add(apresentante);
            
            return new CommandResult(true, "O Apresentante foi salvo com sucesso.");
        }
    }
}
