using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms
{
    /// <summary>
    /// This class contains problems under the algorithms section.
    /// The names of the methods are capitalized, and parameters are unchanged.
    /// https://www.hackerrank.com/domains/algorithms?filters%5Bsubdomains%5D%5B%5D=implementation
    /// </summary>
    public static class Implementation
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/the-birthday-bar/problem
        /// </summary>
        /// <param name="s">A <c>List</c> of <c>int</c> representing pieces of chocolates.</param>
        /// <param name="d">An <c>int</c> representing the birth day.</param>
        /// <param name="m">An <c>int</c> representing the birth month.</param>
        /// <returns>
        /// The total number of ways that the chocolate can be portioned as an <c>int</c>.
        /// </returns>
        public static int Birthday(List<int> s, int d, int m)
        {
            var count = 0;
            for (var i = 0; i < s.Count() - m + 1; i++)
            {
                var sum = 0;
                for (var j = 0; j < m; j++)
                {
                    sum += s[i + j];
                }
                if (sum == d)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// This method is an implementation of <c>Birthday</c> using LINQ.
        /// https://www.hackerrank.com/challenges/the-birthday-bar/problem
        /// </summary>
        /// <param name="s">A <c>List</c> of <c>int</c> representing pieces of chocolates.</param>
        /// <param name="d">An <c>int</c> representing the birth day.</param>
        /// <param name="m">An <c>int</c> representing the birth month.</param>
        /// <returns>
        /// The total number of ways that the chocolate can be portioned as an <c>int</c>.
        /// </returns>
        public static int BirthdayLinq(List<int> s, int d, int m)
        {
            var count = 0;
            for (var i = 0; i < s.Count() - m + 1; i++)
            {
                if (s.GetRange(i, m).Sum() == d)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
        /// </summary>
        /// <param name="scores">An <c>Array</c> of <c>int</c> representing the score in each game.</param>
        /// <returns>
        /// The number of times the lowest score and highest score records were broken as an <c>Array</c> of <c>int</c>.
        /// </returns>
        public static int[] BreakingRecords(int[] scores)
        {
            var lowestScore = scores[0];
            var highestScore = scores[0];
            var lowerRecordCount = 0;
            var higherRecordCount = 0;
            for (var i = 1; i < scores.Length; i++)
            {
                var currentScore = scores[i];
                if (currentScore < lowestScore)
                {
                    lowestScore = currentScore;
                    lowerRecordCount++;
                }
                else if (currentScore > highestScore)
                {
                    highestScore = currentScore;
                    higherRecordCount++;
                }
            }
            return new int[] { higherRecordCount, lowerRecordCount };
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/apple-and-orange/problem
        /// </summary>
        /// <param name="s">An <c>int</c> representing where the house starts.</param>
        /// <param name="t">An <c>int</c> representing where the house ends.</param>
        /// <param name="a">An <c>int</c> representing where the apple tree is.</param>
        /// <param name="b">An <c>int</c> representing where the orange tree is.</param>
        /// <param name="apples">An <c>Array</c> of <c>int</c> representing where the apples fell.</param>
        /// <param name="oranges">An <c>Array</c> of <c>int</c> representing where the oranges fell.</param>
        /// <returns>
        /// The count of apples and oranges that fell on the house as an <c>Array</c> of <c>int</c>.
        /// </returns>
        public static int[] CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var applesCount = 0;
            var orangesCount = 0;
            var limit = Math.Max(apples.Length, oranges.Length);
            for (var i = 0; i < limit; i++)
            {
                if (i < apples.Length && a + apples[i] >= s && a + apples[i] <= t)
                {
                    applesCount++;
                }
                if (i < oranges.Length && b + oranges[i] <= t && b + oranges[i] >= s)
                {
                    orangesCount++;
                }
            }
            return new int[] { applesCount, orangesCount };
        }

        /// <summary>
        /// This method is an implementation of <c>CountApplesAndOranges</c> using LINQ.
        /// https://www.hackerrank.com/challenges/apple-and-orange/problem
        /// </summary>
        /// <param name="s">An <c>int</c> representing where the house starts.</param>
        /// <param name="t">An <c>int</c> representing where the house ends.</param>
        /// <param name="a">An <c>int</c> representing where the apple tree is.</param>
        /// <param name="b">An <c>int</c> representing where the orange tree is.</param>
        /// <param name="apples">An <c>Array</c> of <c>int</c> representing where the apples fell.</param>
        /// <param name="oranges">An <c>Array</c> of <c>int</c> representing where the oranges fell.</param>
        /// <returns>
        /// The count of apples and oranges that fell on the house as an <c>Array</c> of <c>int</c>.
        /// </returns>
        public static int[] CountApplesAndOrangesLinq(int s, int t, int a, int b, int[] apples, int[] oranges)
            => new int[]
               {
                   apples.Where(apple => a + apple >= s && a + apple <= t).Count(),
                   oranges.Where(orange => b + orange <= t && b + orange >= s).Count()
               };

        /// <summary>
        /// This is the submitted version using <c>Console.WriteLine</c>.
        /// https://www.hackerrank.com/challenges/apple-and-orange/problem
        /// </summary>
        /// <param name="s">An <c>int</c> representing where the house starts.</param>
        /// <param name="t">An <c>int</c> representing where the house ends.</param>
        /// <param name="a">An <c>int</c> representing where the apple tree is.</param>
        /// <param name="b">An <c>int</c> representing where the orange tree is.</param>
        /// <param name="apples">An <c>Array</c> of <c>int</c> representing where the apples fell.</param>
        /// <param name="oranges">An <c>Array</c> of <c>int</c> representing where the oranges fell.</param>
        /// <returns>
        /// The return is <c>void</c>, but it uses <c>Console.WriteLine</c>
        /// to print the count of apples and oranges that fell on the house.
        /// </returns>
        public static void CountApplesAndOrangesOnline(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            Console.WriteLine(apples.Where(apple => a + apple >= s && a + apple <= t).Count());
            Console.WriteLine(oranges.Where(orange => b + orange <= t && b + orange >= s).Count());
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/day-of-the-programmer/problem
        /// </summary>
        /// <param name="year">An <c>int</c> representing the year.</param>
        /// <returns>
        /// The full date of Day of the Programmer during the <c>year</c> as a <c>string</c>.
        /// </returns>
        public static string DayOfProgrammer(int year)
        {
            const string Message1918 = "26.09.1918";
            const string MessageLeap = "12.09";
            const string MessageNotLeap = "13.09";
            if (year == 1918)
            {
                return Message1918;
            }
            if (year < 1918 && year % 4 == 0 ||
                year > 1918 && (year % 400 == 0 || year % 4 == 0 && year % 100 != 0))
            {
                return $"{MessageLeap}.{year}";
            }
            return $"{MessageNotLeap}.{year}";
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
        /// </summary>
        /// <param name="n">An <c>int</c> representing the length of <c>ar</c>.</param>
        /// <param name="k">An <c>int</c>.</param>
        /// <param name="ar">An <c>Array</c> of <c>int</c>.</param>
        /// <returns>
        /// The count of numbers that match the criteria as an <c>int</c>.
        /// </returns>
        public static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            var count = 0;
            for (var i = 0; i < ar.Length - 1; i++)
            {
                for (var j = i + 1; j < ar.Length; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/grading/problem
        /// </summary>
        /// <param name="a">A <c>List</c> of <c>int</c>.</param>
        /// <param name="b">A <c>List</c> of <c>int</c>.</param>
        /// <returns>
        /// The count of numbers that match the criteria as an <c>int</c>.
        /// </returns>
        public static int GetTotalX(List<int> a, List<int> b)
        {
            var result = 0;
            for (var i = a.First(); i <= b.First(); i++)
            {
                if (a.All(number => i % number == 0) &&
                    b.All(number => number % i == 0))
                {
                    result++;
                }
            }
            return result;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/grading/problem
        /// </summary>
        /// <param name="grades">A <c>List</c> of <c>int</c> representing grades.</param>
        /// <returns>
        /// The rounded grades as a <c>List</c> of <c>int</c>.
        /// </returns>
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

        /// <summary>
        /// This method is an implementation of <c>GradingStudents</c> using LINQ.
        /// https://www.hackerrank.com/challenges/grading/problem
        /// </summary>
        /// <param name="grades">A <c>List</c> of <c>int</c> representing grades.</param>
        /// <returns>
        /// The rounded grades as a <c>List</c> of <c>int</c> .
        /// </returns>
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

        /// <summary>
        /// https://www.hackerrank.com/challenges/kangaroo/problem
        /// </summary>
        /// <param name="x1">An <c>int</c> representing the starting place of the first kangoroo.</param>
        /// <param name="v1">An <c>int</c> representing the speed of the first kangoroo.</param>
        /// <param name="x2">An <c>int</c> representing the starting place of the second kangoroo.</param>
        /// <param name="v2">An <c>int</c> representing the speed of the second kangoroo.</param>
        /// <returns>
        /// The result of if it's possible for them to be at the same place at the same time as a <c>string</c> .
        /// </returns>
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            const string GoodResult = "YES";
            const string BadResult = "NO";
            if (v1 < v2)
            {
                return BadResult;
            }
            while (x1 <= x2)
            {
                if (x1 == x2)
                {
                    return GoodResult;
                }
                else
                {
                    x1 += v1;
                    x2 += v2;
                }
            }
            return BadResult;
        }

        /// <summary>
        /// This method is an implementation of <c>Kangaroo</c> using math.
        /// https://www.hackerrank.com/challenges/kangaroo/problem
        /// </summary>
        /// <param name="x1">An <c>int</c> representing the starting place of the first kangoroo.</param>
        /// <param name="v1">An <c>int</c> representing the speed of the first kangoroo.</param>
        /// <param name="x2">An <c>int</c> representing the starting place of the second kangoroo.</param>
        /// <param name="v2">An <c>int</c> representing the speed of the second kangoroo.</param>
        /// <returns>
        /// The result of if it's possible for them to be at the same place at the same time as a <c>string</c> .
        /// </returns>
        public static string KangarooMath(int x1, int v1, int x2, int v2)
        {
            const string GoodResult = "YES";
            const string BadResult = "NO";
            if (v1 < v2 || x1 != x2 && v2 - v1 == 0)
            {
                return BadResult;
            }
            return x1 == x2 || (x2 - x1) % (v1 - v2) == 0 ? GoodResult : BadResult;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/migratory-birds/problem
        /// </summary>
        /// <param name="arr">A <c>List</c> of <c>int</c> representing the types of birds sighted.</param>
        /// <returns>
        /// The type of the most common bird as an <c>int</c>.
        /// </returns>
        public static int MigratoryBirds(List<int> arr)
            => arr.Distinct()
                  .GroupBy(bird1 => arr.Count(bird2 => bird1 == bird2))
                  .OrderByDescending(group => group.Key)
                  .First()
                  .Min();
    }
}
