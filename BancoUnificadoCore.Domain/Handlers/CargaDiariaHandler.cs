using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using BancoUnificadoCore.Shared.Handlers;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class CargaDiariaHandler : CommandCreateCargaDiaria
    {
        private readonly ICargaDiariaRepositoryEntity _repository;

        public CargaDiariaHandler(ICargaDiariaRepositoryEntity repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CommandCreateCargaDiaria command)
        {
            //Gerando credor
            var credor = new Credor(command.Credor.Nome, command.Credor.Documento, command.Credor.Endereco);

            //Gerando devedor
            var devedor = new List<Devedor>();
            foreach (var item in command.Devedor)
                devedor.Add(item);

            //Gerando os Entities Apresentante 
            var apresentante = new Apresentante(command.Apresentante.CodigoApresentante, command.Apresentante.Nome, command.Apresentante.Documento, command.Apresentante.Endereco);
            
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
                command.Sequencial,
                apresentante,
                credor,
                devedor);

            //Gerando a Entitie CargaDiaria
            var cargaDiaria = new CargaDiaria(titulo);

            //enviando para o repositorio para ser salvo.
            _repository.Add(cargaDiaria);

            return new CommandResult(true, "Carga diária processada com sucesso.");
        }
    }
}
