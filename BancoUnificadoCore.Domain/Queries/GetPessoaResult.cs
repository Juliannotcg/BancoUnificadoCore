using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Queries
{
    public class GetPessoaResult
    {
        public System.Guid PesId { get; set; }
        public string PesNome { get; set; }
        public string PesSobreNome { get; set; }
        public int PesTipoDocumento { get; set; }
        public string PesDocumento { get; set; }
        public string PesEndereco { get; set; }
        public string PesBairro { get; set; }
        public string PesCidade { get; set; }
        public string PesUf { get; set; }
        public int PesCep { get; set; }
    }
}
