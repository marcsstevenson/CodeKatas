using System.Collections.Generic;

namespace CodeKatas.Logic.EuclideanAlgorithm;

public class CommonPrimeDivisors
{
    /// <summary>
    /// Given two non-empty arrays A and B of Z integers, return the number of positions K for which the prime divisors of A[K] and B[K] 
    /// are exactly the same.
    /// </summary>
    /// <remarks><see cref="https://app.codility.com/programmers/lessons/12-euclidean_algorithm/common_prime_divisors/"/></remarks>
    public int solution(int[] A, int[] B)
    {
        int count = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (HasSamePrimeDivisors(A[i], B[i]))
            {
                count++;
            }
        }
        return count;
    }

    public bool HasSamePrimeDivisors(int aInit, int bInit)
    {
        int a = aInit;
        int b = bInit;
        int gcdValue = Euclidean.ByDivision(a, b);
        int gcdA;
        int gcdB;
        
        while (a != 1)
        {
            gcdA = Euclidean.ByDivision(a, gcdValue);
            if (gcdA == 1)
                break;
            a = a / gcdA;
        }
        
        if (a != 1)
        {
            return false;
        }
        
        while (b != 1)
        {
            gcdB = Euclidean.ByDivision(b, gcdValue);
            if (gcdB == 1)
                break;
            b = b / gcdB;
        }
        
        return b == 1;
    }
}
