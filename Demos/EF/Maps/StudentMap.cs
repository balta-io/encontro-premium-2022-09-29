using DapperVsEf.Demos.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperVsEf.Demos.EF.Maps;

public class StudentMap : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        // Tabela
        builder.ToTable("Student");

        // Chaves e índices
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Email);

        // Relacionamentos

        // Propriedades
        builder.Property(x => x.Name).IsRequired().HasMaxLength(120).HasColumnType("NVARCHAR");
        builder.Property(x => x.Email).IsRequired().HasMaxLength(180).HasColumnType("NVARCHAR");
        builder.Property(x => x.Document).HasMaxLength(20).HasColumnType("NVARCHAR");
        builder.Property(x => x.Phone).HasMaxLength(20).HasColumnType("NVARCHAR");
        builder.Property(x => x.Birthdate).HasColumnType("DATETIME");
        builder.Property(x => x.CreateDate).IsRequired().HasColumnType("DATETIME");
    }
}