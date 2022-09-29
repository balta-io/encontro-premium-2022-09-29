namespace DapperVsEf.Demos.EF.Models;

public class Author
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public EAuthorType Type { get; set; }
}

public enum EAuthorType
{
    Instructor = 1,
    Contributor = 2
}