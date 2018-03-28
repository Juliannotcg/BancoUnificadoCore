using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System.Data;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class TituloRepositoryDapper : ITituloRepositoryDapper
    {
        private readonly ContextDapper _context;
        private readonly ApresentanteRepositoryDapper _apresentanteRepository;
        private readonly CredorRepositoryDapper _credorRepository;

        public TituloRepositoryDapper (ContextDapper context,
            ApresentanteRepositoryDapper apresentanteRepository,
            CredorRepositoryDapper credorRepository)
        {
            _context = context;
            _apresentanteRepository = apresentanteRepository;
            _credorRepository = credorRepository;
        }

        public void Save(Titulo titulo)
        {
            if (!_apresentanteRepository.CheckApresentante(titulo.Apresentante.Documento.NumeroDocumento))
                _apresentanteRepository.Save(titulo.Apresentante);

            _credorRepository.Save(titulo.Credor);

            _context.Connection.Execute("spCreateTitulo",
           new
           {
               Id = titulo.Id,
               Acao = titulo.Acao,
               Aceite = titulo.Aceite,
               ApresentanteId = titulo.Apresentante.Id,
               CredorId = titulo.Credor.Id,
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
        }
    }
}
