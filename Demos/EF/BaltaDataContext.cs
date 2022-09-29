using DapperVsEf.Demos.EF.Maps;
using DapperVsEf.Demos.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace DapperVsEf.Demos.EF;

public class BaltaDataContext : DbContext
{
    private const string ConnectionString = @"Server=localhost,1433;Database=balta-dev;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConnectionString);

    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Module> Modules { get; set; } = null!;
    public DbSet<Lecture> Lectures { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<StudentLecture> StudentLectures { get; set; } = null!;
    public DbSet<StudentLectureView> StudentLectureViews { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorMap());
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new LectureMap());
        modelBuilder.ApplyConfiguration(new ModuleMap());
        modelBuilder.ApplyConfiguration(new CourseMap());
        modelBuilder.ApplyConfiguration(new StudentMap());
        modelBuilder.ApplyConfiguration(new StudentLectureMap());
    }
}