using DapperVsEf.Demos.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperVsEf.Demos.EF.Maps;

public class AuthorMap : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        // Tabela
        builder.ToTable("Author");

        // Chaves e índices
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Url);

        // Relacionamentos


        // Propriedades
        builder.Property(x => x.Bio).HasColumnType("NVARCHAR").IsRequired().HasMaxLength(2000);
        builder.Property(x => x.Email).HasColumnType("NVARCHAR").IsRequired().HasMaxLength(160);
        builder.Property(x => x.Image).HasColumnType("NVARCHAR").IsRequired().HasMaxLength(1024);
        builder.Property(x => x.Name).HasColumnType("NVARCHAR").IsRequired().HasMaxLength(80);
        builder.Property(x => x.Title).HasColumnType("NVARCHAR").IsRequired().HasMaxLength(80);
        builder.Property(x => x.Type).HasColumnType("TINYINT");
    }
}