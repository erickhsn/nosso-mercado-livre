using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NossoMercadoLivre.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Impl.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnName("id").IsRequired();
            builder.Property(u => u.Login).HasColumnName("login").IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnName("password").IsRequired();
            builder.Property(u => u.CreateDate).HasColumnName("create_date").IsRequired();
        }
    }
}
