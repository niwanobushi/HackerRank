using HackerRank;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTests
{
    class AlgorithmsTests
    {
        [Test]
        [TestCase(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, ExpectedResult = 5000000015)]
        public long AVeryBigSumLinqTest(long[] ar)
            => Algorithms.AVeryBigSumLinq(ar);

        [Test]
        [TestCase(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, ExpectedResult = 5000000015)]
        public long AVeryBigSumTest(long[] ar)
            => Algorithms.AVeryBigSum(ar);

        [Test]
        [TestCase(new int[] { 4, 4, 1, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 3, 2, 1, 3 }, ExpectedResult = 2)]
        public long BirthdayCakeCandlesLinqTest(int[] ar)
            => Algorithms.BirthdayCakeCandlesLinq(ar);

        [Test]
        [TestCase(new int[] { 4, 4, 1, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 3, 2, 1, 3 }, ExpectedResult = 2)]
        public long BirthdayCakeCandlesTest(int[] ar)
            => Algorithms.BirthdayCakeCandles(ar);

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 5, 6, 7 }, new int[] { 3, 6, 10 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 17, 28, 30 }, new int[] { 99, 16, 8 }, ExpectedResult = new int[] { 2, 1 })]
        public List<int> CompareTheTripletsTest(int[] a, int[] b)
            => Algorithms.CompareTheTriplets(a.ToList(), b.ToList());

        [Test]
        [TestCase(new int[] { 73, 67, 38, 33 }, ExpectedResult = new int[] { 75, 67, 40, 33 })]
        public List<int> GradingStudentsLinqTest(int[] grades)
            => Algorithms.GradingStudentsLinq(grades.ToList());

        [Test]
        [TestCase(new int[] { 73, 67, 38, 33 }, ExpectedResult = new int[] { 75, 67, 40, 33 })]
        public List<int> GradingStudentsTest(int[] grades)
            => Algorithms.GradingStudents(grades.ToList());

        [Test]
        [DefaultFloatingPointTolerance(6)]
        [TestCase(new int[] { 1, 1, 0, -1, -1 }, ExpectedResult = new float[] { 0.400000F, 0.400000F, 0.200000F })]
        [TestCase(new int[] { -4, 3, -9, 0, 4, 1 }, ExpectedResult = new float[] { 0.500000F, 0.333333F, 0.166667F })]
        [TestCase(new int[] { 1, 2, 3, -1, -2, -3, 0, 0 }, ExpectedResult = new float[] { 0.375000F, 0.375000F, 0.250000F })]
        public float[] PlusMinusTest(int[] arr)
            => Algorithms.PlusMinus(arr);

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 4, 10, 11 }, ExpectedResult = 31)]
        public int SimpleArraySumLinqTest(int n, int[] ar)
            => Algorithms.SimpleArraySumLinq(n, ar);

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 4, 10, 11 }, ExpectedResult = 31)]
        public int SimpleArraySumTest(int n, int[] ar)
            => Algorithms.SimpleArraySum(n, ar);

        [Test]
        [TestCase(2, 3, ExpectedResult = 5)]
        [TestCase(100, 1000, ExpectedResult = 1100)]
        public int SolveMeFirstTest(int a, int b)
            => Algorithms.SolveMeFirst(a, b);

        [Test]
        [TestCase("12:00:00AM", ExpectedResult = "00:00:00")]
        [TestCase("12:00:00PM", ExpectedResult = "12:00:00")]
        [TestCase("07:05:45PM", ExpectedResult = "19:05:45")]
        public string TimeConversionTest(string s)
            => Algorithms.TimeConversion(s);
        
    }
}
