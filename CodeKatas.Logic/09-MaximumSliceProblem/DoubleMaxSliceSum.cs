using System;

namespace CodeKatas.Logic.MaximumSliceProblem;

public class DoubleMaxSliceSum
{
    public int solution(int[] A)
    {
        int[] slice1LocalMax = new int[A.Length];
        int[] slice2LocalMax = new int[A.Length];

        for (int i = 1; i < A.Length; i++)
        {
            slice1LocalMax[i] = Math.Max(slice1LocalMax[i - 1] + A[i], 0);
        }

        //start from i=A.length-2 because slice can't end at index A.length-1
        for (int i = A.Length - 2; i > 0; i--)
        {
            slice2LocalMax[i] = Math.Max(slice2LocalMax[i + 1] + A[i], 0);
        }

        int maxDoubleSliceSum = 0;

        //compute sums of all slices to find absolute max
        for (int i = 1; i < A.Length - 1; i++)
        {
            maxDoubleSliceSum = Math.Max(maxDoubleSliceSum, slice1LocalMax[i - 1] + slice2LocalMax[i + 1]);
        }

        return maxDoubleSliceSum;
    }
}
