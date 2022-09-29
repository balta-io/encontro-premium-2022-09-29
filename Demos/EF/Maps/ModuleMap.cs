using DapperVsEf.Demos.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperVsEf.Demos.EF.Maps;

public class ModuleMap : IEntityTypeConfiguration<Module>
{
    public void Configure(EntityTypeBuilder<Module> builder)
    {
        // Tabela
        builder.ToTable("Module");

        // Chaves e índices
        builder.HasKey(x => x.Id);

        // Relacionamentos
        builder.HasMany(x => x.Lectures);

        // Propriedades
        builder.Property(x => x.Description).IsRequired().HasColumnType("TEXT");
        builder.Property(x => x.Order).HasColumnType("TINYINT");
        builder.Property(x => x.Title).IsRequired().HasMaxLength(160).HasColumnType("NVARCHAR");
    }
}