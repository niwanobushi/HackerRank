using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Certification
{
    /// <summary>
    /// This class contains methods from the Problem Solving Basic Certification.
    /// https://www.hackerrank.com/certificates/93a30339a1fe
    /// </summary>
    public static class ProblemSolvingBasic
    {
        /// <summary>
        /// Didn't pass all test cases online.
        /// </summary>
        /// <param name="s">A <c>string</c> representing an encrypted message.</param>
        /// <returns>
        /// The orignal message as a <c>string</c>.
        /// </returns>
        public static string DecryptPassword(string s)
        {
            var arrayS = s.ToArray();

            for (var i = 0; i < arrayS.Length; i++)
            {
                if (i + 1 < arrayS.Length &&
                    char.IsUpper(arrayS[i]) &&
                    char.IsLower(arrayS[i + 1]))
                {
                    var temp = arrayS[i];
                    arrayS[i] = arrayS[i + 1];
                    arrayS[i + 1] = temp;
                    i++;
                }
                else if (char.IsDigit(arrayS[i]) && arrayS[i] != '0')
                {
                    var j = Array.LastIndexOf(arrayS, '0');
                    if (j > i)
                    {
                        arrayS[j] = arrayS[i];
                        arrayS[i] = '*';
                    }
                }
            }
            var result = new string(arrayS).Replace("*", string.Empty);
            return result;
        }

        /// <summary>
        /// Passed all test cases online.
        /// </summary>
        /// <param name="employee_id">A <c>List</c> of <c>int</c> representing employees and their IDs.</param>
        /// <param name="job_id">A <c>List</c> of <c>int</c> representing jobs and their IDs.</param>
        /// <returns>
        /// The least movement needed by all emplyees as a <c>long</c>.
        /// </returns>
        public static long GetMinCost(List<int> employee_id, List<int> job_id)
        {
            var orderedEmployees = employee_id.OrderBy(employee => employee).ToArray();
            var orderedJobs = job_id.OrderBy(job => job).ToArray();
            var count = 0L;
            for (var i = 0; i < orderedJobs.Count(); i++)
            {
                count += Math.Abs(Convert.ToInt64(orderedEmployees[i]) - Convert.ToInt64(orderedJobs[i]));
            }
            return count;
        }
    }
}
