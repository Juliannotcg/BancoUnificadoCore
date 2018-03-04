using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ContextDapper _context;

        public PessoaRepository(ContextDapper context)
        {
            _context = context;
        }

        public void Save(Pessoa pessoa)
        {
            string insertQuery = "INSERT INTO PesPessoa (PesId, PesNome, PesSobreNome, PesTipoDocuemtno, PesDocumento, PesEndereco, PesBairro, PesCidade, PesUf, PesCEP)"
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
