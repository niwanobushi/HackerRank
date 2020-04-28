using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class Arrays
    {
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

        public static int[] RotLeftLinq(int[] a, int d)
            => a.Skip(d).Concat(a.Take(d)).ToArray();
    }
}
