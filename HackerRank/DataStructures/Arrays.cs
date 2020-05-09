using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.DataStructures
{
    /// <summary>
    /// This class contains problems under the data structures arrays section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/domains/data-structures?filters%5Bsubdomains%5D%5B%5D=arrays
    /// </summary>
    public static class Arrays
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/dynamic-array/problem
        /// </summary>
        /// <param name="n">An <c>int</c> representing the number of sequences.</param>
        /// <param name="queries">A <c>List</c> of <c>List</c> of <c>int</c>.</param>
        /// <returns>
        /// The result as a <c>List</c> of <c>int</c>.
        /// </returns>
        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            var seqLists = Enumerable.Range(1, n)
                                     .Select(i => new List<int>())
                                     .ToList();
            var lastAnswers = new List<int>();
            var lastAnswer = 0;
            foreach (var query in queries)
            {
                var seq = seqLists[(query[1] ^ lastAnswer) % n];
                if (query[0] == 1)
                {
                    seq.Add(query[2]);
                }
                else
                {
                    lastAnswer = seq[query[2] % seq.Count()];
                    lastAnswers.Add(lastAnswer);
                }
            }
            return lastAnswers;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/sparse-arrays/problem
        /// </summary>
        /// <param name="strings">An <c>Array</c> of <c>string</c>.</param>
        /// <param name="queries">An <c>Array</c> of <c>string</c> representing texts to be found in <c>strings</c>.</param>
        /// <returns>
        /// The count of matches of elements in <c>queries</c> in <c>strings</c> as an <c>Array</c> of <c>int</c>.
        /// </returns>
        public static int[] MatchingStrings(string[] strings, string[] queries)
        {
            var queryCounts = new int[queries.Length];
            for (var i = 0; i < queries.Length; i++)
            {
                var count = 0;
                foreach (var text in strings)
                {
                    if (queries[i] == text)
                    {
                        count++;
                    }
                }
                queryCounts[i] = count;
            }
            return queryCounts;
        }

        /// <summary>
        /// This method is an implementation of <c>MatchingStrings</c> using LINQ.
        /// https://www.hackerrank.com/challenges/sparse-arrays/problem
        /// </summary>
        /// <param name="strings">An <c>Array</c> of <c>string</c>.</param>
        /// <param name="queries">An <c>Array</c> of <c>string</c> representing texts to be found in <c>strings</c>.</param>
        /// <returns>
        /// The count of matches of elements in <c>queries</c> in <c>strings</c> as an <c>Array</c> of <c>int</c>.
        /// </returns>
        public static int[] MatchingStringsLinq(string[] strings, string[] queries)
            => queries.Select(query => strings.Count(text => text == query))
                      .ToArray();

        /// <summary>
        /// https://www.hackerrank.com/challenges/arrays-ds/problem
        /// </summary>
        /// <param name="a">An <c>Array</c> of <c>int</c>.</param>
        /// <returns>
        /// The reverse ordered <c>a</c> as an <c>Array</c> of <c>int</c>.
        /// </returns>
        public static int[] ReverseArray(int[] a)
        {
            var reverseA = new int[a.Length];
            for (var i = 0; i < a.Length; i++)
            {
                reverseA[i] = a[a.Length - i - 1];
            }
            return reverseA;
        }

        /// <summary>
        /// This method is an implementation of <c>ReverseArray</c> using LINQ.
        /// https://www.hackerrank.com/challenges/arrays-ds/problem
        /// </summary>
        /// <param name="a">An <c>Array</c> of <c>int</c>.</param>
        /// <returns>
        /// The reverse ordered <c>a</c> as an <c>Array</c> of <c>int</c>.
        /// </returns>
        public static int[] ReverseArrayLinq(int[] a)
            => a.Reverse()
                .ToArray();
    }
}
