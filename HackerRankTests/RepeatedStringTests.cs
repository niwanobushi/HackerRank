using HackerRank;
using NUnit.Framework;

namespace HackerRankTests
{
    public class RepeatedStringTests
    {
        [Test]
        [TestCase("abcac", 10, ExpectedResult = 4)]
        [TestCase("aba", 10, ExpectedResult = 7)]
        [TestCase("a", 1000000000000, ExpectedResult = 1000000000000)]
        [TestCase("epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq",
                  549382313570,
                  ExpectedResult = 16481469408)]
        public long RepeatedStringTest(string s, long n)
            => Exercises.RepeatedString(s, n);
    }
}
