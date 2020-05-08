using NossoMercadoLivre.Impl.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Impl.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        public Category GetCategoryByName(string name);
        public void Insert(Category category);
    }
}
