using FluentValidation;
using NossoMercadoLivre.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Domain.Interfaces.Services
{
    public interface IService<T> where T : BaseEntity
    {
        T Post<V>(T entity) where V : AbstractValidator<T>;

        T Put<V>(T entity) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
