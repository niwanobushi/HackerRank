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
        public long AVeryBigSumLinqTest(long[] numbers)
            => Algorithms.AVeryBigSumLinq(numbers);

        [Test]
        [TestCase(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, ExpectedResult = 5000000015)]
        public long AVeryBigSumTest(long[] numbers)
            => Algorithms.AVeryBigSum(numbers);

        [Test]
        [TestCase(new int[] { 2, 2, 1, 3, 2 }, 4, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 1, 3, 2 }, 3, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 3, 2, ExpectedResult = 0)]
        [TestCase(new int[] { 4 }, 4, 1, ExpectedResult = 1)]
        public long BirthdayLinqTest(int[] numbers, int number1, int number2)
            => Algorithms.BirthdayLinq(numbers.ToList(), number1, number2);

        [Test]
        [TestCase(new int[] { 2, 2, 1, 3, 2 }, 4, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 1, 3, 2 }, 3, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 3, 2, ExpectedResult = 0)]
        [TestCase(new int[] { 4 }, 4, 1, ExpectedResult = 1)]
        public long BirthdayTest(int[] numbers, int number1, int number2)
            => Algorithms.Birthday(numbers.ToList(), number1, number2);

        [Test]
        [TestCase(new int[] { 4, 4, 1, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 3, 2, 1, 3 }, ExpectedResult = 2)]
        public long BirthdayCakeCandlesLinqTest(int[] numbers)
            => Algorithms.BirthdayCakeCandlesLinq(numbers);

        [Test]
        [TestCase(new int[] { 4, 4, 1, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 3, 2, 1, 3 }, ExpectedResult = 2)]
        public long BirthdayCakeCandlesTest(int[] numbers)
            => Algorithms.BirthdayCakeCandles(numbers);

        [Test]
        [TestCase(new int[] { 12, 24, 10, 24 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 }, ExpectedResult = new int[] { 2, 4 })]
        [TestCase(new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }, ExpectedResult = new int[] { 4, 0 })]
        public int[] BreakingRecordsTest(int[] numbers)
            => Algorithms.BreakingRecords(numbers);

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 5, 6, 7 }, new int[] { 3, 6, 10 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 17, 28, 30 }, new int[] { 99, 16, 8 }, ExpectedResult = new int[] { 2, 1 })]
        public List<int> CompareTheTripletsTest(int[] numbers1, int[] numbers2)
            => Algorithms.CompareTheTriplets(numbers1.ToList(), numbers2.ToList());

        [Test]
        [TestCase(7, 10, 4, 12, new int[] { 2, 3, -4 }, new int[] { 3, -2, -4 }, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 }, ExpectedResult = new int[] { 1, 1 })]
        public int[] CountApplesAndOrangesLinqTest(int number1, int number2, int number3, int number4, int[] numbers1, int[] numbers2)
            => Algorithms.CountApplesAndOrangesLinq(number1, number2, number3, number4, numbers1, numbers2);

        [Test]
        [TestCase(7, 10, 4, 12, new int[] { 2, 3, -4 }, new int[] { 3, -2, -4 }, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 }, ExpectedResult = new int[] { 1, 1 })]
        public int[] CountApplesAndOrangesTest(int number1, int number2, int number3, int number4, int[] numbers1, int[] numbers2)
            => Algorithms.CountApplesAndOranges(number1, number2, number3, number4, numbers1, numbers2);

        [Test]
        [TestCase(5, 5, new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = 3)]
        [TestCase(6, 3, new int[] { 1, 3, 2, 6, 1, 2 }, ExpectedResult = 5)]
        public int DivisibleSumPairsTest(int number1, int number2, int[] numbers)
            => Algorithms.DivisibleSumPairs(number1, number2, numbers);

        [Test]
        [TestCase(new int[] { 2, 6 }, new int[] { 24, 36 }, ExpectedResult = 2)]
        [TestCase(new int[] { 2, 4 }, new int[] { 16, 32, 96 }, ExpectedResult = 3)]
        [TestCase(new int[] { 3, 4 }, new int[] { 24, 48 }, ExpectedResult = 2)]
        public int GetTotalXTest(int[] numbers1, int[] numbers2)
            => Algorithms.GetTotalX(numbers1.ToList(), numbers2.ToList());

        [Test]
        [TestCase(new int[] { 73, 67, 38, 33 }, ExpectedResult = new int[] { 75, 67, 40, 33 })]
        public List<int> GradingStudentsLinqTest(int[] numbers)
            => Algorithms.GradingStudentsLinq(numbers.ToList());

        [Test]
        [TestCase(new int[] { 73, 67, 38, 33 }, ExpectedResult = new int[] { 75, 67, 40, 33 })]
        public List<int> GradingStudentsTest(int[] numbers)
            => Algorithms.GradingStudents(numbers.ToList());

        [Test]
        [TestCase(2, 1, 2, 1, ExpectedResult = "YES")]
        [TestCase(0, 3, 4, 2, ExpectedResult = "YES")]
        [TestCase(0, 2, 5, 3, ExpectedResult = "NO")]
        [TestCase(43, 2, 70, 2, ExpectedResult = "NO")]
        public string KangarooMathTest(int number1, int number2, int number3, int number4)
            => Algorithms.KangarooMath(number1, number2, number3, number4);

        [Test]
        [TestCase(2, 1, 2, 1, ExpectedResult = "YES")]
        [TestCase(0, 3, 4, 2, ExpectedResult = "YES")]
        [TestCase(0, 2, 5, 3, ExpectedResult = "NO")]
        [TestCase(43, 2, 70, 2, ExpectedResult = "NO")]
        public string KangarooTest(int number1, int number2, int number3, int number4)
            => Algorithms.Kangaroo(number1, number2, number3, number4);

        [Test]
        [DefaultFloatingPointTolerance(6)]
        [TestCase(new int[] { 1, 1, 0, -1, -1 }, ExpectedResult = new float[] { 0.400000F, 0.400000F, 0.200000F })]
        [TestCase(new int[] { -4, 3, -9, 0, 4, 1 }, ExpectedResult = new float[] { 0.500000F, 0.333333F, 0.166667F })]
        [TestCase(new int[] { 1, 2, 3, -1, -2, -3, 0, 0 }, ExpectedResult = new float[] { 0.375000F, 0.375000F, 0.250000F })]
        public float[] PlusMinusTest(int[] numbers)
            => Algorithms.PlusMinus(numbers);

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 4, 10, 11 }, ExpectedResult = 31)]
        public int SimpleArraySumLinqTest(int number, int[] numbers)
            => Algorithms.SimpleArraySumLinq(number, numbers);

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 4, 10, 11 }, ExpectedResult = 31)]
        public int SimpleArraySumTest(int number, int[] numbers)
            => Algorithms.SimpleArraySum(number, numbers);

        [Test]
        [TestCase(2, 3, ExpectedResult = 5)]
        [TestCase(100, 1000, ExpectedResult = 1100)]
        public int SolveMeFirstTest(int number1, int number2)
            => Algorithms.SolveMeFirst(number1, number2);

        [Test]
        [TestCase("12:00:00AM", ExpectedResult = "00:00:00")]
        [TestCase("12:00:00PM", ExpectedResult = "12:00:00")]
        [TestCase("07:05:45PM", ExpectedResult = "19:05:45")]
        public string TimeConversionTest(string text)
            => Algorithms.TimeConversion(text);

    }
}
