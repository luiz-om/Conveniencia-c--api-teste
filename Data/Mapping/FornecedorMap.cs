using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveniencia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conveniencia.Data.Mapping
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
           builder.ToTable("Fornecedor");
        }
    }
}