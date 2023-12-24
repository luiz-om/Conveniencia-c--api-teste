using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveniencia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conveniencia.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //NomeDaTabela
            builder.ToTable("Produto");
            //Definine Chave Primaria
            builder.HasKey(x => x.Id);
            //Identity
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            //Propriedades
            builder.Property(x => x.Nome)
            .IsRequired()
            .HasColumnName("Nome")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(120);

            builder.Property(x => x.Estoque)
            .IsRequired()
            .HasColumnName("Estoque")
            .HasColumnType("INT");



            builder.Property(x => x.Preco)
            .IsRequired()
            .HasColumnName("Preco")
            .HasColumnType("DECIMAL");

            builder.Property(x => x.Ativo)
            .HasColumnName("Ativo")
            .HasColumnType("BIT");

            //Realacionamento
            builder
            .HasMany(x => x.Fornecedors)
            .WithMany(x => x.Produtos)
            .UsingEntity<Dictionary<string,object>>(
                "ProdutoFornecedor",
                produto => produto
                .HasOne<Fornecedor>()
                .WithMany()
                .HasForeignKey("ProdutoId")
                .HasConstraintName("FK_ProdutoForneedor_ProdutoId")
                .OnDelete(DeleteBehavior.Cascade),
                fornecedor => fornecedor
                .HasOne<Produto>()
                .WithMany()
                .HasForeignKey("FornecedorId")
                .HasConstraintName("FK_ProdutoForneedor_FornecedorId")
                .OnDelete(DeleteBehavior.Cascade));

        }
    }
}