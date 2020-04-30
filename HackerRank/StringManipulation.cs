using System;
using System.Linq;

namespace HackerRank
{
    public static class StringManipulation
    {
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

        public static int AlternatingCharactersLinq(string s)
            => s.Where((letter, index) => index + 1 < s.Length && letter == s[index + 1])
                .Count();

        public static string IsValid(string s)
        {
            const string goodResult = "YES";
            const string badResult = "NO";
            if (s.Length <= 3)
            {
                return goodResult;
            }
            var letters = s.Distinct()
                           .Select(letter1 => s.Count(letter2 => letter1 == letter2))
                           .OrderBy(letter => letter);
            var max = letters.Last();
            var min = letters.First();
            if (min == max)
            {
                return goodResult;
            }
            if (max - min == 1 && max > letters.ElementAt(letters.Count() - 2) || min == 1 && letters.ElementAt(1) == max)
            {
                return goodResult;
            }
            return badResult;
        }

        public static int MakeAnagram(string a, string b)
            => a.Concat(b).Distinct()
                          .Select(letter => Math.Abs(a.Count(c => c == letter) - b.Count(c => c == letter)))
                          .Sum();

        public static int MakeAnagramOnline(string a, string b)
            => string.Concat(a, b).Distinct()
                                  .Select(letter => Math.Abs(a.Count(c => c == letter) - b.Count(c => c == letter)))
                                  .Sum();

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
                    else
                    {
                        if (differentLetterIndex == -1)
                        {
                            differentLetterIndex = j;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return total;
        }

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
