using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Data;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class CargaDiariaRepositoryDapper : ICargaDiariaRepositoryDapper
    {
        private readonly ContextDapper _context;
        public CargaDiariaRepositoryDapper(ContextDapper context)
        {
            _context = context;
        }

        public void Save(CargaDiaria cargaDiaria)
        {
            _context.Connection.Execute("spCreateApresentante",
           new
           {
               Id = cargaDiaria.titulo.Apresentante.Id,
               CodigoApresentante = cargaDiaria.titulo.Apresentante.CodigoApresentante,
               Documento = cargaDiaria.titulo.Apresentante.Documento.NumeroDocumento,
               TipoDocumento = cargaDiaria.titulo.Apresentante.Documento.TipoDocumento,
               Bairro = cargaDiaria.titulo.Apresentante.Endereco.Bairro,
               CEP = cargaDiaria.titulo.Apresentante.Endereco.Cep,
               Cidade = cargaDiaria.titulo.Apresentante.Endereco.Cidade,
               Logradouro = cargaDiaria.titulo.Apresentante.Endereco.Logradouro,
               UF = cargaDiaria.titulo.Apresentante.Endereco.Uf,
               Nome = cargaDiaria.titulo.Apresentante.Nome.PrimeiroNome,
               SobreNome = cargaDiaria.titulo.Apresentante.Nome.SobreNome
           }, commandType: CommandType.StoredProcedure);



            _context.Connection.Execute("spCreateTitulo",
            new
            {
                Id = cargaDiaria.titulo.Id,
                Acao = cargaDiaria.titulo.Acao,
                Aceite = cargaDiaria.titulo.Aceite,
                ApresentanteId = cargaDiaria.titulo.Apresentante.Id,
                CredorId = cargaDiaria.titulo.Credor.Id,
                DataAcao = cargaDiaria.titulo.DataAcao,
                DataEmissao = cargaDiaria.titulo.DataEmissao,
                DataProtesto = cargaDiaria.titulo.DataProtesto,
                DataProtocolo = cargaDiaria.titulo.DataProtocolo,
                DataVencimento = cargaDiaria.titulo.DataVencimento,
                Endosso = cargaDiaria.titulo.Endosso,
                Especie = cargaDiaria.titulo.Especie,
                FinsFalimentares = cargaDiaria.titulo.FinsFalimentares,
                Folha = cargaDiaria.titulo.Folha,
                Livro = cargaDiaria.titulo.Livro,
                MotivoProtesto = cargaDiaria.titulo.MotivoProtesto,
                NossoNumero = cargaDiaria.titulo.NossoNumero,
                Numero = cargaDiaria.titulo.Numero,
                NumeroProtesto = cargaDiaria.titulo.NumeroProtesto,
                Protocolo = cargaDiaria.titulo.Protocolo,
                Saldo = cargaDiaria.titulo.Saldo,
                Sequencial = cargaDiaria.titulo.Sequencial,
                Valor = cargaDiaria.titulo.Valor
            }, commandType: CommandType.StoredProcedure); 
        }
    }
}
