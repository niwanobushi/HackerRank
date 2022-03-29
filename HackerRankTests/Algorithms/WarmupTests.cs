using HackerRank.Algorithms;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTests.Algorithms
{
    internal class WarmupTests
    {
        [Test]
        [TestCase(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, ExpectedResult = 5000000015)]
        public long AVeryBigSumLinqTest(long[] numbers)
            => Warmup.AVeryBigSumLinq(numbers);

        [Test]
        [TestCase(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, ExpectedResult = 5000000015)]
        public long AVeryBigSumTest(long[] numbers)
            => Warmup.AVeryBigSum(numbers);

        [Test]
        [TestCase(new int[] { 4, 4, 1, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 3, 2, 1, 3 }, ExpectedResult = 2)]
        public long BirthdayCakeCandlesLinqTest(int[] numbers)
            => Warmup.BirthdayCakeCandlesLinq(numbers);

        [Test]
        [TestCase(new int[] { 4, 4, 1, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 3, 2, 1, 3 }, ExpectedResult = 2)]
        public long BirthdayCakeCandlesTest(int[] numbers)
            => Warmup.BirthdayCakeCandles(numbers);

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 5, 6, 7 }, new int[] { 3, 6, 10 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 17, 28, 30 }, new int[] { 99, 16, 8 }, ExpectedResult = new int[] { 2, 1 })]
        public List<int> CompareTheTripletsTest(int[] numbers1, int[] numbers2)
            => Warmup.CompareTriplets(numbers1.ToList(), numbers2.ToList());

        [Test]
        [TestCaseSource(typeof(DiagonalDifferenceTestData), "TestCases")]
        public int DiagonalDifferenceTest(int[][] numbers2D)
            => Warmup.DiagonalDifference(numbers2D.Select(numbers => numbers.ToList()).ToList());

        [Test]
        [TestCase(new int[] { 1, 3, 5, 7, 9 }, ExpectedResult = new int[] { 16, 24 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = new int[] { 10, 14 })]
        [TestCase(new int[] { 7, 69, 2, 221, 8974 }, ExpectedResult = new int[] { 299, 9271 })]
        [TestCase(new int[] { 256741038, 623958417, 467905213, 714532089, 938071625 }, ExpectedResult = new long[] { 2063136757, 2744467344 })]
        public long[] MiniMaxSumTest(int[] numbers)
            => Warmup.MiniMaxSum(numbers);

        [Test]
        [DefaultFloatingPointTolerance(6)]
        [TestCase(new int[] { 1, 1, 0, -1, -1 }, ExpectedResult = new float[] { 0.400000F, 0.400000F, 0.200000F })]
        [TestCase(new int[] { -4, 3, -9, 0, 4, 1 }, ExpectedResult = new float[] { 0.500000F, 0.333333F, 0.166667F })]
        [TestCase(new int[] { 1, 2, 3, -1, -2, -3, 0, 0 }, ExpectedResult = new float[] { 0.375000F, 0.375000F, 0.250000F })]
        public float[] PlusMinusTest(int[] numbers)
            => Warmup.PlusMinus(numbers);

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 4, 10, 11 }, ExpectedResult = 31)]
        public int SimpleArraySumLinqTest(int number, int[] numbers)
            => Warmup.SimpleArraySumLinq(number, numbers);

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 4, 10, 11 }, ExpectedResult = 31)]
        public int SimpleArraySumTest(int number, int[] numbers)
            => Warmup.SimpleArraySum(number, numbers);

        [Test]
        [TestCase(2, 3, ExpectedResult = 5)]
        [TestCase(100, 1000, ExpectedResult = 1100)]
        public int SolveMeFirstTest(int number1, int number2)
            => Warmup.SolveMeFirst(number1, number2);

        [Test]
        [TestCase("12:00:00AM", ExpectedResult = "00:00:00")]
        [TestCase("12:00:00PM", ExpectedResult = "12:00:00")]
        [TestCase("07:05:45PM", ExpectedResult = "19:05:45")]
        public string TimeConversionTest(string text)
            => Warmup.TimeConversion(text);

        // data sources

        public class DiagonalDifferenceTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { 1, 2, 3 },
                            new int[] { 4, 5, 6 },
                            new int[] { 9, 8, 9 }
                        }
                    }).Returns(2);
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { 11, 2, 4 },
                            new int[] { 4, 5, 6 },
                            new int[] { 10, 8, -12 }
                        }
                    }).Returns(15);
                }
            }
        }
    }
}
