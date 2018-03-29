using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class CargaDiariaHandler : Notifiable, ICommandHandler<CommandCreateCargaDiaria>
    {
        private readonly ICargaDiariaRepositoryDapper _repository;
        private readonly IApresentanteRepositoryDapper _repositoryApresentante;

        public CargaDiariaHandler(ICargaDiariaRepositoryDapper repository, IApresentanteRepositoryDapper repositoryApresentante)
        {
            _repository = repository;
            _repositoryApresentante = repositoryApresentante;
        }

        public ICommandResult Handle(CommandCreateCargaDiaria command)
        {
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new CommandCreateCargaDiariaResult(false, "Não foi possível inserir a carga");
            }

            //Gerando Apresentante
            var nomeApresentante = new Nome(command.Titulo.Apresentante.Nome, command.Titulo.Apresentante.SobreNome);
            var documentoApresentante = new Documento(command.Titulo.Apresentante.TipoDocumento, command.Titulo.Apresentante.NumeroDocumento);
            var enderecoApresentante = new Endereco(command.Titulo.Apresentante.Endereco, command.Titulo.Apresentante.Bairro, command.Titulo.Apresentante.Cidade, command.Titulo.Apresentante.Uf, command.Titulo.Apresentante.CEP);
            var apresentante = new Apresentante(command.Titulo.Apresentante.CodigoApresentante, nomeApresentante, documentoApresentante, enderecoApresentante);
            
            //Gerando credor
            var nomeCredor = new Nome(command.Titulo.Credor.Nome, command.Titulo.Credor.SobreNome);
            var documentoCredor = new Documento(command.Titulo.Credor.TipoDocumento, command.Titulo.Credor.NumeroDocumento);
            var enderecoCredor = new Endereco(command.Titulo.Credor.Endereco, command.Titulo.Credor.Bairro, command.Titulo.Credor.Cidade, command.Titulo.Credor.Uf, command.Titulo.Credor.CEP);
            var credor = new Credor(nomeCredor, documentoCredor, enderecoCredor);

            //Gerando devedor
            var devedor = new List<Devedor>();
            foreach (var item in command.Titulo.Devedor)
            {
                var nomeDevedor = new Nome(item.Nome, item.SobreNome);
                var documentoDevedor = new Documento(item.TipoDocumento, item.NumeroDocumento);
                var enderecoDevedor = new Endereco(item.Endereco, item.Bairro, item.Cidade, item.Uf, item.CEP);
                var novoDevedor = new Devedor(nomeDevedor, documentoDevedor, enderecoDevedor);
                devedor.Add(novoDevedor);
            }
            
            //Gerando os Entities Titulo
            var titulo = new Titulo(command.Titulo.Protocolo,
                command.Titulo.DataProtocolo,
                command.Titulo.Livro,
                command.Titulo.Folha,
                command.Titulo.DataProtesto,
                command.Titulo.NumeroProtesto,
                command.Titulo.DataEmissao,
                command.Titulo.DataVencimento,
                command.Titulo.Especie,
                command.Titulo.Numero,
                command.Titulo.NossoNumero,
                command.Titulo.Valor,
                command.Titulo.Saldo,
                command.Titulo.Endosso,
                command.Titulo.Aceite,
                command.Titulo.FinsFalimentares,
                command.Titulo.MotivoProtesto,
                command.Titulo.Acao,
                command.Titulo.DataAcao,
                command.Titulo.Sequencial,
                apresentante,
                credor,
                devedor);
            
            //Gerando a Entitie CargaDiaria
            var cargaDiaria = new CargaDiaria(titulo);

            //AddNotifications(name, document, email, address, student, subscription, payment);
            //// Checar as notificações
            //if (Invalid)
            //    return new CommandResult(false, "Não foi possível realizar sua assinatura");

            //enviando para o repositorio para ser salvo.
            _repository.Save(cargaDiaria);

            return new CommandCreateCargaDiariaResult(true, "Carga diária processada com sucesso.");
        }

        void ICommand.Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
