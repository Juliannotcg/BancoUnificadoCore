using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Queries
{
    public class GetApresentanteResult
    {
        public System.Guid Id { get; set; }
        public string CodigoApresentante { get; set; }
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
            }
}
