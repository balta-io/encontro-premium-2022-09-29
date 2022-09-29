namespace DapperVsEf.Demos.EF.Models;

public class Content
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public EContentLevel Level { get; set; }
    public int DurationInMinutes { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public bool Active { get; set; }
    public bool Free { get; set; }
    public bool Featured { get; set; }
    public Author Author { get; set; } = null!;
    public Category Category { get; set; } = null!;
    public string Tags { get; set; } = string.Empty;
}

public enum EContentLevel
{
    Beginner = 1,
    Basic = 2,
    Intermediate = 3,
    Advanced = 4,
    Master = 5
}