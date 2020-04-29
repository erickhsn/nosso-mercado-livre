using NossoMercadoLivre.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public void Insert(User user);
    }
}
