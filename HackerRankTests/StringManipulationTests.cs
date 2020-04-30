using HackerRank;
using NUnit.Framework;

namespace HackerRankTests
{
    class StringManipulationTests
    {
        [Test]
        [TestCase("AABAAB", ExpectedResult = 2)]
        [TestCase("AAAA", ExpectedResult = 3)]
        [TestCase("BBBBB", ExpectedResult = 4)]
        [TestCase("ABABABAB", ExpectedResult = 0)]
        [TestCase("BABABA", ExpectedResult = 0)]
        [TestCase("AAABBB", ExpectedResult = 4)]
        [TestCase("AAABBBAABB", ExpectedResult = 6)]
        [TestCase("AABBAABB", ExpectedResult = 4)]
        [TestCase("ABABABAA", ExpectedResult = 1)]
        [TestCase("ABBABBAA", ExpectedResult = 3)]
        public int AlternatingCharactersLinqTest(string text)
            => StringManipulation.AlternatingCharactersLinq(text);

        [Test]
        [TestCase("AABAAB", ExpectedResult = 2)]
        [TestCase("AAAA", ExpectedResult = 3)]
        [TestCase("BBBBB", ExpectedResult = 4)]
        [TestCase("ABABABAB", ExpectedResult = 0)]
        [TestCase("BABABA", ExpectedResult = 0)]
        [TestCase("AAABBB", ExpectedResult = 4)]
        [TestCase("AAABBBAABB", ExpectedResult = 6)]
        [TestCase("AABBAABB", ExpectedResult = 4)]
        [TestCase("ABABABAA", ExpectedResult = 1)]
        [TestCase("ABBABBAA", ExpectedResult = 3)]
        public int AlternatingCharactersTest(string text)
            => StringManipulation.AlternatingCharacters(text);

        [Test]
        [TestCase("abcc", ExpectedResult = "YES")]
        [TestCase("aabbcd", ExpectedResult = "NO")]
        [TestCase("aabbccddeefghi", ExpectedResult = "NO")]
        [TestCase("abcdefghhgfedecba", ExpectedResult = "YES")]
        [TestCase("aaaaabc", ExpectedResult = "NO")]
        [TestCase("ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd",
                  ExpectedResult = "YES")]
        public string IsValidTest(string text)
            => StringManipulation.IsValid(text);

        [Test]
        [TestCase("cde", "dcf", ExpectedResult = 2)]
        [TestCase("cde", "abc", ExpectedResult = 4)]
        [TestCase("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke", ExpectedResult = 30)]
        [TestCase("showman", "woman", ExpectedResult = 2)]
        public int MakeAnagramOnlineTest(string text1, string text2)
            => StringManipulation.MakeAnagramOnline(text1, text2);

        [Test]
        [TestCase("cde", "dcf", ExpectedResult = 2)]
        [TestCase("cde", "abc", ExpectedResult = 4)]
        [TestCase("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke", ExpectedResult = 30)]
        [TestCase("showman", "woman", ExpectedResult = 2)]
        public int MakeAnagramTest(string text1, string text2)
            => StringManipulation.MakeAnagram(text1, text2);

        [Test]
        [TestCase(8, "mnonopoo", ExpectedResult = 12)]
        [TestCase(5, "asasd", ExpectedResult = 7)]
        [TestCase(7, "abcbaba", ExpectedResult = 10)]
        [TestCase(4, "aaaa", ExpectedResult = 10)]
        public long SubstrCountLinqTest(int number, string text)
            => StringManipulation.SubstrCountLinq(number, text);

        [Test]
        [TestCase(8, "mnonopoo", ExpectedResult = 12)]
        [TestCase(5, "asasd", ExpectedResult = 7)]
        [TestCase(7, "abcbaba", ExpectedResult = 10)]
        [TestCase(4, "aaaa", ExpectedResult = 10)]
        public long SubstrCountTest(int number, string text)
            => StringManipulation.SubstrCount(number, text);
    }
}
