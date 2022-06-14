using System;

namespace CodeKatas.Logic.MaximumSliceProblem;

public class MaxProfit
{
    public int solution(int[] A)
    {
        if (A.Length < 2) return 0; //for empty array or 1 element array, no profit can be realized

        //convert profit table to delta table so can use max slice technique
        int[] deltaA = new int[A.Length];
        deltaA[0] = 0;
        
        for (int i = 1; i < A.Length; i++)
        {
            deltaA[i] = A[i] - A[i - 1];
        }

        int absoluteMax = deltaA[0];
        int localMax = deltaA[0];
        int nextSum;
        int currentDelta;

        for (int i = 1; i < deltaA.Length; i++) 
        { 
            currentDelta = deltaA[i]; 
            nextSum = localMax + currentDelta; 
            localMax = Math.Max(currentDelta, nextSum); 
            absoluteMax = Math.Max(absoluteMax, localMax); 
        }
        if (absoluteMax > 0) return absoluteMax;

        return 0;
    }
}
