﻿using System.Linq;

namespace System
{
    /// <summary>
    /// This class contains extension methods associated with the <c>System</c> namespace.
    /// </summary>
    public static class SystemExtensions
    {
        /// <summary>
        /// This method checks if an <c>int</c> is a palindrome.
        /// </summary>
        /// <param name="number">An <c>int</c>.</param>
        /// <returns>
        /// The result of if <c>number</c> is a palindrome as a <c>bool</c>.
        /// </returns>
        public static bool IsPalindrome(this int number)
            => number == number.Reverse();

        /// <summary>
        /// This method gets the reverse number of an <c>int</c>.
        /// </summary>
        /// <param name="number">An <c>int</c>.</param>
        /// <returns>
        /// The reverse of <c>number</c> as an <c>int</c>.
        /// </returns>
        public static int Reverse(this int number)
        {
            var reverse = 0;
            var quotient = number;
            while (quotient != 0)
            {
                var mod = quotient % 10;
                quotient /= 10;
                reverse = reverse * 10 + mod;
            }
            return reverse;
        }

        /// <summary>
        /// This method truncates a <c>float</c>.
        /// </summary>
        /// <param name="number">A <c>float</c>.</param>
        /// <param name="digits">An <c>int</c> representing the number of digits after the decimal point.</param>
        /// <returns>
        /// The truncated number as an <c>float</c>.    
        /// </returns>
        public static float Truncate(this float number, int digits)
        {
            var times = Math.Pow(10, digits);
            return (float)(Math.Truncate(number * times) / times);
        }

        /// <summary>
        /// This method checks if a <c>string</c> is a palindrome.
        /// </summary>
        /// <param name="text">A <c>string</c>.</param>
        /// <returns>
        /// The result of if <c>text</c> is a palindrome as a <c>bool</c>.
        /// </returns>
        public static bool IsPalindrome(this string text)
        {
            for (var i = 0; i < text.Length; i++)
            {
                var j = text.Length - i - 1;
                if (i != j && text[i] != text[j])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// This method sorts the characters in a <c>string</c> alphabetically.
        /// </summary>
        /// <param name="text">A <c>string</c>.</param>
        /// <returns>
        /// The alphabetically sorted <c>text</c> as a <c>string</c>.
        /// </returns>
        public static string Sort(this string text)
        {
            var characters = text.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        /// <summary>
        /// This method populates an <c>Array</c> of <c>T</c>.
        /// </summary>
        /// <param name="array">An <c>Array</c> of <c>T</c>.</param>
        /// <param name="value">The value to be used to populate <c>Array</c>.</param>
        /// <returns>
        /// <c>void</c>
        /// </returns>
        public static void Populate<T>(this T[] array, T value)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }

        /// <summary>
        /// This method populates a 2D <c>Array</c> of <c>T</c>.
        /// </summary>
        /// <param name="array">An <c>Array</c> of <c>T</c>.</param>
        /// <param name="value">The value to be used to populate <c>Array</c>.</param>
        /// <returns>
        /// <c>void</c>
        /// </returns>
        public static void Populate<T>(this T[,] array, T value)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = value;
                }
            }
        }
    }
}
