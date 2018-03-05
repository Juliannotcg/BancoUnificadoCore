using System;

namespace BancoUnificadoCore.Domain.Queries
{
    public class GetApresentanteResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
    }
}
