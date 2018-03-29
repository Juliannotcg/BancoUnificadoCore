using BancoUnificadoCore.Shared;
using BancoUnificadoCore.Shared.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Usuario : Entity
    {
        public Usuario(string login, string email, string senha)
        {
            Login = login;
            Email = email;
            Senha = senha;
        }

        protected Usuario() { }

        public string Login { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        #region Senha
        public void SetSenha(string senha, string confirmSenha)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(senha, "Senha", "A senha deve ser preenchida.")
                .AreEquals(senha, confirmSenha, "Senha", "A senha e a confirmação de senha devem ser iguais.")
            );
            this.Senha = SenhaUtils.Encrypt(senha);
        }
        public string ResetSenha()
        {
            string senha = Guid.NewGuid().ToString().Substring(0, 8);
            this.Senha = SenhaUtils.Encrypt(senha);

            return senha;
        }
        #endregion
    }
}
