using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.InterviewPreparation
{
    /// <summary>
    /// This class contains problems under the arrays section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/interview/interview-preparation-kit/arrays/challenges
    /// </summary>
    public static class Arrays
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/crush/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="n">An <c>int</c> representing the number of elements in <c>queries</c>.</param>
        /// <param name="queries">An <c>array</c> of <c>array</c> of <c>int</c> representing the queries to be processed.</param>
        /// <returns>
        /// The highest value after processing <c>queries</c> as a <c>long</c>.
        /// </returns>
        public static long ArrayManipulation(int n, int[][] queries)
        {
            var array = new long[n];
            var max = 0L;
            for (var i = 0; i < queries.Length; i++)
            {
                for (var j = queries[i][0] - 1; j < queries[i][1]; j++)
                {
                    array[j] += queries[i][2];
                    if (array[j] > max)
                    {
                        max = array[j];
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// This is the submitted version.
        /// https://www.hackerrank.com/challenges/crush/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="n">An <c>int</c> representing the number of elements in <c>queries</c>.</param>
        /// <param name="queries">An <c>array</c> of <c>array</c> of <c>int</c> representing the queries to be processed.</param>
        /// <returns>
        /// The highest value after processing <c>queries</c> as a <c>long</c>.
        /// </returns>
        public static long ArrayManipulationOnline(int n, int[][] queries)
        {
            var numbers = new long[n + 1];
            for (var i = 0; i < queries.Length; i++)
            {
                var a = queries[i][0];
                var b = queries[i][1];
                long k = queries[i][2];
                numbers[a] += k;
                if (b + 1 <= n)
                {
                    numbers[b + 1] -= k;
                };
            }
            var tempMax = 0L;
            var max = 0L;
            for (int i = 1; i <= n; i++)
            {
                tempMax += numbers[i];
                if (tempMax > max)
                {
                    max = tempMax;
                }
            }
            return max;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="arr">An <c>array</c> of <c>array</c> of <c>int</c>.</param>
        /// <returns>
        /// The highest value after processing the hour glass sums as an <c>int</c>.
        /// </returns>
        public static int HourglassSum(int[][] arr)
        {
            var sum = int.MinValue;
            for (var i = 1; i < arr[0].Length - 1; i++)
            {
                for (var j = 1; j < arr[0].Length - 1; j++)
                {
                    var tempSum = arr[i - 1][j - 1] +
                                  arr[i - 1][j] +
                                  arr[i - 1][j + 1] +
                                  arr[i][j] +
                                  arr[i + 1][j - 1] +
                                  arr[i + 1][j] +
                                  arr[i + 1][j + 1];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="q">An <c>array</c> of <c>int</c> representing the final state of the queue.</param>
        /// <returns>
        /// The minimum number of bribes needed to get the queue into its final state as an <c>int</c>.
        /// </returns>
        public static int MinimumBribes(int[] q)
        {
            var totalBribes = 0;
            var isTooChaotic = false;
            bool isOrdered;
            do
            {
                isOrdered = true;
                for (var i = 0; i < q.Length - 1; i++)
                {
                    if (q[i] > q[i + 1])
                    {
                        var dif = q[i] - i - 1;
                        if (dif > 0)
                        {
                            isOrdered = false;
                        }
                        if (!isTooChaotic && dif > 2)
                        {
                            isTooChaotic = true;
                        }
                        var temp = q[i];
                        q[i] = q[i + 1];
                        q[i + 1] = temp;
                        totalBribes++;
                    }
                }
            }
            while (!isOrdered);
            return isTooChaotic ? -1 : totalBribes;
        }

        /// <summary>
        /// This is the submitted version using <c>Console.WriteLine</c>.
        /// https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="q">An <c>array</c> of <c>int</c> representing the final state of the queue.</param>
        /// <returns>
        /// The return is <c>void</c>, but it uses <c>Console.WriteLine</c>
        /// to print the minimum number of bribes needed to get the queue into its final state.
        /// </returns>
        public static void MinimumBribesOnline(int[] q)
        {
            var totalBribes = 0;
            var isTooChaotic = false;
            bool isOrdered;
            do
            {
                isOrdered = true;
                for (var i = 0; i < q.Length - 1; i++)
                {
                    if (q[i] > q[i + 1])
                    {
                        var dif = q[i] - i - 1;
                        if (dif > 0)
                        {
                            isOrdered = false;
                        }
                        if (!isTooChaotic && dif > 2)
                        {
                            isTooChaotic = true;
                        }
                        var temp = q[i];
                        q[i] = q[i + 1];
                        q[i + 1] = temp;
                        totalBribes++;
                    }
                }
            }
            while (!isOrdered);
            if (isTooChaotic)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine(totalBribes);
            }
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="arr">An unordered <c>array</c> of <c>int</c>.</param>
        /// <returns>
        /// The minimum number of swaps needed to order <c>arr</c> as an <c>int</c>.
        /// </returns>
        public static int MinimumSwaps(int[] arr)
        {
            var swaps = 0;
            bool isOrdered;
            do
            {
                isOrdered = true;
                for (var i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != i + 1)
                    {
                        var temp = arr[i];
                        arr[i] = arr[temp - 1];
                        arr[temp - 1] = temp;
                        swaps++;
                        isOrdered = false;
                        break;
                    }
                }
            }
            while (!isOrdered);
            return swaps;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="a">An <c>array</c> of <c>int</c>.</param>
        /// <param name="d">An <c>int</c> representing the number of rotations.</param>
        /// <returns>
        /// The final state of <c>a</c> as an <c>array</c> of <c>int</c>.
        /// </returns>
        public static int[] RotLeft(int[] a, int d)
        {
            var updatedA = new List<int>();
            for (var i = 0; i < a.Length; i++)
            {
                var index = Math.Abs((a.Length + d + i) % a.Length);
                updatedA.Add(a[index]);
            }
            return updatedA.ToArray();
        }

        /// <summary>
        /// This method is an implementation of <c>RotLeft</c> using LINQ.
        /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="a">An <c>array</c> of <c>int</c>.</param>
        /// <param name="d">An <c>int</c> representing the number of rotations.</param>
        /// <returns>
        /// The final state of <c>a</c> as an <c>array</c> of <c>int</c>.
        /// </returns>
        public static int[] RotLeftLinq(int[] a, int d)
            => a.Skip(d)
                .Concat(a.Take(d))
                .ToArray();
    }
}
