using HackerRank.DataStructures;
using HackerRankTests.Repositories;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTests.DataStructures
{
    class ArraysTests
    {
        [Test]
        [TestCaseSource(typeof(DynamicArrayTestData), "TestCases")]
        public List<int> DynamicArrayTest(int number, List<List<int>> numbers2D)
        {
            return Arrays.DynamicArray(number, numbers2D);
        }

        [Test]
        [TestCase(new object[] { new object[] { "aba", "baba", "aba", "xzxb" },
                                 new object[] { "aba", "xzxb", "ab" } },
                  ExpectedResult = new int[] { 2, 1, 0 })]
        [TestCase(new object[] { new object[] { "def", "de", "fgh" },
                                 new object[] { "de", "imn", "fgh" } },
                  ExpectedResult = new int[] { 1, 0, 1 })]
        [TestCase(new object[] { new object[] { "abcde", "sdaklfj", "asdjf", "na", "basdn", "sdaklfj", "asdjf", "na", "asdjf", "na", "basdn", "sdaklfj", "asdjf" },
                                 new object[] { "abcde", "sdaklfj", "asdjf", "na", "basdn" } },
                  ExpectedResult = new int[] { 1, 3, 4, 3, 2 })]
        public int[] MatchingStringsLinqTest(params object[] texts2D)
        {
            var texts2DStringArray = ((IEnumerable)texts2D).Cast<object>()
                                                           .Select(texts => ((IEnumerable)texts).Cast<object>()
                                                                                                .Select(text => text.ToString())
                                                                                                .ToArray())
                                                           .ToArray();
            return Arrays.MatchingStringsLinq(texts2DStringArray[0], texts2DStringArray[1]);
        }

        [Test]
        [TestCase(new object[] { new object[] { "aba", "baba", "aba", "xzxb" },
                                 new object[] { "aba", "xzxb", "ab" } },
                  ExpectedResult = new int[] { 2, 1, 0 })]
        [TestCase(new object[] { new object[] { "def", "de", "fgh" },
                                 new object[] { "de", "imn", "fgh" } },
                  ExpectedResult = new int[] { 1, 0, 1 })]
        [TestCase(new object[] { new object[] { "abcde", "sdaklfj", "asdjf", "na", "basdn", "sdaklfj", "asdjf", "na", "asdjf", "na", "basdn", "sdaklfj", "asdjf" },
                                 new object[] { "abcde", "sdaklfj", "asdjf", "na", "basdn" } },
                  ExpectedResult = new int[] { 1, 3, 4, 3, 2 })]
        public int[] MatchingStringsTest(params object[] texts2D)
        {
            var texts2DStringArray = ((IEnumerable)texts2D).Cast<object>()
                                                           .Select(texts => ((IEnumerable)texts).Cast<object>()
                                                                                                .Select(text => text.ToString())
                                                                                                .ToArray())
                                                           .ToArray();
            return Arrays.MatchingStrings(texts2DStringArray[0], texts2DStringArray[1]);
        }

        [Test]
        [TestCase(new int[] { 1, 4, 3, 2 }, ExpectedResult = new int[] { 2, 3, 4, 1 })]
        public int[] ReverseArrayLinqTest(int[] numbers)
            => Arrays.ReverseArrayLinq(numbers);

        [Test]
        [TestCase(new int[] { 1, 4, 3, 2 }, ExpectedResult = new int[] { 2, 3, 4, 1 })]
        public int[] ReverseArrayTest(int[] numbers)
            => Arrays.ReverseArray(numbers);

        // data sources

        public class DynamicArrayTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(2,
                                                  new List<List<int>>
                                                  {
                                                      new List<int> { 1, 0, 5 },
                                                      new List<int> { 1, 1, 7 },
                                                      new List<int> { 1, 0, 3 },
                                                      new List<int> { 2, 1, 0 },
                                                      new List<int> { 2, 1, 1 },
                                                  })
                                                  .Returns(new List<int> { 7, 3 });

                    yield return new TestCaseData(100,
                                                  DataSourceRepository.GetData("DynamicArrayTestDataSource01.txt")
                                                                      .Select(array => array.Split(' ')
                                                                                            .Select(text => int.Parse(text))
                                                                                            .ToList())
                                                                      .ToList())
                                                                      .Returns(new List<int>
                                                                               {
                                                                                   855677723,
                                                                                   75865401,
                                                                                   763845832,
                                                                                   75865401,
                                                                                   709571211,
                                                                                   645102173,
                                                                                   112869154,
                                                                                   763845832,
                                                                                   449768243,
                                                                                   757848208,
                                                                                   91038209,
                                                                                   205970905,
                                                                                   783321829,
                                                                                   372160176,
                                                                                   384358662,
                                                                                   67467208,
                                                                                   935143105,
                                                                                   384358662,
                                                                                   309720694,
                                                                                   138234911
                                                                               });
                }
            }
        }
    }
}
