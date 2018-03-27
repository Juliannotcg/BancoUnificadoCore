using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using BancoUnificadoCore.Shared.Handlers;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Handlers
{
    public class CargaDiariaHandler : ICommandHandler<CommandCreateCargaDiaria>
    {
        private readonly ICargaDiariaRepositoryEntity _repository;

        public CargaDiariaHandler(ICargaDiariaRepositoryEntity repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CommandCreateCargaDiaria command)
        {
            //Gerando Apresentante
            var nomeApresentante = new Nome(command.Apresentante.Nome, command.Apresentante.SobreNome);
            var documentoApresentante = new Documento(command.Apresentante.TipoDocumento, command.Apresentante.NumeroDocumento);
            var enderecoApresentante = new Endereco(command.Apresentante.Endereco, command.Apresentante.Bairro, command.Apresentante.Cidade, command.Apresentante.Uf, command.Apresentante.CEP);
            var apresentante = new Apresentante(command.Apresentante.CodigoApresentante, nomeApresentante, documentoApresentante, enderecoApresentante);

            //Gerando credor
            var nomeCredor = new Nome(command.Credor.Nome, command.Credor.SobreNome);
            var documentoCredor = new Documento(command.Credor.TipoDocumento, command.Credor.NumeroDocumento);
            var enderecoCredor = new Endereco(command.Credor.Endereco, command.Credor.Bairro, command.Credor.Cidade, command.Credor.Uf, command.Credor.CEP);
            var credor = new Credor(nomeCredor, documentoCredor, enderecoCredor);

            //Gerando devedor
            var devedor = new List<Devedor>();
            foreach (var item in command.Devedor)
            {
                var nomeDevedor = new Nome(item.Nome, item.SobreNome);
                var documentoDevedor = new Documento(item.TipoDocumento, item.NumeroDocumento);
                var enderecoDevedor = new Endereco(item.Endereco, item.Bairro, item.Cidade, item.Uf, item.CEP);
                var novoDevedor = new Devedor(nomeDevedor, documentoDevedor, enderecoDevedor);
                devedor.Add(novoDevedor);
            }
            
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
