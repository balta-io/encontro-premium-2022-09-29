using BenchmarkDotNet.Running;
using DapperVsEf.Demos.EF;

// await using var context = new BaltaDataContext();
// var studentLectures = await context.StudentLectures.AsNoTracking().Take(10).ToListAsync();
// foreach (var item in studentLectures)
//     Console.WriteLine(item.Id);

var summary = BenchmarkRunner.Run<EfReadDemos>();

// var read = new EfReadDemos();
// read.ReadAllUnormalizedDapper();

Console.WriteLine("Terminou");