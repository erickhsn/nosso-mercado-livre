using NossoMercadoLivre.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Impl.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; private set; }

        public int CategoryId { get; private set; }

        public Category() { }

        public Category(string nome)
        {
            this.CategoryName = nome;
        }

        public Category(string nome, int categoryId)
        {
            this.CategoryName = nome;
            this.CategoryId = categoryId;
        }
    }
}
