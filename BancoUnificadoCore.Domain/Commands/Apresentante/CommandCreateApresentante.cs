using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateApresentante : Notifiable, ICommand
    { 
        public string CodigoApresentante { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string NumeroDocumento { get; set; }
        public ETipoDocumento TipoDocumento { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string CEP { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(CodigoApresentante, "CodigoApresentante", "O código do apresentante deve ser preenchido.")
                .HasMaxLen(CodigoApresentante, 100, "CodigoApresentante", "O código do apresentante não pode ter mais de 100 caracteres.")
            );

            AddNotifications(new Contract()
              .Requires()
              .IsNotNullOrEmpty(Nome, "Nome", "O nome do apresentante deve ser preenchido.")
              .HasMaxLen(Nome, 100, "Nome", "O nome do apresentante não pode ter mais de 100 caracteres.")
            );

            AddNotifications(new Contract()
              .Requires()
              .IsNotNullOrEmpty(SobreNome, "SobreNome", "O SobreNome do apresentante deve ser preenchido.")
              .HasMaxLen(SobreNome, 100, "SobreNome", "O SobreNome do apresentante não pode ter mais de 100 caracteres.")
            );
        }
    }
}
