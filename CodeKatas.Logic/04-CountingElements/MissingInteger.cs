using System;
using System.Linq;

namespace CodeKatas.Logic.CountingElements;

public class MissingInteger
{
    /// <remarks>100%</returns>
    public int SolveWithLinq(int[] A)
    {
        var sorted = A
            .Where(i => i > 0)
            .Distinct()
            .OrderBy(i => i)
            .Select((item, index) => new { Value = item, Index = index })
            .ToArray();

        if (!sorted.Any()) return 1;

        // Return length + 1 if we have a value for each index
        if (sorted[sorted.Length - 1].Value == sorted.Length)
            return sorted.Length + 1;

        // Refine down to a list where value != index
        var mismatches = sorted
            .Where(i => i.Index + 1 != i.Value)
            .ToList();

        // This should never happen
        //if (!mismatches.Any()) return sorted.Length + 1;

        // Return the min value that != index
        return mismatches.Min(i => i.Index) + 1;
    }

    /// <summary>
    /// Returns the smallest positive integer (greater than 0) that does not occur in array.
    /// </summary>
    /// <param name="A">The array.</param>
    public int Solve(int[] A)
    {
        // We only care about positive integers
        // Only keep positive integers to speed up processing
        // We only care about distinct values
        A = A.Where(i => i > 0).Distinct().OrderBy(i => i).ToArray();

        // The next smallest positive integer is 1 if we have no elements
        if (A.Length == 0) return 1;

        // Handle the case of only 1 element in the array
        if (A.Length == 1)
        {
            if (A[0] == 1)
                return 2;
            else
                return 1;
        }

        // The array is contiguous if the max value is = to the number of elements
        // Therefore the smallest positive integer is simply 1 more than the max in the array
        if (A[A.Length - 1] == A.Length)
            return A.Length + 1;

        // We have gaps in the array - find the largest gap
        var lastValue = A[0];

        for (int i = 1; i < A.Length; i++)
        {
            var currentValue = A[i];

            if (currentValue > lastValue + 1)
            {
                // The gap is more than 1
                return lastValue + 1;
            }

            lastValue = currentValue;
        }

        throw new Exception("We should never be here!");
    }
}
