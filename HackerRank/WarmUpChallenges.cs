using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class WarmUpChallenges
    {
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

        public static long RepeatedString(string s, long n)
        {
            var mod = n % s.Length;
            var times = n / s.Length;
            var aCount = s.ToCharArray().Count(c => c == 'a') * times;
            if (mod > 0)
            {
                aCount += s.Substring(0, (int)mod).ToCharArray().Count(c => c == 'a');
            }
            return aCount;
        }

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
