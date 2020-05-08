using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NossoMercadoLivre.Impl.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Impl.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");


            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("id").IsRequired();
            builder.Property(c => c.CategoryName).HasColumnName("name").IsRequired();
            builder.Property(c => c.CategoryId).HasColumnName("category_id");
        }
    }
}
