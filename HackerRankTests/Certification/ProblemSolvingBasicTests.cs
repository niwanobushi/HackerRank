using HackerRank.Certification;
using NUnit.Framework;
using System.Linq;

namespace HackerRankTests.Certification
{
    class ProblemSolvingBasicTests
    {
        [Test]
        [TestCase("51Pa*0Lp*0e", ExpectedResult = "aP1pL5e")]
        public string DecryptPasswordTest(string text)
            => ProblemSolvingBasic.DecryptPassword(text);

        [Test]
        [TestCase(new int[] { 1, 3, 5 }, new int[] { 3, 5, 7 }, ExpectedResult = 6)]
        public long GetMinCostTest(int[] numbers1, int[] numbers2)
            => ProblemSolvingBasic.GetMinCost(numbers1.ToList(), numbers2.ToList());
    }
}
