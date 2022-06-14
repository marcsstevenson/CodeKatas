using System.Linq;

namespace CodeKatas.Logic.CountingElements
{
    public class MaxCounters
    {
        /// <summary>
        /// Solves the max counter problem
        /// </summary>
        /// <see cref="https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/"/>
        /// <remarks>
        /// You are given N counters, initially set to 0, and you have two possible operations on them:
        ///
        /// increase(X) − counter X is increased by 1,
        /// max counter − all counters are set to the maximum value of any counter.
        /// A non-empty array A of M integers is given.This array represents consecutive operations:
        /// 
        /// if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
        /// if A[K] = N + 1 then operation K is max counter.
        /// For example, given integer N = 5 and array A such that:
        /// 
        ///     A[0] = 3
        ///     A[1] = 4
        ///     A[2] = 4
        ///     A[3] = 6
        ///     A[4] = 1
        ///     A[5] = 4
        ///     A[6] = 4
        /// the values of the counters after each consecutive operation will be:
        /// 
        ///     (0, 0, 1, 0, 0)
        ///     (0, 0, 1, 1, 0)
        ///     (0, 0, 1, 2, 0)
        ///     (2, 2, 2, 2, 2)
        ///     (3, 2, 2, 2, 2)
        ///     (3, 2, 2, 3, 2)
        ///     (3, 2, 2, 4, 2)
        /// The goal is to calculate the value of every counter after all operations.
        /// 
        /// Write a function:
        /// 
        /// class Solution { public int[] solution(int N, int[] A); }
        /// 
        ///         that, given an integer N and a non-empty array A consisting of M integers, returns a sequence of integers representing the values of the counters.
        /// 
        ///         Result array should be returned as an array of integers.
        /// 
        ///         For example, given:
        /// 
        /// 
        ///             A[0] = 3
        ///         
        ///             A[1] = 4
        ///         
        ///             A[2] = 4
        ///         
        ///             A[3] = 6
        ///         
        ///             A[4] = 1
        ///         
        ///             A[5] = 4
        ///         
        ///             A[6] = 4
        ///         the function should return [3, 2, 2, 4, 2], as explained above.
        /// 
        /// 
        ///         Write an efficient algorithm for the following assumptions:
        /// 
        /// 
        ///         N and M are integers within the range [1..100,000];
        ///         each element of array A is an integer within the range[1..N + 1].
        /// </remarks>
        /// <param name="n">n number of counters</param>
        /// <param name="array">The array.</param>
        /// <returns>The final values of all counters</returns>
        public int[] Solve(int n, int[] array)
        {
            var counters = new int[n];
            var maxCounterValue = 0;
            int index;

            foreach (var item in array)
            {
                if (item == n + 1)
                {
                    // Max the counters by recreating the array using maxCounterValue
                    counters = Enumerable.Repeat<int>(maxCounterValue, n).ToArray();
                }
                else
                {
                    index = item - 1;
                    counters[index]++;

                    // Track the max if it has increased
                    if (counters[index] > maxCounterValue)
                        maxCounterValue = counters[index];
                }
            }

            return counters;
        }
    }
}
