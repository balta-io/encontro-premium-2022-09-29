namespace DapperVsEf.Demos.EF.Models;

public class Module
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Order { get; set; }
    public IEnumerable<Lecture> Lectures { get; set; } = null!;
}