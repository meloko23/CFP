using ControleFinanceiroPessoal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Context {
    public class AppDbContext : DbContext {
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Receita>().HasKey(r => r.Id).ToTable("Receitas");
            modelBuilder.Entity<Receita>().Property(r => r.Id).HasColumnName("IdReceita");
            modelBuilder.Entity<Receita>().Property(r => r.IdTipoReceita).HasColumnName("IdTipoReceita");

            modelBuilder.Entity<Despesa>().HasKey(r => r.Id).ToTable("Despesas");
            modelBuilder.Entity<Despesa>().Property(r => r.Id).HasColumnName("IdDespesa");
            modelBuilder.Entity<Despesa>().Property(r => r.IdTipoDespesa).HasColumnName("IdTipoDespesa");

            modelBuilder.Entity<Usuario>().HasKey(r => r.Id).ToTable("Usuarios");
        }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
