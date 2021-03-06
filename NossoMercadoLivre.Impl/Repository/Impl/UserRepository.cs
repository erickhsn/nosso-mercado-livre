﻿using NossoMercadoLivre.Domain.Entities;
using NossoMercadoLivre.Domain.Interfaces.Repositories;
using NossoMercadoLivre.Impl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public User GetByLogin(string login)
        {
            var user = _context.Set<User>().Where(u => u.Login.Equals(login)).FirstOrDefault();
            return user;
        }

        public void Insert(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }

    }
}
