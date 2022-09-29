using DapperVsEf.Demos.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperVsEf.Demos.EF.Maps;

public class LectureMap : IEntityTypeConfiguration<Lecture>
{
    public void Configure(EntityTypeBuilder<Lecture> builder)
    {
        // Tabela
        builder.ToTable("Lecture");

        // Chaves e índices
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Url);
        builder.HasIndex(x => x.Tags);

        // Relacionamentos
        builder.HasOne(x => x.Author);
        builder.HasOne(x => x.Category);

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
        builder.Property(x => x.Order).HasColumnType("TINYINT");
        builder.Property(x => x.Type).HasColumnType("TINYINT");
        builder.Property(x => x.ContentUrl).IsRequired().HasMaxLength(1024).HasColumnType("NVARCHAR");
    }
}