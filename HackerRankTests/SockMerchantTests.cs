using HackerRank;
using NUnit.Framework;

namespace HackerRankTests
{
    public class SockMerchantTests
    {
        [Test]
        [TestCase(7, new int[] { 1, 2, 1, 2, 1, 3, 2 }, ExpectedResult = 2)]
        [TestCase(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, ExpectedResult = 3)]
        [TestCase(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3, }, ExpectedResult = 4)]
        public int SockMerchantTest(int n, int[] ar)
            => Exercises.SockMerchant(n, ar);

        [Test]
        [TestCase(7, new int[] { 1, 2, 1, 2, 1, 3, 2 }, ExpectedResult = 2)]
        [TestCase(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, ExpectedResult = 3)]
        [TestCase(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3, }, ExpectedResult = 4)]
        public int SockMerchantOnlineTest(int n, int[] ar)
            => Exercises.SocketMerchantOnline(n, ar);
    }
}