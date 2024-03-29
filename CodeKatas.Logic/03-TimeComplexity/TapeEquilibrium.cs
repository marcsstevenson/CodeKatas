﻿using System;
using System.Linq;

namespace CodeKatas.Logic.TimeComplexity;

public class TapeEquilibrium
{
    /// <summary>
    /// A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.
    /// Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].
    /// The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
    /// In other words, it is the absolute difference between the sum of the first part and the sum of the second part.
    /// For example, consider array A such that:
    /// A[0] = 3
    /// A[1] = 1
    /// A[2] = 2
    /// A[3] = 4
    /// A[4] = 3
    /// We can split this tape in four places:
    /// P = 1, difference = | 3 − 10| = 7
    /// P = 2, difference = | 4 − 9| = 5
    /// P = 3, difference = | 6 − 7| = 1
    /// P = 4, difference = | 10 − 3| = 7
    /// </summary>
    /// <param name="A">The array.</param>
    /// <remarks>100%</remarks>
    public int Solve(int[] A)
    {
        int sumRight = A.Sum();

        int sumLeft = 0;
        int min = int.MaxValue;

        // Loop through the array while adding to left and removing from right
        // Run a comparison at each index
        for (int P = 1; P < A.Length; P++)
        {
            sumLeft += A[P - 1];
            sumRight -= A[P - 1];

            int diff = Math.Abs(sumLeft - sumRight);

            if (diff < min)
            {
                min = diff;
            }
        }
        return min;
    }
}
