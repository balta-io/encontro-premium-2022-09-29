using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Dapper;
using DapperVsEf.Demos.EF.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DapperVsEf.Demos.EF;

// [SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
// [SimpleJob(RuntimeMoniker.NativeAot70)]
public class EfReadDemos
{
    private readonly BaltaDataContext _context;

    private const string ConnectionString =
        @"Server=localhost,1433;Database=balta-dev;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";

    private const string Query = $@"SELECT
                [Course].[Title] AS [Course],
                [Module].[Title] AS [Module],
                -- [Module].[Order] AS [ModuleOrder],
                [Lecture].[Id],
                -- [Lecture].[Order],
                [Lecture].[Title],
                -- [Lecture].[Level],
                -- [Lecture].[DurationInMinutes],
                [Lecture].[CreateDate],
                [Category].[Title] AS [Category],
                [Author].[Name] AS [Author]
            FROM 
                [StudentLecture]
                INNER JOIN [Lecture] ON [StudentLecture].[LectureId] = [Lecture].[Id]
                INNER JOIN [Module] ON [Lecture].[ModuleId] = [Module].[Id]
                INNER JOIN [Course] ON [Module].[CourseId] = [Course].[Id]
                INNER JOIN [Category] ON [Lecture].[CategoryId] = [Category].[Id]
                INNER JOIN [Author] ON [Lecture].[AuthorId] = [Author].[Id]
            ORDER BY
                [StudentLecture].[LastUpdateDate]";

    public EfReadDemos() => _context = new BaltaDataContext();

    [Benchmark]
    public void ReadAll()
    {
        var data = _context.StudentLectures.ToList();
    }

    [Benchmark]
    public void ReadAllAsNoTracking()
    {
        var data = _context.StudentLectures.AsNoTracking().ToList();
    }

    [Benchmark]
    public void ReadAllAsNoTrackingWithIdentityResolution()
    {
        var data = _context.StudentLectures.AsNoTrackingWithIdentityResolution().ToList();
    }

    [Benchmark]
    public void ReadAllUnormalized()
    {
        var data = _context
            .StudentLectureViews
            .FromSqlRaw(Query)
            .ToList();
    }

    [Benchmark]
    public void ReadAllUnormalizedDapper()
    {
        using (var connection = new SqlConnection(ConnectionString))
        {
            var data = connection.Query<StudentLectureView>(Query);
        }
    }
}