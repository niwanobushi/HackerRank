using System.Linq;

namespace HackerRank.Algorithms
{
    /// <summary>
    /// This class contains problems under the algorithms strings section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/domains/algorithms?filters%5Bsubdomains%5D%5B%5D=strings
    /// </summary>
    public static class Strings
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/reduced-string/problem
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The result as a <c>string</c>.
        /// </returns>
        public static string SuperReducedString(string s)
        {
            var i = 0;
            do
            {
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 2);
                    if (i > 0)
                    {
                        i--;
                    }
                    continue;
                }
                i++;
            }
            while (i < s.Length - 1);
            return s != string.Empty ? s : "Empty String";
        }
    }
}
