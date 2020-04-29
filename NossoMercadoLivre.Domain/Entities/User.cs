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

        public User(string login, string passwordHash, DateTime createDate)
        {
            this.Login = login;
            this.PasswordHash = passwordHash;
            this.CreateDate = createDate;
        }
    }
}
