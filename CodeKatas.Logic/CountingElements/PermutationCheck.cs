using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Logic.CountingElements
{
    public class PermutationCheck
    {
        /// <summary>
        /// A permutation is a sequence containing each element from 1 to N once, and only once.
        /// </summary>
        /// <example>
        /// For example, this array is a permutation:
        /// 
        ///     A[0] = 4
        ///     A[1] = 1
        ///     A[2] = 3
        ///     A[3] = 2
        ///  
        /// But this array is not a permutation, because value 2 is missing:
        /// 
        ///     A[0] = 4
        ///     A[1] = 1
        ///     A[2] = 3
        /// </example>
        /// <see cref="https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/"/>

        public int Solve(int[] array)
        {
            var set = new HashSet<int>();
            int max = int.MinValue;

            foreach (var item in array)
            {
                if (set.Contains(item)) return 0; // We found a duplicate

                set.Add(item);

                if (item > max) max = item; // Track the maximum value of item
            }

            return set.Count == max ? 1 : 0; // We found no duplicates but did we find a result for each item up to the max?
        }
    }
}
