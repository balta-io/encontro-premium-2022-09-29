using DapperVsEf.Demos.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperVsEf.Demos.EF.Maps;

public class StudentLectureMap : IEntityTypeConfiguration<StudentLecture>
{
    public void Configure(EntityTypeBuilder<StudentLecture> builder)
    {
        // Tabela
        builder.ToTable("StudentLecture");

        // Chaves e índices
        builder.HasKey(x => x.Id);

        // Relacionamentos
        builder.HasOne(x => x.Student);
        builder.HasOne(x => x.Lecture);

        // Propriedades (StudentContent)
        builder.Property(x => x.StartDate).HasColumnType("DATETIME");
        builder.Property(x => x.LastUpdateDate).HasColumnType("DATETIME");

        // Propriedades (StudentLecture)
        builder.Property(x => x.Done).HasColumnType("BIT");
    }
}