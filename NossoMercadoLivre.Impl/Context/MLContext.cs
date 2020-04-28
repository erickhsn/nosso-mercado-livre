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

        private bool _rollBack;
        public IDbContextTransaction Transaction { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }

        #region Transaction
        public IDbContextTransaction Begin() => Transaction ?? (Transaction = this.Database.BeginTransaction());

        public void Commit()
        {
            if (Transaction != null && !_rollBack)
            {
                Transaction.Commit();
                Transaction.Dispose();
                Transaction = null;
            }
        }

        public void RollBack()
        {
            if (Transaction != null && !_rollBack)
            {
                Transaction.Rollback();
                _rollBack = true;
            }
        }
        #endregion

    }
}
