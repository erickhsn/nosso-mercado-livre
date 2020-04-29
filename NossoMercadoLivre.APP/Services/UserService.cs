using AutoMapper;
using NossoMercadoLivre.APP.Validators;
using NossoMercadoLivre.Domain.Common;
using NossoMercadoLivre.Domain.DTOs;
using NossoMercadoLivre.Domain.Entities;
using NossoMercadoLivre.Domain.Interfaces.Repositories;
using NossoMercadoLivre.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NossoMercadoLivre.APP.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void CreateUser(UserDTO userDTO)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(userDTO.Password);
            var user = new User(userDTO.Login, passwordHash, DateTime.Now);
            _repository.Insert(user);

        }


    }
}
