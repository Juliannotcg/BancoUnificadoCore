using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
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
            string insertQuery = "INSERT INTO PesPessoa (PesId, PesNome, PesSobreNome, PesTipoDocumento, PesDocumento, PesEndereco, PesBairro, PesCidade, PesUf, PesCEP)"
                            + " VALUES(@Id, @PrimeiroNome, @SobreNome, @TipoDocumento, @NumeroDocumento, @Logradouro, @Bairro, @Cidade, @Uf, @Cep )";

            var result = _context.Connection.Execute(insertQuery, new
            {
                pessoa.Id,
                pessoa.Nome.PrimeiroNome,
                pessoa.Nome.SobreNome,
                pessoa.Documento.TipoDocumento,
                pessoa.Documento.NumeroDocumento,
                pessoa.Endereco.Logradouro,
                pessoa.Endereco.Bairro,
                pessoa.Endereco.Cidade,
                pessoa.Endereco.Uf,
                pessoa.Endereco.Cep
            });
        }
    }
}
