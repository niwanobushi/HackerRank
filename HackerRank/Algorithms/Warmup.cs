using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms
{
    /// <summary>
    /// This class contains problems under the algorithms warmup section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/domains/algorithms?filters%5Bsubdomains%5D%5B%5D=warmup
    /// </summary>
    public static class Warmup
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/a-very-big-sum/problem
        /// </summary>
        /// <param name="ar">An <c>array</c> of <c>long</c>.</param>
        /// <returns>
        /// The sum of the elements in <c>ar</c> as a <c>long</c>.
        /// </returns>
        public static long AVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var number in ar)
            {
                sum += number;
            }
            return sum;
        }

        /// <summary>
        /// This method is an implementation of <c>AVeryBigSum</c> using LINQ.
        /// https://www.hackerrank.com/challenges/a-very-big-sum/problem
        /// </summary>
        /// <param name="ar">An <c>array</c> of <c>long</c>.</param>
        /// <returns>
        /// The sum of the elements in <c>ar</c> as a <c>long</c>.
        /// </returns>
        public static long AVeryBigSumLinq(long[] ar)
            => ar.Sum();

        /// <summary>
        /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        /// </summary>
        /// <param name="ar">An <c>array</c> of <c>int</c>.</param>
        /// <returns>
        /// The count of the highest elements in <c>ar</c> as an <c>int</c>.
        /// </returns>
        public static int BirthdayCakeCandles(int[] ar)
        {
            var highest = 0;
            var highestCount = 0;
            foreach (var candle in ar)
            {
                if (candle > highest)
                {
                    highest = candle;
                    highestCount = 1;
                }
                else if (candle == highest)
                {
                    highestCount++;
                }
            }
            return highestCount;
        }

        /// <summary>
        /// This method is an implementation of <c>BirthdayCakeCandles</c> using LINQ.
        /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        /// </summary>
        /// <param name="ar">An <c>array</c> of <c>int</c>.</param>
        /// <returns>
        /// The count of the highest elements in <c>ar</c> as an <c>int</c>.
        /// </returns>
        public static int BirthdayCakeCandlesLinq(int[] ar)
            => ar.Count(item => item == ar.Max());

        /// <summary>
        /// https://www.hackerrank.com/challenges/compare-the-triplets/problem
        /// </summary>
        /// <param name="a">A <c>List</c> of <c>int</c> representing Alice's ratings.</param>
        /// <param name="a">A <c>List</c> of <c>int</c> representing Bob's ratings.</param>
        /// <returns>
        /// The comparison points earned by Alice and Bob as a <c>List</c> of <c>int</c> .
        /// </returns>
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int> { 0, 0 };
            for (var i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                {
                    result[0]++;
                }
                else if (a[i] < b[i])
                {
                    result[1]++;
                }
            }
            return result;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/plus-minus/problem
        /// </summary>
        /// <param name="arr">An <c>array</c> of <c>int</c>.</param>
        /// <returns>
        /// The fractions of positive numbers, negative numbers and zeroes as an <c>array</c> of <c>float</c>.
        /// </returns>
        public static float[] PlusMinus(int[] arr)
        {
            float positiveCount = 0;
            float negativeCount = 0;
            float zeroCount = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            return new float[] { positiveCount / arr.Length, negativeCount / arr.Length, zeroCount / arr.Length };
        }

        /// <summary>
        /// This is the submitted version using <c>Console.WriteLine</c>.
        /// https://www.hackerrank.com/challenges/plus-minus/problem
        /// </summary>
        /// <param name="arr">An <c>array</c> of <c>int</c>.</param>
        /// <returns>
        /// The return is <c>void</c>, but it uses <c>Console.WriteLine</c>
        /// to print the fractions of positive numbers, negative numbers and zeroes.
        /// </returns>
        public static void PlusMinusOnline(int[] arr)
        {
            float positiveCount = 0;
            float negativeCount = 0;
            float zeroCount = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine(positiveCount / arr.Length);
            Console.WriteLine(negativeCount / arr.Length);
            Console.WriteLine(zeroCount / arr.Length);
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/simple-array-sum/problem
        /// </summary>
        /// <param name="n">An <c>int</c> representint the size of <c>arr</c>.</param>
        /// <param name="arr">An <c>array</c> of <c>int</c>.</param>
        /// <returns>
        /// The sum of the elements in <c>arr</c> as an <c>int</c>.
        /// </returns>
        public static int SimpleArraySum(int n, int[] ar)
        {
            var sum = 0;
            foreach (var number in ar)
            {
                sum += number;
            }
            return sum;
        }

        /// <summary>
        /// This method is an implementation of <c>SimpleArraySum</c> using LINQ.
        /// https://www.hackerrank.com/challenges/simple-array-sum/problem
        /// </summary>
        /// <param name="n">An <c>int</c> representint the size of <c>arr</c>.</param>
        /// <param name="arr">An <c>array</c> of <c>int</c>.</param>
        /// <returns>
        /// The sum of the elements in <c>arr</c> as an <c>int</c>.
        /// </returns>
        public static int SimpleArraySumLinq(int n, int[] ar)
            => ar.Sum();

        /// <summary>
        /// https://www.hackerrank.com/challenges/solve-me-first/problem
        /// </summary>
        /// <param name="a">An <c>int</c>.</param>
        /// <param name="b">An <c>int</c>.</param>
        /// <returns>
        /// The sum of <c>a</c> and <c>b</c> as an <c>int</c>.
        /// </returns>
        public static int SolveMeFirst(int a, int b)
            => a + b;

        /// <summary>
        /// https://www.hackerrank.com/challenges/time-conversion/problem
        /// </summary>
        /// <param name="s">A <c>string</c> representing time in 12 hours format.</param>
        /// <returns>
        /// The 24 hours format time representation of <c>s</c> as a <c>string</c>.
        /// </returns>
        public static string TimeConversion(string s)
            => DateTime.Parse(s).TimeOfDay.ToString();
    }
}
