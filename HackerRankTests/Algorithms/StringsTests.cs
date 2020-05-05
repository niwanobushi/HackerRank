using HackerRank.Algorithms;
using NUnit.Framework;

namespace HackerRankTests.Algorithms
{
    class StringsTests
    {
        [Test]
        [TestCase("aaabccddd", ExpectedResult = "abd")]
        [TestCase("aa", ExpectedResult = "Empty String")]
        [TestCase("baab", ExpectedResult = "Empty String")]
        public string BirthdayLinqTest(string text)
            => Strings.SuperReducedString(text);
    }
}
