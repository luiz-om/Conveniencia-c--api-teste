using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveniencia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conveniencia.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Nome Tabela
            builder.ToTable("Usuario");
            //Chave Primaria
            builder.HasKey(x => x.Id);

            //indenty
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            builder.Property(x => x.Nome)
            .IsRequired()
            .HasColumnName("Nome")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(120);

            builder.Property(x => x.CPF)
            .IsRequired()
            .HasColumnName("CPF")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(11);

            builder.Property(x => x.DataCriacaoAcesso)
            .IsRequired()
            .HasColumnName("DataCriacaoAcesso")
            .HasColumnType("SMALLDATETIME")
            .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.DataCriacaoAcesso)
            .HasColumnName("DataCriacaoAcesso")
            .HasColumnType("SMALLDATETIME");


        }
    }
}