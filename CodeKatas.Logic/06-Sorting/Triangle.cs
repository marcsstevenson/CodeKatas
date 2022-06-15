using System;

namespace CodeKatas.Logic.Sorting;

public class Triangle
{
    /// <summary>
    /// An array A consisting of N integers is given. A triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and:
    /// A[P] + A[Q] > A[R],
    /// A[Q] + A[R] > A[P],
    /// A[R] + A[P] > A[Q].
    /// For example, consider array A such that:
    /// 
    ///   A[0] = 10    A[1] = 2    A[2] = 5
    ///   A[3] = 1     A[4] = 8    A[5] = 20
    /// Triplet(0, 2, 4) is triangular.
    /// 
    /// Write a function:
    /// 
    /// class Solution { public int solution(int[] A); }
    /// 
    /// that, given an array A consisting of N integers, returns 1 if there exists a triangular triplet for this array and returns 0 otherwise.
    /// 
    /// For example, given array A such that:
    /// 
    ///   A[0] = 10    A[1] = 2    A[2] = 5
    ///   A[3] = 1     A[4] = 8    A[5] = 20
    /// the function should return 1, as explained above.Given array A such that:
    /// 
    ///   A[0] = 10    A[1] = 50    A[2] = 5
    ///   A[3] = 1
    /// the function should return 0.
    /// 
    /// Write an efficient algorithm for the following assumptions:
    /// 
    ///     N is an integer within the range[0..100, 000];
    ///     each element of array A is an integer within the range[−2, 147, 483, 648..2, 147, 483, 647].
    /// </summary>
    public int Solve(int[] a)
    {
        if (a.Length < 3) return 0;

        Array.Sort(a);

        // By sorting the array, we have guaranteed that P+R > Q and Q+R > P (because R is always the biggest). 
        // Now what remains, is the proof that P+Q > R, that can be found out by traversing the array.

        for (int i = 0; i < a.Length - 2; i++)
        {
            if (a[i] + a[i + 1] > a[i + 2])
            {
                return 1;
            }

            // Handle the corner case of having at least 3 x int.MaxValue
            if (a[i] == a[i + 2] &&
                a[i + 2] == a[i + 1] &&
                a[i] == int.MaxValue)
            {
                return 1;
            }
        }
        return 0;
    }
}
