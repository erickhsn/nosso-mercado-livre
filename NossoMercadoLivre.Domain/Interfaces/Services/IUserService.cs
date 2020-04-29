using NossoMercadoLivre.Domain.DTOs;
using NossoMercadoLivre.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Domain.Interfaces.Services
{
    public interface IUserService
    {
        void CreateUser(UserDTO userDTO);
    }
}
