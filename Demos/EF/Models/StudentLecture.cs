namespace DapperVsEf.Demos.EF.Models;

public class StudentLecture
{
    public Guid Id { get; set; }
    public Student Student { get; set; } = null!;
    public Guid StudentId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? LastUpdateDate { get; set; }
    public Lecture Lecture { get; set; }= null!;
    public Guid LectureId { get; set; }
    public bool Done { get; set; }
}