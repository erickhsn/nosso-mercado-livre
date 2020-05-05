using NossoMercadoLivre.Domain.DTOs;
using NossoMercadoLivre.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Profile = AutoMapper.Profile;

namespace NossoMercadoLivre.APP.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<UserDTO, User>();
        }
    }
}
