using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Data;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ContextDapper _context;

        public PessoaRepository(ContextDapper context)
        {
            _context = context;
        }

        public bool PessoaExist(Documento documento)
        {
            string numeroDocumento = documento.NumeroDocumento;

            var result = _context.Connection
                      .Query<GetPessoaResult>("SELECT * FROM PesPessoa WHERE PesDocumento = @Documento", new { Documento = numeroDocumento })
                      .FirstOrDefault();

            if (!String.IsNullOrEmpty(result.PesDocumento))
                return true;
            else
                return false;
        }

        public void Save(Pessoa pessoa)
        {
            _context.Connection.Execute("spCreatePessoa",
             new
             {
                 PesId = pessoa.Id,
                 PesNome = pessoa.Nome.PrimeiroNome,
                 PesSobreNome = pessoa.Nome.SobreNome,
                 PesTipoDocumento = pessoa.Documento.TipoDocumento,
                 PesDocumento = pessoa.Documento.NumeroDocumento,
                 PesEndereco = pessoa.Endereco.Logradouro,
                 PesBairro = pessoa.Endereco.Bairro,
                 PesCidade = pessoa.Endereco.Cidade,
                 PesUf = pessoa.Endereco.Uf,
                 PesCEP = pessoa.Endereco.Cep
             }, commandType: CommandType.StoredProcedure);
        }
    }
}
