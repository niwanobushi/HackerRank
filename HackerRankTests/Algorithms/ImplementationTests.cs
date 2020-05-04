using HackerRank.Algorithms;
using HackerRankTests.Repositories;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTests.Algorithms
{
    class ImplementationTests
    {
        [Test]
        [TestCase(new int[] { 2, 2, 1, 3, 2 }, 4, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 1, 3, 2 }, 3, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 3, 2, ExpectedResult = 0)]
        [TestCase(new int[] { 4 }, 4, 1, ExpectedResult = 1)]
        public long BirthdayLinqTest(int[] numbers, int number1, int number2)
            => Implementation.BirthdayLinq(numbers.ToList(), number1, number2);

        [Test]
        [TestCase(new int[] { 2, 2, 1, 3, 2 }, 4, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 1, 3, 2 }, 3, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 3, 2, ExpectedResult = 0)]
        [TestCase(new int[] { 4 }, 4, 1, ExpectedResult = 1)]
        public long BirthdayTest(int[] numbers, int number1, int number2)
            => Implementation.Birthday(numbers.ToList(), number1, number2);



        [Test]
        [TestCase(new int[] { 12, 24, 10, 24 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 }, ExpectedResult = new int[] { 2, 4 })]
        [TestCase(new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }, ExpectedResult = new int[] { 4, 0 })]
        public int[] BreakingRecordsTest(int[] numbers)
            => Implementation.BreakingRecords(numbers);



        [Test]
        [TestCase(7, 10, 4, 12, new int[] { 2, 3, -4 }, new int[] { 3, -2, -4 }, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 }, ExpectedResult = new int[] { 1, 1 })]
        public int[] CountApplesAndOrangesLinqTest(int number1, int number2, int number3, int number4, int[] numbers1, int[] numbers2)
            => Implementation.CountApplesAndOrangesLinq(number1, number2, number3, number4, numbers1, numbers2);

        [Test]
        [TestCase(7, 10, 4, 12, new int[] { 2, 3, -4 }, new int[] { 3, -2, -4 }, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 }, ExpectedResult = new int[] { 1, 1 })]
        public int[] CountApplesAndOrangesTest(int number1, int number2, int number3, int number4, int[] numbers1, int[] numbers2)
            => Implementation.CountApplesAndOranges(number1, number2, number3, number4, numbers1, numbers2);

        [Test]
        [TestCase(1984, ExpectedResult = "12.09.1984")]
        [TestCase(2017, ExpectedResult = "13.09.2017")]
        [TestCase(2016, ExpectedResult = "12.09.2016")]
        [TestCase(1800, ExpectedResult = "12.09.1800")]
        public string DayOfProgrammerTest(int number)
            => Implementation.DayOfProgrammer(number);

        [Test]
        [TestCase(5, 5, new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = 3)]
        [TestCase(6, 3, new int[] { 1, 3, 2, 6, 1, 2 }, ExpectedResult = 5)]
        [TestCase(5, 2, new int[] { 5, 9, 10, 7, 4 }, ExpectedResult = 4)]
        [TestCase(2, 2, new int[] { 8, 10 }, ExpectedResult = 1)]
        public int DivisibleSumPairsTest(int number1, int number2, int[] numbers)
            => Implementation.DivisibleSumPairs(number1, number2, numbers);

        [Test]
        [TestCase(new int[] { 2, 6 }, new int[] { 24, 36 }, ExpectedResult = 2)]
        [TestCase(new int[] { 2, 4 }, new int[] { 16, 32, 96 }, ExpectedResult = 3)]
        [TestCase(new int[] { 3, 4 }, new int[] { 24, 48 }, ExpectedResult = 2)]
        public int GetTotalXTest(int[] numbers1, int[] numbers2)
            => Implementation.GetTotalX(numbers1.ToList(), numbers2.ToList());

        [Test]
        [TestCase(new int[] { 73, 67, 38, 33 }, ExpectedResult = new int[] { 75, 67, 40, 33 })]
        public List<int> GradingStudentsLinqTest(int[] numbers)
            => Implementation.GradingStudentsLinq(numbers.ToList());

        [Test]
        [TestCase(new int[] { 73, 67, 38, 33 }, ExpectedResult = new int[] { 75, 67, 40, 33 })]
        public List<int> GradingStudentsTest(int[] numbers)
            => Implementation.GradingStudents(numbers.ToList());

        [Test]
        [TestCase(2, 1, 2, 1, ExpectedResult = "YES")]
        [TestCase(0, 3, 4, 2, ExpectedResult = "YES")]
        [TestCase(0, 2, 5, 3, ExpectedResult = "NO")]
        [TestCase(43, 2, 70, 2, ExpectedResult = "NO")]
        public string KangarooMathTest(int number1, int number2, int number3, int number4)
            => Implementation.KangarooMath(number1, number2, number3, number4);

        [Test]
        [TestCase(2, 1, 2, 1, ExpectedResult = "YES")]
        [TestCase(0, 3, 4, 2, ExpectedResult = "YES")]
        [TestCase(0, 2, 5, 3, ExpectedResult = "NO")]
        [TestCase(43, 2, 70, 2, ExpectedResult = "NO")]
        public string KangarooTest(int number1, int number2, int number3, int number4)
            => Implementation.Kangaroo(number1, number2, number3, number4);

        [Test]
        [DefaultFloatingPointTolerance(6)]
        [TestCase(new int[] { 1, 1, 2, 2, 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 4, 4, 4, 5, 3 }, ExpectedResult = 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }, ExpectedResult = 3)]
        [TestCaseSource(typeof(MigratoryBirdsTestData), "TestCases")]
        public int MigratoryBirdsTest(int[] numbers)
            => Implementation.MigratoryBirds(numbers.ToList());

        // data sources

        public class MigratoryBirdsTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(DataSourceRepository.GetData("MigratoryBirdsTestDataSource01.txt")
                                                                      .SelectMany(array => array.Split(' ')
                                                                                                .Select(text => int.Parse(text)))
                                                                      .ToArray())
                                                                      .Returns(3);
                }
            }
        }
    }
}
