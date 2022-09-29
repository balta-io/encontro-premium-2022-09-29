using System.ComponentModel.DataAnnotations.Schema;

namespace DapperVsEf.Demos.EF.Models;

public class StudentLectureView
{
    [Column(TypeName = "VARCHAR")] public string Course { get; set; } = string.Empty;
    [Column(TypeName = "VARCHAR")] public string Module { get; set; } = string.Empty;
    // [Column(TypeName = "INT")] public int ModuleOrder { get; set; }

    [Column(TypeName = "UNIQUEIDENTIFIER")]
    public Guid Id { get; set; }

    // [Column(TypeName = "INT")] public int Order { get; set; }
    [Column(TypeName = "VARCHAR")] public string Title { get; set; } = string.Empty;
    // [Column(TypeName = "INT")] public int Level { get; set; }
    // [Column(TypeName = "INT")] public int DurationInMinutes { get; set; }
    [Column(TypeName = "DATETIME")] public DateTime CreateDate { get; set; }
    [Column(TypeName = "VARCHAR")] public string Category { get; set; } = string.Empty;
    [Column(TypeName = "VARCHAR")] public string Author { get; set; } = string.Empty;
}