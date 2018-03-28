using BancoUnificadoCore.Domain.Enums;
using System;

namespace BancoUnificadoCore.Domain.Queries
{
    public class GetDevedorResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ETipoDocumento TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string SobreNome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public int Cep { get; set; }
    }
}
