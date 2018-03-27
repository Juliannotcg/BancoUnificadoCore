using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoUnificadoCore.Api.Rerports.Models
{
    public class Certidao
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string Endosso { get; set; }
        public decimal Valor { get; set; }
        public string Protocolo { get; set; }
    }
}
