using HackerRank;
using NUnit.Framework;
using System.Collections;
using System.Linq;

namespace HackerRankTests
{
    class DictionariesAndHashmapsTests
    {
        [Test]
        [TestCase(new string[] { "give", "me", "one", "grand", "today", "night" },
                  new string[] { "give", "one", "grand", "today" },
                  ExpectedResult = true)]
        [TestCase(new string[] { "ive", "got", "a", "lovely", "bunch", "of", "coconuts" },
                  new string[] { "ive", "got", "some", "coconuts" },
                  ExpectedResult = false)]
        [TestCase(new string[] { "two", "times", "three", "is", "not", "four" },
                  new string[] { "two", "times", "two", "is", "four" },
                  ExpectedResult = false)]
        [TestCaseSource(typeof(SubstrCountTestTestData), "TestCases")]
        public bool CheckMagazineTest(string[] texts1, string[] texts2)
            => DictionariesAndHashmaps.CheckMagazine(texts1, texts2);

        [Test]
        [TestCase("abba", ExpectedResult = 4)]
        [TestCase("abcd", ExpectedResult = 0)]
        [TestCase("ifailuhkqq", ExpectedResult = 3)]
        [TestCase("kkkk", ExpectedResult = 10)]
        [TestCase("cdcd", ExpectedResult = 5)]
        public int SherlockAndAnagramsTest(string text)
            => DictionariesAndHashmaps.SherlockAndAnagrams(text);

        [Test]
        [TestCase("a", "art", ExpectedResult = "YES")]
        [TestCase("be", "cat", ExpectedResult = "NO")]
        [TestCase("hello", "world", ExpectedResult = "YES")]
        [TestCase("hi", "world", ExpectedResult = "NO")]
        [TestCase("wouldyoulikefries", "abcabcabcabcabcabc", ExpectedResult = "NO")]
        [TestCase("hackerrankcommunity", "cdecdecdecde", ExpectedResult = "YES")]
        [TestCase("jackandjill", "wentupthehill", ExpectedResult = "YES")]
        [TestCase("writetoyourparents", "fghmqzldbc", ExpectedResult = "NO")]
        [TestCase("aardvark", "apple", ExpectedResult = "YES")]
        [TestCase("beetroot", "sandals", ExpectedResult = "NO")]
        public string TwoStringsTest(string text1, string text2)
            => DictionariesAndHashmaps.TwoStrings(text1, text2);

        // data sources

        public class SubstrCountTestTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(DataSourceRepository.GetData("SubstrCountTestDataSource01.txt").Select(array => array.Split(' '))
                                                                                                               .ToArray())
                                                                      .Returns(true);
                }
            }
        }
    }
}
