using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveniencia.Data.Mapping;
using Conveniencia.Model;
using Microsoft.EntityFrameworkCore;

namespace Conveniencia.Data
{
    public class ConvenienciaContext : DbContext
    {
public DbSet<Fornecedor> Fornecedors {get;set;}
public DbSet<Produto> Produtos { get; set; }
public DbSet<Usuario> Usuarios {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Conveniencia;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.ApplyConfiguration(new ProdutoMap());
          //modelBuilder.ApplyConfiguration(new UsuarioMap());
          //modelBuilder.ApplyConfiguration(new FornecedorMap());
        }

    }
}