using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
