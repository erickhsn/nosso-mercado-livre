using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime CreateDate { get; private set; }


        // Password deve ser passado sem criptografia


        // Password deve ser passado sem criptografia
        public User(string login, string password)
        {
            this.Login = login;
            this.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
            this.CreateDate = DateTime.Now;
        }

        public User(){ }

    }
}
