using NossoMercadoLivre.Domain.Entities;
using NossoMercadoLivre.Domain.Interfaces.Repositories;
using NossoMercadoLivre.Impl.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Impl.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MLContext _context;
        public UserRepository(MLContext context)
        {
            _context = context;
        }

        public void Insert(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }

    }
}
