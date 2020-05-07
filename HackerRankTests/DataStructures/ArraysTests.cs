using HackerRank.DataStructures;
using NUnit.Framework;
using System.Collections;
using System.Linq;

namespace HackerRankTests.DataStructures
{
    class ArraysTests
    {
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
    }
}
