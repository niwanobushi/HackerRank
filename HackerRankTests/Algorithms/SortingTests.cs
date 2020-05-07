using HackerRank.Algorithms;
using NUnit.Framework;

namespace HackerRankTests.Algorithms
{
    class SortingTests
    {
        [Test]
        [TestCase(new object[] { "31415926535897932384626433832795", "1", "3", "10", "3", "5" },
                  ExpectedResult = new string[] { "1", "3", "3", "5", "10", "31415926535897932384626433832795" })]
        [TestCase(new object[] { "8", "1", "2", "100", "12303479849857341718340192371", "3084193741082937", "3084193741082938", "111", "200" },
                  ExpectedResult = new string[] { "1", "2", "8", "100", "111", "200", "3084193741082937", "3084193741082938", "12303479849857341718340192371" })]
        public string[] BigSortingTest(params string[] texts)
            => Sorting.BigSorting(texts);
    }
}
