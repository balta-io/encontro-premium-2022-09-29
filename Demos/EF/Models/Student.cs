namespace DapperVsEf.Demos.EF.Models;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateTime? Birthdate { get; set; }
    public DateTime CreateDate { get; set; }
}