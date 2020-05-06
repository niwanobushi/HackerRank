using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Extensions
{
    /// <summary>
    /// This class contains extension methods associated with the <c>Collections</c> namespace.
    /// </summary>
    public static class CollectionsExtension
    {
        /// <summary>
        /// This method gets all permutations from a collection.
        /// </summary>
        /// <param name="collection">An <c>IEnumerable</c> of <c>T</c>.</param>
        /// <param name="count">An <c>int</c> that represents the size of the permutations.</param>
        /// <returns>
        /// The permutations in <c>collection</c> as an <c>IEnumerable</c> of <c>IEnumerable</c> of <c>T</c>.
        /// </returns>
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(this IEnumerable<T> collection, int count = 2)
        {
            int i = 0;
            foreach (var item in collection)
            {
                if (count == 1)
                {
                    yield return new T[] { item };
                }
                else
                {
                    foreach (var result in collection.Skip(i + 1).GetPermutations(count - 1))
                    {
                        yield return new T[] { item }.Concat(result);
                    }
                }
                i++;
            }
        }
    }
}
