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
        [TestCase("A", 1, ExpectedResult = "B")]
        [TestCase("a", 1, ExpectedResult = "b")]
        [TestCase("W", 1, ExpectedResult = "X")]
        [TestCase("W", 1, ExpectedResult = "X")]
        [TestCase("W", 3, ExpectedResult = "Z")]
        [TestCase("w", 1, ExpectedResult = "x")]
        [TestCase("w", 1, ExpectedResult = "x")]
        [TestCase("w", 3, ExpectedResult = "z")]
        [TestCase("Z", 1, ExpectedResult = "A")]
        [TestCase("z", 1, ExpectedResult = "a")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", 3, ExpectedResult = "defghijklmnopqrstuvwxyzabc")]
        [TestCase("Always-Look-on-the-Bright-Side-of-Life", 5, ExpectedResult = "Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj")]
        [TestCase("middle-Outz", 2, ExpectedResult = "okffng-Qwvb")]
        public string CaesarCipherTest(string text, int number)
            => Strings.CaesarCipher(text, number);

        [Test]
        [TestCase("oneTwoThree", ExpectedResult = 3)]
        [TestCase("saveChangesInTheEditor", ExpectedResult = 5)]
        public int CamelcaseTest(string text)
            => Strings.Camelcase(text);

        [Test]
        [TestCase("hereiamstackerrank", ExpectedResult = "YES")]
        [TestCase("hackerworld", ExpectedResult = "NO")]
        [TestCase("hhaacckkekraraannk", ExpectedResult = "YES")]
        [TestCase("hhaacckkekraraannkabc", ExpectedResult = "YES")]
        [TestCase("rhbaasdndfsdskgbfefdbrsdfhuyatrjtcrtyytktjjt", ExpectedResult = "NO")]
        public string HackerrankInQueueTest(string text)
            => Strings.HackerrankInStringQueue(text);

        [Test]
        [TestCase("hereiamstackerrank", ExpectedResult = "YES")]
        [TestCase("hackerworld", ExpectedResult = "NO")]
        [TestCase("hhaacckkekraraannk", ExpectedResult = "YES")]
        [TestCase("rhbaasdndfsdskgbfefdbrsdfhuyatrjtcrtyytktjjt", ExpectedResult = "NO")]
        public string HackerrankInStringTest(string text)
            => Strings.HackerrankInString(text);

        [Test]
        [TestCase("SOSTOT", ExpectedResult = 2)]
        [TestCase("SOSSPSSQSSOR", ExpectedResult = 3)]
        [TestCase("SOSSOT", ExpectedResult = 1)]
        [TestCase("SOSSOSSOS", ExpectedResult = 0)]
        public int MarsExplorationTest(string text)
            => Strings.MarsExploration(text);

        [Test]
        [TestCase(3, "Ab1", ExpectedResult = 3)]
        [TestCase(11, "#HackerRank", ExpectedResult = 1)]
        public int MinimumNumberTest(int n, string text)
            => Strings.MinimumNumber(n, text);

        [Test]
        [TestCase("The quick brown fox jumps over the lazy dog", ExpectedResult = "pangram")]
        [TestCase("We promptly judged antique ivory buckles for the next prize", ExpectedResult = "pangram")]
        [TestCase("We promptly judged antique ivory buckles for the prize", ExpectedResult = "not pangram")]
        public string PangramsLinqTest(string text)
            => Strings.PangramsLinq(text);

        [Test]
        [TestCase("The quick brown fox jumps over the lazy dog", ExpectedResult = "pangram")]
        [TestCase("We promptly judged antique ivory buckles for the next prize", ExpectedResult = "pangram")]
        [TestCase("We promptly judged antique ivory buckles for the prize", ExpectedResult = "not pangram")]
        public string PangramsTest(string text)
            => Strings.Pangrams(text);

        [Test]
        [TestCase("aaabccddd", ExpectedResult = "abd")]
        [TestCase("aa", ExpectedResult = "Empty String")]
        [TestCase("baab", ExpectedResult = "Empty String")]
        public string SuperReducedStringTest(string text)
            => Strings.SuperReducedString(text);
    }
}
