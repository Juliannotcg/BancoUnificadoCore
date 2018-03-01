using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using BancoUnificadoCore.Shared.Handlers;
using Flunt.Notifications;
using System;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class CargaDiariaHandler :
        Notifiable,
        IHandler<CommandCreateCargaDiaria>
    {
        private readonly ICargaDiariaRepository _repository;

        public CargaDiariaHandler(ICargaDiariaRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CommandCreateCargaDiaria command)
        {
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new CommandResult(false, "Não foi possível gerar a carga diária.");
            }

            if (!command.ValidateDates())
            {
                AddNotifications(command);
                return new CommandResult(false, "Não foi possível gerar a carga diária.");
            }

            //Gerando os VO's Nome
            var nome = new Nome(command.Nome, command.SobreNome);
            //Gerando os VO's Documento
            var documento = new Documento(command.TipoDocumento, command.NumeroDocumento);
            //Gerando os VO's Endereco
            var endereco = new Endereco(command.Endereco, command.Bairro, command.Cidade, command.Uf, command.CEP);
            //Gerando os Entities Pessoa
            var pessoa = new Pessoa(nome, documento, endereco, command.TipoEnvolvido);
            //Gerando os Entities Apresentante 
            var apresentante = new Apresentante(command.CodigoApresentante);
            //Gerando os Entities Cartorio
            var cartorio = new Cartorio(command.CodigoCartorio);
            //Gerando os Entities Titulo
            var titulo = new Titulo(command.Protocolo,
                command.DataProtocolo,
                command.Livro,
                command.Folha,
                command.DataProtesto,
                command.NumeroProtesto,
                command.DataEmissao,
                command.DataVencimento,
                command.Especie,
                command.Numero,
                command.NossoNumero,
                command.Valor,
                command.Saldo,
                command.Endosso,
                command.Aceite,
                command.FinsFalimentares,
                command.MotivoProtesto,
                command.Acao,
                command.DataAcao,
                command.Sequencial);

            //Gerando a Entitie CargaDiaria
            var cargaDiaria = new CargaDiaria(titulo);

            //enviando para o repositorio para ser salvo.
            _repository.Save(cargaDiaria);

            return new CommandResult(true, "Carga diária processada com sucesso.");
        }
    }
}
