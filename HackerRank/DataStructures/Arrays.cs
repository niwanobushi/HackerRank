﻿using System;
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
