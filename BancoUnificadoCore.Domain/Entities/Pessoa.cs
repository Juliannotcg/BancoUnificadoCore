namespace BancoUnificadoCore.Domain.Entities
{
    public class Pessoa
    {
        public int PesId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
        public Envolvido envolvido { get; set; }
        public Endereco endereco { get; set; }
    }
}
