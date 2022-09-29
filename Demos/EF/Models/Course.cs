namespace DapperVsEf.Demos.EF.Models;

public class Course : Content
{
    public string Tag { get; set; } = string.Empty;
    public IEnumerable<Module> Modules { get; set; } = null!;
}