using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Apresentante : Pessoa
    {
        public int AprId { get; set; }
        public string CodigoApresentante { get; set; }
    }
}
