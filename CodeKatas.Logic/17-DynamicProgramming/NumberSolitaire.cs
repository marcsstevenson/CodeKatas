using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Logic.DynamicProgramming;

public class NumberSolitaire
{
    /// <summary>
    /// The idea of dynamic programming is that we work things out as we progress
    /// and we remember results as we go. For this task we build determine the best 
    /// option dynamically based on the previous 6 steps (using a dice)
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    public int solution(int[] A)
    {
        if (A.Length == 0) return 0;
        
        var options = new List<int>();

        for (int i = 0; i < A.Length; i++)
        {            
            int elementVal = A[i];
            
            // Use the current element value + the best of the previous
            // 6 options
            int option = elementVal + (options.Any() ? options.Max() : 0);

            if (options.Count == 6)
            {
                // Remove the first
                options.RemoveAt(0);
            }
            
            // Add the current
            options.Add(option);

        }

        // The solution is simply the last option
        // once we have iterated to the end of the array
        return options.Last();
    }
}
