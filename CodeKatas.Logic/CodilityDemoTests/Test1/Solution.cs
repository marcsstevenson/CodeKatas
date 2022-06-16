using System.Linq;

namespace CodeKatas.Logic.CodilityDemoTests.Test1;

/// <summary>
/// This is a demo task.
//Write a function:
//class Solution { public int solution(int[] A); }
//that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.
//For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
//Given A = [1, 2, 3], the function should return 4.
//Given A = [−1, −3], the function should return 1.
//Write an efficient algorithm for the following assumptions:
//N is an integer within the range[1..100, 000];
//each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].
/// </summary>

// 100%
public class Solution
{
    
    public int solution(int[] A)
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
}
