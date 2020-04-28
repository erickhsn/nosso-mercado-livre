using NossoMercadoLivre.Domain.Entities;
using NossoMercadoLivre.Domain.Interfaces.Repositories;
using NossoMercadoLivre.Impl.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Impl.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MLContext context) : base(context)
        {
        }

    }
}
