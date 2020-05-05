using Microsoft.Extensions.DependencyInjection;
using NossoMercadoLivre.APP.Services;
using NossoMercadoLivre.Domain.Interfaces.Repositories;
using NossoMercadoLivre.Domain.Interfaces.Services;
using NossoMercadoLivre.Impl.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.CrossCutting.IoC
{
    public class DependencyInjection
    {
        private readonly IServiceCollection _service;

        public DependencyInjection(IServiceCollection service)
        {
            _service = service;
        }

        public void RegisterServices()
        {
            _service.AddScoped<IUserService, UserService>();
        }
        public void RegisterRepositories()
        {
            
        }
    }
}
