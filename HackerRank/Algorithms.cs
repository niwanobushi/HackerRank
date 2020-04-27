using System.Linq;

namespace HackerRank
{
    public static class Algorithms
    {
        public static long AVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var number in ar)
            {
                sum += number;
            }
            return sum;
        }

        public static long AVeryBigSumLinq(long[] ar)
            => ar.Sum();

        public static int SimpleArraySum(int n, int[] ar)
        {
            var sum = 0;
            foreach (var number in ar)
            {
                sum += number;
            }
            return sum;
        }

        public static int SimpleArraySumLinq(int n, int[] ar)
            => ar.Sum();

        public static int SolveMeFirst(int a, int b)
            => a + b;
    }
}
