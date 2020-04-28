using HackerRank;
using NUnit.Framework;
using System.Collections;

namespace HackerRankTests
{
    class ArraysTests
    {
        [Test]
        [TestCaseSource(typeof(HourglassSumTestData), "TestCases")]
        public int HourglassSumTest(int[][] arr)
            => Arrays.HourglassSum(arr);

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 0)]
        [TestCase(new int[] { 2, 1, 5, 3, 4 }, ExpectedResult = 3)]
        [TestCase(new int[] { 2, 5, 1, 3, 4 }, ExpectedResult = -1)]
        [TestCase(new int[] { 5, 1, 2, 3, 7, 8, 6, 4 }, ExpectedResult = -1)]
        [TestCase(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 }, ExpectedResult = 7)]
        [TestCase(new int[] { 1, 2, 5, 3, 4, 7, 8, 6 }, ExpectedResult = 4)]
        public int MinimumBribesTest(int[] q)
            => Arrays.MinimumBribes(q);

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, ExpectedResult = new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10, ExpectedResult = new int[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        [TestCase(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13, ExpectedResult = new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
        public int[] RotLeftLinqTest(int[] a, int d)
            => Arrays.RotLeftLinq(a, d);

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, ExpectedResult = new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10, ExpectedResult = new int[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        [TestCase(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13, ExpectedResult = new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
        public int[] RotLeftTest(int[] a, int d)
            => Arrays.RotLeft(a, d);

        // data sources

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