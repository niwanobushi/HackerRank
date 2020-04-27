using HackerRank;
using NUnit.Framework;

namespace HackerRankTests
{
    public class CountingValleysTests
    {
        [Test]
        [TestCase(8, "UDDDUDUU", ExpectedResult = 1)]
        [TestCase(12, "DDUUDDUDUUUD", ExpectedResult = 2)]
        public int CountingValleysTest(int n, string s)
            => Exercises.CountingValleys(n, s);
    }
}
