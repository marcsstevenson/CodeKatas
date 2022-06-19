using System;

namespace CodeKatas.Logic.PrefixSums;

public class CountDiv
{
    /// <summary>
    /// Write a function:
    ///  
    ///     class Solution { public int solution(int A, int B, int K); }
    ///  
    /// that, given three integers A, B and K, returns the number of integers within the range[A..B] that are divisible by K, i.e.:
    ///  
    ///  { i : A ≤ i ≤ B, i mod K = 0 }
    ///  
    /// For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range[6..11], namely 6, 8 and 10.
    ///  
    ///  Write an efficient algorithm for the following assumptions:
    ///  
    ///  A and B are integers within the range[0..2, 000, 000, 000];
    ///      K is an integer within the range[1..2, 000, 000, 000];
    ///  A ≤ B.
    /// </summary>
    /// <see cref="https://app.codility.com/programmers/lessons/5-prefix_sums/min_avg_two_slice/"/>
    /// <remarks>100%</remarks>
    public int Solve(int A, int B, int K)
    {            
        // Explanation: Number of integers in the range[1..B] that divisible by K is B / K.
        // So, within the range[A..B], the result is B / K - (A - 1) / K
        // In case a is 0, as 0 is divisible by any positive number, we need to count it in.

        //int offsetForLeftRange = 0;

        //if (a % k == 0) { ++offsetForLeftRange; }

        //return (b / k) - (a / k) + offsetForLeftRange;

        int bDiv = B / K;
        int aDiv = (A > 0 ? (A - 1) / K : 0);
        if (A == 0)
        {
            bDiv++;
        }
        return bDiv - aDiv;
    }
}
