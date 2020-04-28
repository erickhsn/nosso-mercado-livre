using NossoMercadoLivre.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
