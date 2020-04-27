using HackerRank;
using NUnit.Framework;

namespace HackerRankTests
{
    class AlgorithmsTests
    {
        [Test]
        [TestCase(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, ExpectedResult = 5000000015)]
        public long AVeryBigSumTest(long[] ar)
            => Algorithms.AVeryBigSum(ar);

        [Test]
        [TestCase(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, ExpectedResult = 5000000015)]
        public long AVeryBigSumLinqTest(long[] ar)
            => Algorithms.AVeryBigSumLinq(ar);

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 4, 10, 11 }, ExpectedResult = 31)]
        public int SimpleArraySumTest(int n, int[] ar)
            => Algorithms.SimpleArraySum(n, ar);

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 4, 10, 11 }, ExpectedResult = 31)]
        public int SimpleArraySumLinqTest(int n, int[] ar)
            => Algorithms.SimpleArraySumLinq(n, ar);

        [Test]
        [TestCase(2, 3, ExpectedResult = 5)]
        [TestCase(100, 1000, ExpectedResult = 1100)]
        public int SolveMeFirstTest(int a, int b)
            => Algorithms.SolveMeFirst(a, b);
    }
}
