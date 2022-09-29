using DapperVsEf.Demos.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperVsEf.Demos.EF.Maps;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // Tabela
        builder.ToTable("Category");

        // Chaves e índices
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Url);

        // Relacionamentos


        // Propriedades (Content)
        builder.Property(x => x.Description).IsRequired().HasColumnType("TEXT");
        builder.Property(x => x.Featured).HasColumnType("BIT");
        builder.Property(x => x.Summary).IsRequired().HasMaxLength(2000).HasColumnType("NVARCHAR");
        builder.Property(x => x.Title).IsRequired().HasMaxLength(160).HasColumnType("NVARCHAR");
        builder.Property(x => x.Url).IsRequired().HasMaxLength(1024).HasColumnType("NVARCHAR");
    }
}