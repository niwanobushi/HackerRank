using HackerRank.Extensions;
using System;
using System.Linq;
using System.Reflection.PortableExecutable;

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
        /// https://www.hackerrank.com/challenges/two-characters/problem
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The result as an <c>int</c>.
        /// </returns>
        public static int Alternate(string s)
        {
            var count = 0;
            foreach (var permutation in s.Distinct().GetPermutations())
            {
                var isValid = true;
                var subString = s.Where(character1 => permutation.Contains(character1));
                for (var i = 1; i < subString.Count(); i++)
                {
                    if (subString.ElementAt(i) == subString.ElementAt(i - 1))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid && subString.Count() > count)
                {
                    count = subString.Count();
                }
            }
            return count;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/camelcase/problem
        /// </summary>
        /// <param name="s">A <c>string</c> representing a sentence in <c>camelCase</c>.</param>
        /// <returns>
        /// The number of words in <c>s</c> as an <c>int</c>.
        /// </returns>
        public static int Camelcase(string s)
            => s.Count(character => char.IsUpper(character)) + 1;

        /// <summary>
        /// https://www.hackerrank.com/challenges/strong-password/problem
        /// </summary>
        /// <param name="n">An <c>int</c> representing the length of <c>password</c>.</param>
        /// <param name="password">A <c>string</c> representing a password.</param>
        /// <returns>
        /// The number characters needed to make <c>password</c> valid as an <c>int</c>.
        /// </returns>
        public static int MinimumNumber(int n, string password)
        {
            const string SpecialCharacters = "!@#$%^&*()-+";
            var count = 0;
            if (!password.Any(character => char.IsDigit(character)))
            {
                count++;
            }
            if (!password.Any(character => char.IsLower(character)))
            {
                count++;
            }
            if (!password.Any(character => char.IsUpper(character)))
            {
                count++;
            }
            if (!password.Any(character => SpecialCharacters.Contains(character)))
            {
                count++;
            }
            return Math.Max(count, 6 - password.Length);
        }

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
