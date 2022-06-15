using System.Linq;

namespace CodeKatas.Logic.TimeComplexity;

public class PermutationMissingElement
{
    /// <summary>
    /// An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.
    /// Your goal is to find that missing element.
    /// </summary>
    /// <see cref="https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/"/>
    public int Solve(int[] array)
    {
        // n is the expected number of elements without the missing element
        var n = array.Length + 1;

        // Sum all elements
        var actualTotal = array.Sum();

        var expectedTotal = n * (n + 1) / 2;

        // The missing element is simply the expected minus the actual
        return expectedTotal - actualTotal;
    }
}
