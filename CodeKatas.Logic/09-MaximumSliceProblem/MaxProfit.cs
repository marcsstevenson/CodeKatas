using System;
using System.Collections.Generic;

namespace CodeKatas.Logic.MaximumSliceProblem;

public class MaxProfit
{
    /// <remarks>
    /// 100%
    /// </remarks>
    public int solution(int[] A)
    {
        // Build a list of deltas for all elements
        var deltas = new List<int>() { 0 };

        for (int i = 1; i < A.Length; i++)
        {
            deltas.Add(A[i] - A[i - 1]);
        }

        // Iterate over all deltas to determine the max overall delta
        int localMax = 0;
        int absoluteMax = 0;

        for (int i = 1; i < deltas.Count; i++)
        {
            var currentDelta = deltas[i];
            var nextSum = localMax + currentDelta;
            localMax = Math.Max(currentDelta, nextSum);
            absoluteMax = Math.Max(localMax, absoluteMax);
        }

        return absoluteMax > 0 ? absoluteMax : 0;
    }
}
