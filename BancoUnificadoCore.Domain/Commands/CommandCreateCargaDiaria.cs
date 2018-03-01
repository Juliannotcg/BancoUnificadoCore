using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateCargaDiaria : Notifiable, ICommand
    {
        public Guid Id { get; set; }
        public string Protocolo { get; set; }
        public int Livro { get; set; }
        public int Folha { get; set; }
        public int NumeroProtesto { get; set; }
        public string Especie { get; set; }
        public int Numero { get; set; }
        public int NossoNumero { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
        public string Endosso { get; set; }
        public string Aceite { get; set; }
        public bool FinsFalimentares { get; set; }
        public int MotivoProtesto { get; set; }
        public int Sequencial { get; set; }
        public string CodigoApresentante { get; set; }
        public int CodigoCartorio { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string NumeroDocumento { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string CEP { get; set; }

        public DateTime DataProtocolo { get; set; }
        public DateTime DataProtesto { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataAcao { get; set; }

        public EAcao Acao { get; set; }
        public ETipoDocumento TipoDocumento { get; set; }
        public ETipoEnvolvido TipoEnvolvido { get; set; }
        
        //Fail, Fast, Validation
        public void Validate()
        {
            //Validate protocolo
            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(Protocolo, "Protocolo", "O protocolo não deve ser vazio ou nulo.")
                .HasMinLen(Protocolo, 2, "Protocolo", "O protocolo não pode ter menos que 2 caracteres.")
                .HasMaxLen(Protocolo, 20, "Protocolo", "O protocolo não pode ter mais que 20 caracteres.")
                );

            //Validate LIvro e Folha
            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(Livro.ToString(), "Livro", "O livro não deve ser vazio ou nulo.")
                .HasMinLen(Livro.ToString(), 1, "Livro", "O livro não pode ter menos que 1 caracteres.")
                .HasMaxLen(Livro.ToString(), 10, "Livro", "O livro não pode ter mais que 10 caracteres.")
                );
        }

        public bool ValidateDates()
        {
            if (DataProtocolo <= DataProtesto)
                return false;

            if (DataAcao < DataProtesto)
                return false;

            return true;
        }
    }
}
