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
        [TestCase(new int[] { 3, 10, 2, 9 }, 1, 12, ExpectedResult = "5")]
        [TestCase(new int[] { 3, 10, 2, 9 }, 1, 7, ExpectedResult = "Bon Appetit")]
        public string BonAppetitLinqTest(int[] numbers, int number1, int number2)
            => Implementation.BonAppetitLinq(numbers.ToList(), number1, number2);

        [Test]
        [TestCase(new int[] { 3, 10, 2, 9 }, 1, 12, ExpectedResult = "5")]
        [TestCase(new int[] { 3, 10, 2, 9 }, 1, 7, ExpectedResult = "Bon Appetit")]
        public string BonAppetitTest(int[] numbers, int number1, int number2)
            => Implementation.BonAppetit(numbers.ToList(), number1, number2);

        [Test]
        [TestCase(new int[] { 12, 24, 10, 24 }, ExpectedResult = new int[] { 1, 1 })]
        [TestCase(new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 }, ExpectedResult = new int[] { 2, 4 })]
        [TestCase(new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }, ExpectedResult = new int[] { 4, 0 })]
        public int[] BreakingRecordsTest(int[] numbers)
            => Implementation.BreakingRecords(numbers);

        [Test]
        [TestCase(new int[] { 100, 90, 90, 80 }, new int[] { 70, 80, 105 }, ExpectedResult = new int[] { 4, 3, 1 })]
        [TestCase(new int[] { 100, 100, 50, 40, 40, 20, 10 }, new int[] { 5, 25, 50, 120 }, ExpectedResult = new int[] { 6, 4, 2, 1 })]
        [TestCase(new int[] { 100, 90, 90, 80, 75, 60 }, new int[] { 50, 65, 77, 90, 102 }, ExpectedResult = new int[] { 6, 5, 4, 2, 1 })]
        public int[] ClimbingLeaderboardLinqTest(int[] numbers1, int[] numbers2)
            => Implementation.ClimbingLeaderboardLinq(numbers1, numbers2);

        [Test]
        [TestCase(new int[] { 100, 90, 90, 80 }, new int[] { 70, 80, 105 }, ExpectedResult = new int[] { 4, 3, 1 })]
        [TestCase(new int[] { 100, 100, 50, 40, 40, 20, 10 }, new int[] { 5, 25, 50, 120 }, ExpectedResult = new int[] { 6, 4, 2, 1 })]
        [TestCase(new int[] { 100, 90, 90, 80, 75, 60 }, new int[] { 50, 65, 77, 90, 102 }, ExpectedResult = new int[] { 6, 5, 4, 2, 1 })]
        public int[] ClimbingLeaderboardTest(int[] numbers1, int[] numbers2)
            => Implementation.ClimbingLeaderboard(numbers1, numbers2);

        [Test]
        [TestCase(1, 2, 3, ExpectedResult = "Cat B")]
        [TestCase(1, 3, 2, ExpectedResult = "Mouse C")]
        public string CatAndMouseTest(int number1, int number2, int number3)
            => Implementation.CatAndMouse(number1, number2, number3);

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
        [TestCase(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },
                  "abc",
                  ExpectedResult = 9)]
        [TestCase(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 },
                  "zaba",
                  ExpectedResult = 28)]
        public int DesignerPdfViewerLinqTest(int[] numbers, string text)
            => Implementation.DesignerPdfViewerLinq(numbers, text);

        [Test]
        [TestCase(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },
                  "abc",
                  ExpectedResult = 9)]
        [TestCase(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 },
                  "zaba",
                  ExpectedResult = 28)]
        public int DesignerPdfViewerTest(int[] numbers, string text)
            => Implementation.DesignerPdfViewer(numbers, text);

        [Test]
        [TestCase(5, 5, new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = 3)]
        [TestCase(6, 3, new int[] { 1, 3, 2, 6, 1, 2 }, ExpectedResult = 5)]
        [TestCase(5, 2, new int[] { 5, 9, 10, 7, 4 }, ExpectedResult = 4)]
        [TestCase(2, 2, new int[] { 8, 10 }, ExpectedResult = 1)]
        public int DivisibleSumPairsTest(int number1, int number2, int[] numbers)
            => Implementation.DivisibleSumPairs(number1, number2, numbers);

        [Test]
        [TestCaseSource(typeof(FormingMagicSquareTestData), "TestCases")]
        public int FormingMagicSquareTest(int[][] numbers2D)
            => Implementation.FormingMagicSquare(numbers2D);

        [Test]
        [TestCase(new int[] { 40, 50, 60 }, new int[] { 5, 8, 12 }, 60, ExpectedResult = 58)]
        [TestCase(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10, ExpectedResult = 9)]
        [TestCase(new int[] { 4 }, new int[] { 5 }, 5, ExpectedResult = -1)]
        public int GetMoneySpentTest(int[] numbers1, int[] numbers2, int number)
            => Implementation.GetMoneySpent(numbers1, numbers2, number);

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
        [TestCase(1, new int[] { 1, 2, 3, 3, 2 }, ExpectedResult = 2)]
        [TestCase(4, new int[] { 1, 6, 3, 5, 2 }, ExpectedResult = 2)]
        [TestCase(7, new int[] { 2, 5, 4, 5, 2 }, ExpectedResult = 0)]
        public int HurdleRaceLinqTest(int number, int[] numbers)
            => Implementation.HurdleRaceLinq(number, numbers);

        [Test]
        [TestCase(1, new int[] { 1, 2, 3, 3, 2 }, ExpectedResult = 2)]
        [TestCase(4, new int[] { 1, 6, 3, 5, 2 }, ExpectedResult = 2)]
        [TestCase(7, new int[] { 2, 5, 4, 5, 2 }, ExpectedResult = 0)]
        public int HurdleRaceTest(int number, int[] numbers)
            => Implementation.HurdleRace(number, numbers);

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

        [Test]
        [TestCase(6, 2, ExpectedResult = 1)]
        [TestCase(5, 4, ExpectedResult = 0)]
        [TestCase(6, 5, ExpectedResult = 1)]
        public int PageCountTest(int number1, int number2)
            => Implementation.PageCount(number1, number2);

        [Test]
        [TestCase(new int[] { 1, 1, 2, 2, 4, 4, 5, 5, 5 }, ExpectedResult = 5)]
        [TestCase(new int[] { 4, 6, 5, 3, 3, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 2, 3, 1, 2 }, ExpectedResult = 5)]
        public int PickingNumbersTest(int[] numbers)
            => Implementation.PickingNumbers(numbers.ToList());

        [Test]
        [TestCase(5, ExpectedResult = 14)]
        [TestCase(0, ExpectedResult = 1)]
        [TestCase(4, ExpectedResult = 7)]
        public int UtopianTreeTest(int number)
            => Implementation.UtopianTree(number);

        // data sources

        public class FormingMagicSquareTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { 5, 3, 4 },
                            new int[] { 1, 5, 8 },
                            new int[] { 6, 4, 2 }
                        }
                    }).Returns(7);
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { 4, 9, 2 },
                            new int[] { 3, 5, 7 },
                            new int[] { 8, 1, 5 }
                        }
                    }).Returns(1);
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { 4, 8, 2 },
                            new int[] { 4, 5, 7 },
                            new int[] { 6, 1, 6 }
                        }
                    }).Returns(4);
                }
            }
        }

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
