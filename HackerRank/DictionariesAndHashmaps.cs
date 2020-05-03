using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    /// <summary>
    /// This class contains problems under the dictionaries and hashmaps section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/interview/interview-preparation-kit/dictionaries-hashmaps/challenges
    /// </summary>
    public static class DictionariesAndHashmaps
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-ransom-note/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        /// </summary>
        /// <param name="magazine">An <c>array</c> of <c>string</c> representing a magazine.</param>
        /// <param name="note">An <c>array</c> of <c>string</c> representing a note to created.</param>
        /// <returns>
        /// The possibility of creating the note using the magazine as a <c>bool</c>.
        /// </returns>
        public static bool CheckMagazine(string[] magazine, string[] note)
        {
            var countByWord = magazine.GroupBy(word => word)
                                      .ToDictionary(group => group.Key,
                                                    group => group.Count());
            for (var i = 0; i < note.Length; i++)
            {
                if (countByWord.ContainsKey(note[i]) && countByWord[note[i]] > 0)
                {
                    countByWord[note[i]]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// This is the submitted version using <c>Console.WriteLine</c>.
        /// https://www.hackerrank.com/challenges/ctci-ransom-note/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        /// </summary>
        /// <param name="magazine">An <c>array</c> of <c>string</c> representing a magazine.</param>
        /// <param name="note">An <c>array</c> of <c>string</c> representing a note to created.</param>
        /// <returns>
        /// The return is <c>void</c>, but it uses <c>Console.WriteLine</c>
        /// to print the possibility of creating the note using the magazine.
        /// </returns>
        public static void CheckMagazineOnine(string[] magazine, string[] note)
        {
            var message = "Yes";
            var countByWord = magazine.GroupBy(word => word)
                                      .ToDictionary(group => group.Key,
                                                    group => group.Count());
            for (var i = 0; i < note.Length; i++)
            {
                if (countByWord.ContainsKey(note[i]) && countByWord[note[i]] > 0)
                {
                    countByWord[note[i]]--;
                }
                else
                {
                    message = "No";
                }
            }
            Console.WriteLine(message);
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <returns>
        /// The number of unordered anagrammatic pairs as an <c>int</c>.
        /// </returns>
        public static int SherlockAndAnagrams(string s)
        {
            var subStrings = new List<string>();
            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i; j < s.Length; j++)
                {
                    subStrings.Add(s.Substring(i, j - i + 1).Sort());
                }
            }
            return subStrings.GroupBy(substring => substring)
                             .Where(subString => subString.Count() > 1)
                             .Sum(subString => subString.Count() * (subString.Count() - 1) / 2);
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/two-strings/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        /// </summary>
        /// <param name="s1">A <c>string</c>.</param>
        /// <param name="s2">A <c>string</c>.</param>
        /// <returns>
        /// The result of if the strings share substrings as a <c>string</c>.
        /// </returns>
        public static string TwoStrings(string s1, string s2)
        {
            var isS1Bigger = s1.Length >= s2.Length;
            var bigList = isS1Bigger ? s1.Distinct().ToList() : s2.Distinct().ToList();
            var smallList = isS1Bigger ? s2.Distinct().ToList() : s1.Distinct().ToList();

            for (var i = 0; i < bigList.Count(); i++)
            {
                if (smallList.Contains(bigList[i]) || i < smallList.Count() && bigList.Contains(smallList[i]))
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}
