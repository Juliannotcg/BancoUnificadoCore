using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System.Data;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class CargaDiariaRepository : ICargaDiariaRepository
    {
        private readonly ContextDapper _context;

        public CargaDiariaRepository(ContextDapper context)
        {
            _context = context;
        }

        public void Save(CargaDiaria cargaDiaria)
        {
            _context.Connection.Execute("spCreateCargaDiaria",
            new
            {
                TitId = cargaDiaria.Id,
                Tit_PesID = cargaDiaria.titulo.Pessoa.Id,
                Tit_AprId = cargaDiaria.titulo.Apresentante.Id,
                TitProtocolo = cargaDiaria.titulo.Protocolo,
                TitDataProtocolo = cargaDiaria.titulo.DataProtocolo,
                TitLivro = cargaDiaria.titulo.Livro,
                TitFolha = cargaDiaria.titulo.Folha,
                TitDataProtesto = cargaDiaria.titulo.DataProtesto,
                TitNumeroProtesto = cargaDiaria.titulo.NumeroProtesto,
                TitDataEmissao = cargaDiaria.titulo.DataEmissao,
                TitDataVencimento = cargaDiaria.titulo.DataVencimento,
                TitEspecie = cargaDiaria.titulo.Especie,
                TitNumero = cargaDiaria.titulo.Numero,
                TitNossoNumero = cargaDiaria.titulo.NossoNumero,
                TitValor = cargaDiaria.titulo.Valor,
                TitSaldo = cargaDiaria.titulo.Saldo,
                TitEndosso = cargaDiaria.titulo.Endosso,
                TitAceite = cargaDiaria.titulo.Aceite,
                TitFinsFalimentares = cargaDiaria.titulo.FinsFalimentares,
                TitMotivoProtesto = cargaDiaria.titulo.MotivoProtesto,
                TitAcao = cargaDiaria.titulo.Acao,
                TitDataAcao = cargaDiaria.titulo.DataAcao,
                TitSequencial = cargaDiaria.titulo.Sequencial
            }, commandType: CommandType.StoredProcedure);
        }
    }
}
