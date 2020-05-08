using NossoMercadoLivre.Impl.Context;
using NossoMercadoLivre.Impl.Entities;
using NossoMercadoLivre.Impl.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NossoMercadoLivre.Impl.Repository.Impl
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MLContext _context;
        public CategoryRepository(MLContext context)
        {
            _context = context;
        }

        public Category GetCategoryByName(string name)
        {
            var category = _context.Set<Category>().Where(c => c.CategoryName.Equals(name)).FirstOrDefault();
            return category;
        }

        public void Insert(Category category)
        {
            _context.Set<Category>().Add(category);
            _context.SaveChanges();
        }
    }
}
