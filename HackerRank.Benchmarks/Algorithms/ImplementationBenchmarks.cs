using BenchmarkDotNet.Attributes;
using HackerRank.Algorithms;
using System.Collections.Generic;

namespace HackerRank.Benchmarks.Algorithms
{
#pragma warning disable CA1822 // Mark members as static

    [MemoryDiagnoser]
    public class ImplementationBenchmarks
    {
        [Benchmark]
        public string AngryProfessorBenchmark()
            => Implementation.AngryProfessor(3, new int[] { -1, -3, 4, 2 });

        [Benchmark]
        public string AngryProfessorLinqBenchmark()
            => Implementation.AngryProfessorLinq(3, new int[] { -1, -3, 4, 2 });

        [Benchmark]
        public int BeautifulDaysBenchmark()
            => Implementation.BeautifulDays(20, 23, 6);

        [Benchmark]
        public int BeautifulDaysLinqBenchmark()
            => Implementation.BeautifulDaysLinq(20, 23, 6);

        [Benchmark]
        public int BirthdayBenchmark()
            => Implementation.Birthday(new List<int> { 2, 2, 1, 3, 2 }, 4, 2);

        [Benchmark]
        public int BirthdayLinqBenchmark()
            => Implementation.BirthdayLinq(new List<int> { 2, 2, 1, 3, 2 }, 4, 2);

        [Benchmark]
        public string BonAppetitBenchmark()
            => Implementation.BonAppetit(new List<int> { 3, 10, 2, 9 }, 1, 7);

        [Benchmark]
        public string BonAppetitLinqBenchmark()
            => Implementation.BonAppetitLinq(new List<int> { 3, 10, 2, 9 }, 1, 7);

        [Benchmark]
        public int[] ClimbingLeaderboardBenchmark()
            => Implementation.ClimbingLeaderboard(new int[] { 100, 100, 50, 40, 40, 20, 10 }, new int[] { 5, 25, 50, 120 });

        [Benchmark]
        public int[] ClimbingLeaderboardLinqBenchmark()
            => Implementation.ClimbingLeaderboardLinq(new int[] { 100, 100, 50, 40, 40, 20, 10 }, new int[] { 5, 25, 50, 120 });

        [Benchmark]
        public int[] CountApplesAndOrangesBenchmark()
            => Implementation.CountApplesAndOranges(7, 10, 4, 12, new int[] { 2, 3, -4 }, new int[] { 3, -2, -4 });

        [Benchmark]
        public int[] CountApplesAndOrangesLinqBenchmark()
            => Implementation.CountApplesAndOrangesLinq(7, 10, 4, 12, new int[] { 2, 3, -4 }, new int[] { 3, -2, -4 });

        [Benchmark]
        public int DesignerPdfViewerBenchmark()
            => Implementation.DesignerPdfViewer(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 }, "zaba");

        [Benchmark]
        public int DesignerPdfViewerLinqBenchmark()
            => Implementation.DesignerPdfViewerLinq(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 }, "zaba");

        [Benchmark]
        public List<int> GradingStudentsBenchmark()
            => Implementation.GradingStudents(new List<int> { 73, 67, 38, 33 });

        [Benchmark]
        public List<int> GradingStudentsLinqBenchmark()
            => Implementation.GradingStudentsLinq(new List<int> { 73, 67, 38, 33 });

        [Benchmark]
        public int HurdleRaceBenchmark()
            => Implementation.HurdleRace(4, new int[] { 1, 6, 3, 5, 2 });

        [Benchmark]
        public int HurdleRaceLinqBenchmark()
            => Implementation.HurdleRaceLinq(4, new int[] { 1, 6, 3, 5, 2 });
    }

#pragma warning restore CA1822 // Mark members as static
}
