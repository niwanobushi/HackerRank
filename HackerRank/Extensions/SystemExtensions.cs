using System.Linq;

namespace System
{
    /// <summary>
    /// This class contains extension methods associated with the <c>System</c> namespace.
    /// </summary>
    public static class SystemExtensions
    {
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
        /// This method populates an <c>array</c> of <c>T</c>.
        /// </summary>
        /// <param name="array">An <c>array</c> of <c>T</c>.</param>
        /// <param name="value">The value to be used to populate <c>array</c>.</param>
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
        /// This method populates a 2D <c>array</c> of <c>T</c>.
        /// </summary>
        /// <param name="array">An <c>array</c> of <c>T</c>.</param>
        /// <param name="value">The value to be used to populate <c>array</c>.</param>
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
