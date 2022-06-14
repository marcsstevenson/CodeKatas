using System.Linq;

namespace CodeKatas.Logic.Leader
{
    public class Dominator
    {
        /// <summary>
        /// Given an array A consisting of N integers, returns index of any element of array A in which the dominator of A occurs. 
        /// The function should return −1 if array A does not have a dominator.
        /// </summary>
        public int solution(int[] A)
        {
            if (A.Length == 0) return -1;
            if (A.Length == 1) return 0;
            var threshold = A.Length / 2 + 1;

            var sorted = A.OrderBy(i => i);

            // If we have a dominator then it will be at the center of the array
            var potential = sorted.ElementAt(A.Length / 2);

            var count = sorted.Count(i => i == potential);

            if (count < threshold) return -1;

            return A.ToList().IndexOf(potential);
        }
    }
}
