using System;

namespace CodeKatas.Logic.MaximumSliceProblem;

public class DoubleMaxSliceSum
{
    public int solution(int[] A)
    {
        int absoluteMax = A[0];
        int localMax = A[0];
        int nextSum;
        int currentElement;

        for (int i = 1; i < A.Length; i++)
        {
            currentElement = A[i];
            nextSum = localMax + currentElement;
            localMax = Math.Max(currentElement, nextSum);
            absoluteMax = Math.Max(absoluteMax, localMax);
        }

        return absoluteMax;
    }
}
