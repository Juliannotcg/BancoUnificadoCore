﻿using BancoUnificadoCore.Shared.Entities;
using Flunt.Validations;
using System;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Apresentante : Entity
    {
        public Apresentante(){}

        public Apresentante(Guid id,string codigoApresentante)
        {
            Id = id;
            CodigoApresentante = codigoApresentante;

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(CodigoApresentante, "CodigoApresentante", "Código do apresentante inválido."));
        }

        public string CodigoApresentante { get; private set; }
        public Pessoa pessoa { get; set; }
    }
}
