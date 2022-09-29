namespace DapperVsEf.Demos.EF.Models;

public class Lecture : Content
{
    public int Order { get; set; }
    public string ContentUrl { get; set; } = string.Empty;
    public ELectureType Type { get; set; }
}

public enum ELectureType
{
    Video = 1,
    Audio = 2,
    Text = 3
}