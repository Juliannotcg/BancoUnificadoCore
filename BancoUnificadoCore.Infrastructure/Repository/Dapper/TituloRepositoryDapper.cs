using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries.Titulo;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class TituloRepositoryDapper : ITituloRepositoryDapper
    {
        private readonly ContextDapper _context;
        private readonly ApresentanteRepositoryDapper _apresentanteRepository;
        private readonly CredorRepositoryDapper _credorRepository;
        private readonly DevedorRepositoryDapper _devedorRepository;

        public TituloRepositoryDapper (ContextDapper context,
            ApresentanteRepositoryDapper apresentanteRepository,
            CredorRepositoryDapper credorRepository,
            DevedorRepositoryDapper devedorRepository)
        {
            _context = context;
            _apresentanteRepository = apresentanteRepository;
            _credorRepository = credorRepository;
            _devedorRepository = devedorRepository;
        }

        public IEnumerable<GetTituloResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public GetTituloResult GetByCodigoApresentante(string codigo)
        {
            throw new NotImplementedException();
        }

        public GetTituloResult GetById(Guid Id)
        {
            return _context
                  .Connection
                  .Query<GetTituloResult>(
                       "spSelectTituloId",
                        new { Id = Id },
                       commandType: CommandType.StoredProcedure)
                  .FirstOrDefault();
        }

        public GetTituloResult GetTituloProtocolo(string protocolo)
        {
            return _context
                  .Connection
                  .Query<GetTituloResult>(
                       "spSelectTituloProtocolo",
                        new { Protocolo = protocolo },
                       commandType: CommandType.StoredProcedure)
                  .FirstOrDefault();
        }

        public void Save(Titulo titulo)
        {
            Guid ApresentanteNewId;
            Guid CredorNewId;

            var resultApresentante = _apresentanteRepository.CheckApresentante(titulo.Apresentante.Documento.NumeroDocumento);
            if (resultApresentante != null)
                ApresentanteNewId = resultApresentante.Id;
            else
            {
                _apresentanteRepository.Save(titulo.Apresentante);
                ApresentanteNewId = titulo.Apresentante.Id;
            }

            var resultCredor = _credorRepository.CheckCredor(titulo.Credor.Documento.NumeroDocumento);

            if (resultCredor != null)
                CredorNewId = resultCredor.Id;
            else
            {
                _credorRepository.Save(titulo.Credor);
                CredorNewId = titulo.Credor.Id;
            }

            _context.Connection.Execute("spCreateTitulo",
            new
            {
                Id = titulo.Id,
                Acao = titulo.Acao,
                Aceite = titulo.Aceite,
                ApresentanteId = ApresentanteNewId,
                CredorId = CredorNewId,
                DataAcao = titulo.DataAcao,
                DataEmissao = titulo.DataEmissao,
                DataProtesto = titulo.DataProtesto,
                DataProtocolo = titulo.DataProtocolo,
                DataVencimento = titulo.DataVencimento,
                Endosso = titulo.Endosso,
                Especie = titulo.Especie,
                FinsFalimentares = titulo.FinsFalimentares,
                Folha = titulo.Folha,
                Livro = titulo.Livro,
                MotivoProtesto = titulo.MotivoProtesto,
                NossoNumero = titulo.NossoNumero,
                Numero = titulo.Numero,
                NumeroProtesto = titulo.NumeroProtesto,
                Protocolo = titulo.Protocolo,
                Saldo = titulo.Saldo,
                Sequencial = titulo.Sequencial,
                Valor = titulo.Valor
            }, commandType: CommandType.StoredProcedure);

            _devedorRepository.Save(titulo);
        }
    }
}
