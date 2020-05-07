using HackerRank.DataStructures;
using NUnit.Framework;

namespace HackerRankTests.DataStructures
{
    class ArraysTests
    {
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
