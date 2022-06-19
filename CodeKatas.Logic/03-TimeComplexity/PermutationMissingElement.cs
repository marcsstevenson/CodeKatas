using System;
using System.Linq;

namespace CodeKatas.Logic.TimeComplexity;

public class PermutationMissingElement
{
    /// <summary>
    /// An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.
    /// Your goal is to find that missing element.
    /// </summary>
    /// <see cref="https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/"/>
    public int Solution2(int[] A)
    {
        // n is the expected number of elements without the missing element
        var n = A.Length + 1;

        // Sum all elements
        var actualTotal = A.Sum();

        var expectedTotal = n * (n + 1) / 2;

        // The missing element is simply the expected minus the actual
        return expectedTotal - actualTotal;
    }

    /// <summary>
    /// An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.
    /// Your goal is to find that missing element.
    /// </summary>
    /// <see cref="https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/"/>
    /// <remarks>100%</remarks>
    public int Solution(int[] A)
    {
        if (A.Length == 0) return 1;

        var AMod = A.ToList().Distinct().OrderBy(i => i).ToList();
                
        // index + 1 should = array value
        //0 1 2 3
        //1 2 3 4
        for (int i = 0; i < AMod.Count(); i++)
        {
            if (AMod[i] != i + 1)
                return i + 1;
        }

        return AMod.Count() + 1;
    }
}
