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
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository) 
        {
            _repository = repository;
        }

        public User CreateUser(UserDTO userDTO)
        {
            UserDTOValidator validator = new UserDTOValidator();
            var result = validator.Validate(userDTO);
            if(result.IsValid)
            {
                var user = new User() { Login = userDTO.Login };

                var passwordHash = PasswordCript(userDTO.Password);
                user.CreateDate = DateTime.Now;
                user.PasswordHash = passwordHash;
                _repository.Insert(user);

                user.PasswordHash = "";
                return user;
               
            }
            else
            {
                throw new Exception(result.ToString());
            }
        }

        private string PasswordCript(string password)
        {
            return Helper.GetSha256Hash(new SHA256CryptoServiceProvider(), password);
        }

    }
}
