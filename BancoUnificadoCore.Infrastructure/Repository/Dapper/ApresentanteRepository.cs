using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Data;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class ApresentanteRepository : IApresentanteRepository
    {
        private readonly ContextDapper _context;

        public ApresentanteRepository(ContextDapper context)
        {
            _context = context;
        }

        public GetApresentanteResult Get(Guid id)
        {
            return
                _context
                .Connection
                .Query<GetApresentanteResult>("SELECT [Id], CONCAT([PrimeiroNome], ' ', [SobreNome]) AS [Nome], [Documento], [CodigoApresentante] FROM [Apresentante] WHERE [Id]=@id", new { id = id })
                .FirstOrDefault();
        }

        public void Save(Apresentante apresentante)
        {
            _context.Connection.Execute("spCreatePessoa",
            new
            {
                PesId = apresentante.Pessoa.Id,
                PesNome = apresentante.Pessoa.Nome.PrimeiroNome,
                PesSobreNome = apresentante.Pessoa.Nome.SobreNome,
                PesTipoDocuemtno = apresentante.Pessoa.Documento.TipoDocumento,
                PesDocumento = apresentante.Pessoa.Documento.NumeroDocumento,
                PesEndereco = apresentante.Pessoa.Endereco.Logradouro,
                PesBairro = apresentante.Pessoa.Endereco.Bairro,
                PesCidade = apresentante.Pessoa.Endereco.Cidade,
                PesUf = apresentante.Pessoa.Endereco.Uf,
                PesCEP = apresentante.Pessoa.Endereco.Cep

            }, commandType: CommandType.StoredProcedure);

            _context.Connection.Execute("spCreateApresentante",
            new
            {
                AprId = apresentante.Id,
                Apr_PesId = apresentante.Pessoa.Id,
                CodigoApresentane = apresentante.CodigoApresentante
            }, commandType: CommandType.StoredProcedure);
        }
    }
}

