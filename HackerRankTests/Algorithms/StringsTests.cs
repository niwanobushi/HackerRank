using HackerRank.Algorithms;
using NUnit.Framework;

namespace HackerRankTests.Algorithms
{
    class StringsTests
    {
        [Test]
        [TestCase("bcdbd", ExpectedResult = 4)]
        [TestCase("beabeefeab", ExpectedResult = 5)]
        [TestCase("asdcbsdcagfsdbgdfanfghbsfdab", ExpectedResult = 8)]
        [TestCase("asvkugfiugsalddlasguifgukvsa", ExpectedResult = 0)]
        public int AlternateTest(string text)
            => Strings.Alternate(text);

        [Test]
        [TestCase("oneTwoThree", ExpectedResult = 3)]
        [TestCase("saveChangesInTheEditor", ExpectedResult = 5)]
        public int CamelcaseTest(string text)
            => Strings.Camelcase(text);

        [Test]
        [TestCase(3, "Ab1", ExpectedResult = 3)]
        [TestCase(11, "#HackerRank", ExpectedResult = 1)]
        public int MinimumNumberTest(int n, string text)
            => Strings.MinimumNumber(n, text);

        [Test]
        [TestCase("aaabccddd", ExpectedResult = "abd")]
        [TestCase("aa", ExpectedResult = "Empty String")]
        [TestCase("baab", ExpectedResult = "Empty String")]
        public string SuperReducedStringTest(string text)
            => Strings.SuperReducedString(text);
    }
}
