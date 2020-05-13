using HackerRank.Extensions;
using System;
using System.Collections.Generic;
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
        /// https://www.hackerrank.com/challenges/caesar-cipher-1/problem
        /// </summary>
        /// <param name="s">A <c>string</c> representing a message.</param>
        /// <param name="k">An <c>int</c> representing the alphabet rotation.</param>
        /// <returns>
        /// The encoded message as a <c>string</c>.
        /// </returns>
        public static string CaesarCipher(string s, int k)
        {
            const int AlphabetSize = 26;
            const int AValue = 65;
            const int ZValue = 90;
            const int aValue = 97;
            const int zValue = 122;
            var rotatedIndex = (k + AlphabetSize) % AlphabetSize;
            return new string(s.Select(character =>
                               {
                                   var charIndex = (int)character;
                                   if (charIndex >= AValue && charIndex <= ZValue)
                                   {
                                       var newIndex = (((charIndex - AValue) + rotatedIndex + AlphabetSize) % AlphabetSize) + AValue;
                                       return (char)(newIndex);
                                   }
                                   if (charIndex >= aValue && charIndex <= zValue)
                                   {
                                       var newIndex = (((charIndex - aValue) + rotatedIndex + AlphabetSize) % AlphabetSize) + aValue;
                                       return (char)(newIndex);
                                   }
                                   return character;
                               })
                               .ToArray());
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
        /// https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The result as a <c>string</c>.
        /// </returns>
        public static string HackerrankInString(string s)
        {
            const string HackerRank = "hackerrank";
            var lastIndex = 0;
            for (var i = 0; i < s.Length; i++)
            {
                for (var j = lastIndex; j < HackerRank.Length; j++)
                {
                    if (s[i] == HackerRank[j])
                    {
                        lastIndex++;
                    }
                }
                if (lastIndex == HackerRank.Length)
                {
                    break;
                }
            }
            return lastIndex == HackerRank.Length ? "YES" : "NO";
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The result as a <c>string</c>.
        /// </returns>
        public static string HackerrankInStringQueue(string s)
        {
            const string HackerRank = "hackerrank";
            var queue = new Queue<char>(HackerRank.ToList());
            foreach (var character in s)
            {
                if (character == queue.Peek())
                {
                    queue.Dequeue();
                    if (!queue.Any())
                    {
                        return "YES";
                    }
                }
            }
            return "NO";
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/mars-exploration/problem
        /// </summary>
        /// <param name="s">A <c>string</c> representing a message.</param>
        /// <returns>
        /// The number altered letters in <c>s</c> as an <c>int</c>.
        /// </returns>
        public static int MarsExploration(string s)
        {
            var count = 0;
            for (var i = 0; i < s.Length - 2; i += 3)
            {
                if (s[i] != 'S')
                {
                    count++;
                }
                if (s[i + 1] != 'O')
                {
                    count++;
                }
                if (s[i + 2] != 'S')
                {
                    count++;
                }
            }
            return count;
        }

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
        /// https://www.hackerrank.com/challenges/pangrams/problem
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The result if <c>s</c> is a pangram as a <c>string</c>.
        /// </returns>
        public static string Pangrams(string s)
        {
            var queue = new Queue<char>("abcdefghijklmnopqrstuvwxyz");
            var lowerS = s.ToLower();
            do
            {
                if (!lowerS.Contains(queue.Peek()))
                {
                    return "not pangram";
                }
                queue.Dequeue();
            }
            while (queue.Any());
            return "pangram";
        }

        /// <summary>
        /// This method is an implementation of <c>Pangrams</c> using LINQ.
        /// https://www.hackerrank.com/challenges/pangrams/problem
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The result if <c>s</c> is a pangram as a <c>string</c>.
        /// </returns>
        public static string PangramsLinq(string s)
            => s.Replace(" ", string.Empty)
                .ToLower()
                .Distinct()
                .Count() == 26 ?
                    "pangram" :
                    "not pangram";

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
