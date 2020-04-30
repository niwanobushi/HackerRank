using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class Arrays
    {
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

        public static int HourglassSum(int[][] arr)
        {
            var sum = int.MinValue;
            for (var i = 1; i < arr[0].Length - 1; i++)
            {
                for (var j = 1; j < arr[0].Length - 1; j++)
                {
                    var tempSum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i][j] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                    }
                }
            }
            return sum;
        }

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

        public static int[] RotLeftLinq(int[] a, int d)
            => a.Skip(d)
                .Concat(a.Take(d))
                .ToArray();
    }
}
