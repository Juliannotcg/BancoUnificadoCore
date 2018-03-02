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
                PesId = apresentante.pessoa.Id,
                PesNome = apresentante.pessoa.Nome.PrimeiroNome,
                PesSobreNome = apresentante.pessoa.Nome.SobreNome,
                PesTipoDocuemtno = apresentante.pessoa.Documento.TipoDocumento,
                PesDocumento = apresentante.pessoa.Documento.NumeroDocumento,
                PesEndereco = apresentante.pessoa.Endereco.Logradouro,
                PesBairro = apresentante.pessoa.Endereco.Bairro,
                PesCidade = apresentante.pessoa.Endereco.Cidade,
                PesUf = apresentante.pessoa.Endereco.Uf,
                PesCEP = apresentante.pessoa.Endereco.Cep

            }, commandType: CommandType.StoredProcedure);

            _context.Connection.Execute("spCreatePessoa",
            new
            {
                AprId = apresentante.Id,
                Apr_PesId = apresentante.pessoa.Id,
                CodigoApresentane = apresentante.CodigoApresentante
            }, commandType: CommandType.StoredProcedure);
        }
    }
}

