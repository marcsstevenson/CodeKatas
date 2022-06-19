using System;

namespace CodeKatas.Logic.Sorting;

public class NumberOfDiscIntersections
{
    /// <summary>
    /// We draw N discs on a plane. The discs are numbered from 0 to N − 1. An array A of N non-negative integers, specifying the radiuses of the discs, is given. The J-th disc is drawn with its center at (J, 0) and radius A[J].
    /// 
    /// We say that the J-th disc and K-th disc intersect if J ≠ K and the J-th and K-th discs have at least one common point(assuming that the discs contain their borders).
    /// 
    /// The figure below shows discs drawn for N = 6 and A as follows:
    /// 
    ///   A[0] = 1
    ///   A[1] = 5
    ///   A[2] = 2
    ///   A[3] = 1
    ///   A[4] = 4
    ///   A[5] = 0
    /// 
    /// There are eleven(unordered) pairs of discs that intersect, namely:
    /// 
    /// discs 1 and 4 intersect, and both intersect with all the other discs;
    ///         disc 2 also intersects with discs 0 and 3.
    /// Write a function:
    /// 
    /// class Solution { public int solution(int[] A); }
    /// 
    ///         that, given an array A describing N discs as explained above, returns the number of(unordered) pairs of intersecting discs.The function should return −1 if the number of intersecting pairs exceeds 10,000,000.
    /// 
    ///        Given array A shown above, the function should return 11, as explained above.
    /// 
    /// Write an efficient algorithm for the following assumptions:
    /// 
    ///     N is an integer within the range[0..100, 000];
    ///     each element of array A is an integer within the range[0..2, 147, 483, 647].
    /// </summary>    /// 
    /// <remarks>100%</remarks>
    public int Solve(int[] A)
    {
        // main idea:
        // 1. store all the "lower points" and "upper points" of the discs
        // 2. count the intersections (if one upper point > one lower point)

        // note: use "long" for big numbers (be careful)
        long[] lower = new long[A.Length];
        long[] upper = new long[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            lower[i] = i - (long)A[i]; // note: lower = center - A[i]
            upper[i] = i + (long)A[i]; // note: upper = center + A[i]
        }

        // "sort" the "lower points" and "upper points"
        Array.Sort(upper);
        Array.Sort(lower);

        int intersections = 0; // number of intersections
        int j = 0; // for the lower points
        
        // scan the upper points
        for (int i = 0; i < A.Length; i++)
        {
            // for the current "j" (lower point)
            while (j < A.Length && upper[i] >= lower[j])
            {
                intersections += j; // add j intersections
                intersections -= i; // minus "i" (avoid double count) 
                j++;
            }

            // for the overflow cases
            if (intersections > 10000000)
                return -1;
        }

        return intersections; // number of intersections      
    }

    public int Solve2(int[] A)
    {
        // Create a arrays containing the west and east x transects of each circle
        int[] westEnding = new int[A.Length];
        int[] eastEnding = new int[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            var aVal = A[i];

            // Is the West transect positive?
            if (i - aVal >= 0)
                eastEnding[i - aVal]++;
            else
                eastEnding[0]++;

            // Is the East transect positive?
            if ((long)i + aVal < A.Length)
                westEnding[i + aVal]++;
            else
                westEnding[A.Length - 1]++;
        }

        long result = 0; // long to contain the case of 50k*50k. Codility doesn't test for this.
        int wests = 0;
        int easts = 0;

        for (int i = 0; i < A.Length; i++)
        {
            int balance = easts * wests; // these are calculated elsewhere

            wests++;
            easts += eastEnding[i];

            result += (long)easts * wests - balance - 1; // 1 stands for the self-intersection

            if (result > 10000000) return -1;

            easts--;
            wests -= westEnding[i];
        }

        return (int)result;
    }
}
