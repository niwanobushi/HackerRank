using System;

namespace HackerRank.Algorithms
{
    /// <summary>
    /// This class contains problems under the algorithms sorting section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/domains/algorithms?filters%5Bsubdomains%5D%5B%5D=arrays-and-sorting
    /// </summary>
    public static class Sorting
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/big-sorting/problem
        /// </summary>
        /// <param name="unsorted">An <c>Array</c> of <c>int</c> to be sorted.</param>
        /// <returns>
        /// The sorted <c>unsorted</c> as an <c>Array</c> of <c>string</c>.
        /// </returns>
        public static string[] BigSorting(string[] unsorted)
        {
            Array.Sort(unsorted,
                       (current, next) => current.Length == next.Length ?
                                               string.CompareOrdinal(current, next) :
                                               current.Length - next.Length);

            return unsorted;
        }
    }
}
