using DapperVsEf.Demos.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperVsEf.Demos.EF.Maps;

public class CourseMap : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        // Tabela
        builder.ToTable("Course");

        // Chaves e índices
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Url);
        builder.HasIndex(x => x.Tags);

        // Relacionamentos
        builder.HasOne(x => x.Author);
        builder.HasOne(x => x.Category);
        builder.HasMany(x => x.Modules);

        // Propriedades (Content)
        builder.Property(x => x.Active).HasColumnType("BIT");
        builder.Property(x => x.Featured).HasColumnType("BIT");
        builder.Property(x => x.Free).HasColumnType("BIT");
        builder.Property(x => x.Level).HasColumnType("TINYINT");
        builder.Property(x => x.Summary).IsRequired().HasMaxLength(2000).HasColumnType("NVARCHAR");
        builder.Property(x => x.Tags).IsRequired().HasMaxLength(160).HasColumnType("NVARCHAR");
        builder.Property(x => x.Title).IsRequired().HasMaxLength(160).HasColumnType("NVARCHAR");
        builder.Property(x => x.Url).IsRequired().HasMaxLength(1024).HasColumnType("NVARCHAR");
        builder.Property(x => x.CreateDate).HasColumnType("DATETIME");
        builder.Property(x => x.DurationInMinutes).HasColumnType("INT");
        builder.Property(x => x.LastUpdateDate).HasColumnType("DATETIME");

        // Propriedades (Lecture)
        builder.Property(x => x.Tag).HasColumnType("NVARCHAR").IsRequired().HasMaxLength(20);
    }
}