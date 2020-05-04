using System;
using System.Linq;

namespace HackerRank
{
    /// <summary>
    /// This class contains problems under the strings section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/interview/interview-preparation-kit/strings/challenges
    /// </summary>
    public static class StringManipulation
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/alternating-characters/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The minimum number of deletions required as an <c>int</c>.
        /// </returns>
        public static int AlternatingCharacters(string s)
        {
            var deleteCount = 0;
            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    deleteCount++;
                }
            }
            return deleteCount;
        }

        /// <summary>
        /// This method is an implementation of <c>AlternatingCharacters</c> using LINQ.
        /// https://www.hackerrank.com/challenges/alternating-characters/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The minimum number of deletions required as an <c>int</c>.
        /// </returns>
        public static int AlternatingCharactersLinq(string s)
            => s.Where((letter, index) => index + 1 < s.Length && letter == s[index + 1])
                .Count();

        /// <summary>
        /// https://www.hackerrank.com/challenges/common-child/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        /// </summary>
        /// <param name="s1">A <c>string</c>.</param>
        /// <param name="s2">A <c>string</c>.</param>
        /// <returns>
        /// The length of the longest child <c>string</c> as an <c>int</c>.
        /// </returns>
        public static int CommonChild(string s1, string s2)
        {
            var matrix = new int[s1.Length + 1, s2.Length + 1];
            for (var i = 0; i < s1.Length; i++)
            {
                for (var j = 0; j < s2.Length; j++)
                {
                    var matrixI = i + 1;
                    var matrixJ = j + 1;
                    matrix[matrixI, matrixJ] = s1[i] == s2[j] ?
                                                   matrix[matrixI - 1, matrixJ - 1] + 1 :
                                                   Math.Max(matrix[matrixI - 1, matrixJ], matrix[matrixI, matrixJ - 1]);
                }
            }
            return matrix[s1.Length, s2.Length];
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The the validity of <c>s</c> as a <c>string</c>.
        /// </returns>
        public static string IsValid(string s)
        {
            const string GoodResult = "YES";
            const string BadResult = "NO";
            if (s.Length <= 3)
            {
                return GoodResult;
            }
            var letters = s.Distinct()
                           .Select(letter1 => s.Count(letter2 => letter1 == letter2))
                           .OrderBy(letter => letter);
            var max = letters.Last();
            var min = letters.First();
            if (min == max)
            {
                return GoodResult;
            }
            if (max - min == 1 && max > letters.ElementAt(letters.Count() - 2) || min == 1 && letters.ElementAt(1) == max)
            {
                return GoodResult;
            }
            return BadResult;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        /// </summary>
        /// <param name="a">A <c>string</c>.</param>
        /// <param name="b">A <c>string</c>.</param>
        /// <returns>
        /// The the number of characters that must be deleted to make <c>a</c> and <c>b</c> anagrams as an <c>int</c>.
        /// </returns>
        public static int MakeAnagram(string a, string b)
            => a.Concat(b).Distinct()
                          .Select(letter => Math.Abs(a.Count(c => c == letter) - b.Count(c => c == letter)))
                          .Sum();

        /// <summary>
        /// This is the submitted version.
        /// https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        /// </summary>
        /// <param name="a">A <c>string</c>.</param>
        /// <param name="b">A <c>string</c>.</param>
        /// <returns>
        /// The the number of characters that must be deleted to make <c>a</c> and <c>b</c> anagrams as an <c>int</c>.
        /// </returns>
        public static int MakeAnagramOnline(string a, string b)
            => string.Concat(a, b).Distinct()
                                  .Select(letter => Math.Abs(a.Count(c => c == letter) - b.Count(c => c == letter)))
                                  .Sum();

        /// <summary>
        /// https://www.hackerrank.com/challenges/special-palindrome-again/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        /// </summary>
        /// <param name="n">An <c>int</c> representing the length of <c>s</c>.</param>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The count of special substrings as a <c>long</c>.
        /// </returns>
        public static long SubstrCount(int n, string s)
        {
            long total = n;
            for (var i = 0; i < n; i++)
            {
                var differentLetterIndex = -1;
                for (var j = i + 1; j < n; j++)
                {
                    if (s[i] == s[j])
                    {
                        if (differentLetterIndex == -1 || differentLetterIndex - i == j - differentLetterIndex)
                        {
                            total++;
                        }
                    }
                    else if (differentLetterIndex == -1)
                    {
                        differentLetterIndex = j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return total;
        }

        /// <summary>
        /// This method is an implementation of <c>SubstrCount</c> using LINQ.
        /// https://www.hackerrank.com/challenges/special-palindrome-again/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        /// </summary>
        /// <param name="n">An <c>int</c> representing the length of <c>s</c>.</param>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The count of special substrings as a <c>long</c>.
        /// </returns>
        public static long SubstrCountLinq(int n, string s)
        {
            var subStrings = Enumerable.Range(1, n)
                                       .SelectMany(i => Enumerable.Range(0, n - i + 1)
                                                                  .Select(j => s.Substring(j, i)))
                                       .ToList();
            return subStrings.Where(subString => subString.All(letter => letter == subString.First()) ||
                                                 subString.Substring(0, subString.Length / 2).All(letter => letter == subString.First()) &&
                                                 subString.Substring(subString.Length - subString.Length / 2).All(letter => letter == subString.First()))
                             .LongCount();
        }
    }
}
