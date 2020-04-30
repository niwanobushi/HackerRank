using HackerRank;
using NUnit.Framework;
using System.Collections;

namespace HackerRankTests
{
    class ArraysTests
    {
        [Test]
        [TestCaseSource(typeof(ArrayManipulationTestData), "TestCases")]
        public long ArrayManipulationOnlineTest(int number, int[][] numbers2D)
            => Arrays.ArrayManipulationOnline(number, numbers2D);

        [Test]
        [TestCaseSource(typeof(ArrayManipulationTestData), "TestCases")]
        public long ArrayManipulationTest(int number, int[][] numbers2D)
            => Arrays.ArrayManipulation(number, numbers2D);

        [Test]
        [TestCaseSource(typeof(HourglassSumTestData), "TestCases")]
        public int HourglassSumTest(int[][] numbers2D)
            => Arrays.HourglassSum(numbers2D);

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 0)]
        [TestCase(new int[] { 2, 1, 5, 3, 4 }, ExpectedResult = 3)]
        [TestCase(new int[] { 2, 5, 1, 3, 4 }, ExpectedResult = -1)]
        [TestCase(new int[] { 5, 1, 2, 3, 7, 8, 6, 4 }, ExpectedResult = -1)]
        [TestCase(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 }, ExpectedResult = 7)]
        [TestCase(new int[] { 1, 2, 5, 3, 4, 7, 8, 6 }, ExpectedResult = 4)]
        public int MinimumBribesTest(int[] numbers)
            => Arrays.MinimumBribes(numbers);

        [Test]
        [TestCase(new int[] { 7, 1, 3, 2, 4, 5, 6 }, ExpectedResult = 5)]
        [TestCase(new int[] { 4, 3, 1, 2 }, ExpectedResult = 3)]
        [TestCase(new int[] { 2, 3, 4, 1, 5 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 3, 5, 2, 4, 6, 7 }, ExpectedResult = 3)]
        public int MinimumSwapsTest(int[] numbers)
            => Arrays.MinimumSwaps(numbers);

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, ExpectedResult = new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10, ExpectedResult = new int[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        [TestCase(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13, ExpectedResult = new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
        public int[] RotLeftLinqTest(int[] numbers, int number)
            => Arrays.RotLeftLinq(numbers, number);

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, ExpectedResult = new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10, ExpectedResult = new int[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        [TestCase(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13, ExpectedResult = new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
        public int[] RotLeftTest(int[] numbers, int number)
            => Arrays.RotLeft(numbers, number);

        // data sources

        public class ArrayManipulationTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(5, new int[][]
                    {
                        new int[] { 1, 2, 100 },
                        new int[] { 2, 5, 100 },
                        new int[] { 3, 4, 100 }
                    }).Returns(200);
                    yield return new TestCaseData(10, new int[][]
                    {
                        new int[] { 1, 5, 3 },
                        new int[] { 4, 8, 7 },
                        new int[] { 6, 9, 1 }
                    }).Returns(10);
                    yield return new TestCaseData(10, new int[][]
                    {
                        new int[] { 2, 6, 8 },
                        new int[] { 3, 5, 7 },
                        new int[] { 1, 8, 1 },
                        new int[] { 5, 9, 15 }
                    }).Returns(31);
                }
            }
        }

        public class HourglassSumTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { 1, 1, 1, 0, 0, 0 },
                            new int[] { 0, 1, 0, 0, 0, 0 },
                            new int[] { 1, 1, 1, 0, 0, 0 },
                            new int[] { 0, 0, 2, 4, 4, 0 },
                            new int[] { 0, 0, 0, 2, 0, 0 },
                            new int[] { 0, 0, 1, 2, 4, 0 }
                        }
                    }).Returns(19);
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { -9, -9, -9, 1, 1, 1 },
                            new int[] { 0 ,-9, 0, 4, 3, 2 },
                            new int[] { -9, -9, -9, 1, 2, 3 },
                            new int[] {  0, 0, 8, 6, 6, 0 },
                            new int[] {  0, 0, 0, -2, 0, 0 },
                            new int[] {  0, 0, 1, 2, 4, 0 }
                        }
                    }).Returns(28);
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { -1, -1, 0, -9, -2, -2 },
                            new int[] { -2, -1, -6, -8, -2, -5 },
                            new int[] { -1, -1, -1, -2, -3, -4 },
                            new int[] { -1, -9, -2, -4, -4, -5 },
                            new int[] { -7, -3, -3, -2, -9, -9 },
                            new int[] { -1, -3, -1, -2, -4, -5 }
                        }
                    }).Returns(-6);
                    yield return new TestCaseData(new int[][][]
                    {
                        new int[][]
                        {
                            new int[] { 1, 1, 1, 0, 0, 0 },
                            new int[] { 0, 1, 0, 0, 0, 0 },
                            new int[] { 1, 1, 1, 0, 0, 0 },
                            new int[] { 0, 9, 2, -4, -4, 0 },
                            new int[] { 0, 0, 0, -2, 0, 0 },
                            new int[] { 0, 0, -1, -2, -4, 0 }
                        }
                    }).Returns(13);
                }
            }
        }
    }
}