using System;
using System.Collections.Generic;
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

        public static int BirthdayCakeCandlesLinq(int[] ar)
            => ar.Count(item => item == ar.Max());

        public static List<int> CompareTheTriplets(List<int> a, List<int> b)
        {
            var result = new List<int> { 0, 0 };
            for (var i = 0; i < a.Count; i++)
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

        public static List<int> GradingStudents(List<int> grades)
        {
            var updatedGrades = new List<int>();
            foreach (var grade in grades)
            {
                if (grade >= 38)
                {
                    var dif = 5 - grade % 5;
                    if (dif < 3)
                    {
                        updatedGrades.Add(grade + dif);
                    }
                    else
                    {
                        updatedGrades.Add(grade);
                    }
                }
                else
                {
                    updatedGrades.Add(grade);
                }
            }
            return updatedGrades;
        }

        public static List<int> GradingStudentsLinq(List<int> grades)
            => grades.Select(grade =>
            {
                if (grade >= 38)
                {
                    var dif = 5 - grade % 5;
                    if (dif < 3)
                    {
                        return grade + dif;
                    }
                }
                return grade;
            })
            .ToList();

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

        public static string TimeConversion(string s)
            => DateTime.Parse(s).TimeOfDay.ToString();
    }
}
