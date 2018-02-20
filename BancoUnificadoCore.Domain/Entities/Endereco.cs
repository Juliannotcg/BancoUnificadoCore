using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Endereco
    {
        public int EndId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
    }
}
