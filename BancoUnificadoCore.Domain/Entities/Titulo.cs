using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Entities;
using Flunt.Validations;
using System;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Titulo : Entity
    {
        //Contrutor vazio.
        public Titulo(){}

      
        public Titulo(string protocolo, DateTime dataProtocolo, 
            int livro, int folha, DateTime dataProtesto, 
            int numeroProtesto, DateTime dataEmissao, 
            DateTime dataVencimento, string especie, 
            int numero, int nossoNumero, decimal valor, 
            decimal saldo, string endosso, string aceite, 
            bool finsFalimentares, int motivoProtesto, EAcao acao, DateTime dataAcao, int sequencial, Pessoa pessoa, Apresentante apresentante)
        {
            Protocolo = protocolo;
            DataProtocolo = dataProtocolo;
            Livro = livro;
            Folha = folha;
            DataProtesto = dataProtesto;
            NumeroProtesto = numeroProtesto;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            Especie = especie;
            Numero = numero;
            NossoNumero = nossoNumero;
            Valor = valor;
            Saldo = saldo;
            Endosso = endosso;
            Aceite = aceite;
            FinsFalimentares = finsFalimentares;
            MotivoProtesto = motivoProtesto;
            Acao = acao;
            DataAcao = dataAcao;
            Sequencial = sequencial;
            Pessoa = pessoa;
            Apresentante = apresentante;

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(Protocolo, "Protocolo", "Protocolo inválido")
                .IsNullOrEmpty(DataProtocolo.ToString(), "DataProtocolo", "Data do protocolo inválida.")
                .IsFalse(ValidateData(DataProtesto, DataProtocolo), "DataProtesto", "A data do protesto não pode ser menor que a data de apresentação.")
                );
        }

        public string Protocolo { get; private set; }
        public DateTime DataProtocolo { get; private set; }
        public int Livro { get; private set; }
        public int Folha { get; private set; }
        public DateTime DataProtesto { get; private set; }
        public int NumeroProtesto { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public string Especie { get; private set; }
        public int Numero { get; private set; }
        public int NossoNumero { get; private set; }
        public decimal Valor { get; private set; }
        public decimal Saldo { get; private set; }
        public string Endosso { get; private set; }
        public string Aceite { get; private set; }
        public bool FinsFalimentares { get; private set; }
        public int MotivoProtesto { get; private set; }
        public EAcao Acao { get; private set; }
        public DateTime DataAcao { get; private set; }
        public int Sequencial { get; private set; }
        public Pessoa Pessoa { get; private set; }
        public Apresentante Apresentante { get; private set; }

        public bool ValidateData(DateTime DataProtesto, DateTime DataApresentacao)
        {
            if (DataProtesto <= DataApresentacao)
                return false;
            else
                return true;
        }
    }
}
