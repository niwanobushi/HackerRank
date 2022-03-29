using BenchmarkDotNet.Attributes;
using HackerRank.Algorithms;

namespace HackerRank.Benchmarks.Algorithms
{
#pragma warning disable CA1822 // Mark members as static

    [MemoryDiagnoser]
    public class WarmupBenchmarks
    {
        [Benchmark]
        public long AVeryBigSumBenchmark()
            => Warmup.AVeryBigSum(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 });

        [Benchmark]
        public long AVeryBigSumLinqBenchmark()
            => Warmup.AVeryBigSumLinq(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 });

        [Benchmark]
        public int BirthdayCakeCandlesBenchmark()
            => Warmup.BirthdayCakeCandles(new int[] { 4, 4, 1, 3 });

        [Benchmark]
        public int BirthdayCakeCandlesLinqBenchmark()
            => Warmup.BirthdayCakeCandlesLinq(new int[] { 4, 4, 1, 3 });

        [Benchmark]
        public int SimpleArraySumBenchmark()
            => Warmup.SimpleArraySum(6, new int[] { 1, 2, 3, 4, 10, 11 });

        [Benchmark]
        public int SimpleArraySumLinqBenchmark()
            => Warmup.SimpleArraySumLinq(6, new int[] { 1, 2, 3, 4, 10, 11 });
    }

#pragma warning restore CA1822 // Mark members as static
}
