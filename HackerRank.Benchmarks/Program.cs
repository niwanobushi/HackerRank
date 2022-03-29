using BenchmarkDotNet.Running;
using HackerRank.Benchmarks.Algorithms;

namespace HackerRank.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // BenchmarkRunner.Run<WarmupBenchmarks>();
            BenchmarkRunner.Run<ImplementationBenchmarks>();
        }
    }
}
