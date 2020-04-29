using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NossoMercadoLivre.Domain.Entities;
using NossoMercadoLivre.Impl.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NossoMercadoLivre.Impl.Context
{
    public class MLContext : DbContext
    {
        public MLContext(DbContextOptions<MLContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }


    }
}
