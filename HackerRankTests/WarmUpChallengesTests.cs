using HackerRank;
using NUnit.Framework;

namespace HackerRankTests
{
    public class WarmUpChallengesTests
    {
        [Test]
        [TestCase(8, "UDDDUDUU", ExpectedResult = 1)]
        [TestCase(12, "DDUUDDUDUUUD", ExpectedResult = 2)]
        public int CountingValleysTest(int n, string s)
            => WarmUpChallenges.CountingValleys(n, s);

        [Test]
        [TestCase(7, new int[] { 1, 2, 1, 2, 1, 3, 2 }, ExpectedResult = 2)]
        [TestCase(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, ExpectedResult = 3)]
        [TestCase(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3, }, ExpectedResult = 4)]
        public int SockMerchantTest(int n, int[] ar)
            => WarmUpChallenges.SockMerchant(n, ar);

        [Test]
        [TestCase("abcac", 10, ExpectedResult = 4)]
        [TestCase("aba", 10, ExpectedResult = 7)]
        [TestCase("a", 1000000000000, ExpectedResult = 1000000000000)]
        [TestCase("epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq", 549382313570, ExpectedResult = 16481469408)]
        public long RepeatedStringTest(string s, long n)
            => WarmUpChallenges.RepeatedString(s, n);

        [Test]
        [TestCase(7, new int[] { 1, 2, 1, 2, 1, 3, 2 }, ExpectedResult = 2)]
        [TestCase(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, ExpectedResult = 3)]
        [TestCase(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3, }, ExpectedResult = 4)]
        public int SockMerchantOnlineTest(int n, int[] ar)
            => WarmUpChallenges.SocketMerchantOnline(n, ar);
    }
}