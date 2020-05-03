using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    /// <summary>
    /// This class contains problems under the warmup section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/interview/interview-preparation-kit/warmup/challenges
    /// </summary>
    public static class WarmUpChallenges
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        /// </summary>
        /// <param name="n">An <c>int</c> representing the number of steps.</param>
        /// <param name="s">A <c>string</c> representing the path.</param>
        /// <returns>
        /// The number of valleys walked through as an <c>int</c>.
        /// </returns>
        public static int CountingValleys(int n, string s)
        {
            var valleyCount = 0;
            var valleySteps = 0;
            var currentLevel = 0;
            foreach (var step in s)
            {
                currentLevel = step == 'U' ? currentLevel + 1 : currentLevel - 1;
                if (currentLevel < 0)
                {
                    valleySteps++;
                    if (valleySteps == 1)
                    {
                        valleyCount++;
                    }
                }
                else
                {
                    valleySteps = 0;
                }
            }
            return valleyCount;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        /// </summary>
        /// <param name="c">An <c>array</c> of <c>int</c> representing the clouds and its types.</param>
        /// <returns>
        /// The number of jumps needed as an <c>int</c>.
        /// </returns>
        public static int JumpingOnClouds(int[] c)
        {
            var jumps = 0;
            var i = 0;
            while (i < c.Length - 1)
            {
                i = i + 2 <= c.Length - 1 && c[i + 2] == 0 ? i + 2 : i + 1;
                jumps++;
            }
            return jumps;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        /// </summary>
        /// <param name="s">A <c>string</c>.</param>
        /// <param name="n">An <c>int</c>.</param>
        /// <returns>
        /// The number of letter a's in the first <c>n</c> letters of <c>s</c> as a <c>long</c>.
        /// </returns>
        public static long RepeatedString(string s, long n)
        {
            var mod = n % s.Length;
            var times = n / s.Length;
            var aCount = s.ToCharArray().Count(c => c == 'a') * times;
            if (mod > 0)
            {
                aCount += s.Substring(0, (int)mod)
                           .ToCharArray()
                           .Count(c => c == 'a');
            }
            return aCount;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        /// </summary>
        /// <param name="n">An <c>int</c> representing the number of socks in <c>ar</c>.</param>
        /// <param name="ar">An <c>array</c> of <c>int</c> representing socks and its colors.</param>
        /// <returns>
        /// The total number of matching pairs of socks as an <c>int</c>.
        /// </returns>
        public static int SockMerchant(int n, int[] ar)
        {
            var pairCount = 0;
            var socksByColor = new Dictionary<int, int>();
            for (var i = 0; i < n; i++)
            {
                var key = ar[i];
                socksByColor.TryAdd(key, 0);
                socksByColor[key]++;
            }
            foreach (var color in socksByColor)
            {
                pairCount += color.Value / 2;
            }
            return pairCount;
        }

        /// <summary>
        /// This is the submitted version.
        /// https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        /// </summary>
        /// <param name="n">An <c>int</c> representing the number of socks in <c>ar</c>.</param>
        /// <param name="ar">An <c>array</c> of <c>int</c> representing socks and its colors.</param>
        /// <returns>
        /// The total number of matching pairs of socks as an <c>int</c>.
        /// </returns>
        public static int SocketMerchantOnline(int n, int[] ar)
        {
            var pairCount = 0;
            var socksByColor = new Dictionary<int, int>();
            for (var i = 0; i < n; i++)
            {
                var key = ar[i];
                if (!socksByColor.ContainsKey(key))
                {
                    socksByColor.Add(key, 0);
                }
                socksByColor[key] = socksByColor[key] + 1;
            }
            foreach (var color in socksByColor)
            {
                pairCount += color.Value / 2;
            }
            return pairCount;
        }
    }
}
