using System;
using System.Collections.Generic;

namespace CodeKatas.Logic.PrimeAndCompositeNumbers;

public class Peaks
{
    public int solution(int[] A)
    {
        List<int> factors = new List<int>();        
        int N = A.Length;
        int sqrtN = (int)Math.Sqrt(N);
        
        // Find all of the factors/divisors up until sqrtN
        for (int x = 1; x <= sqrtN; x++)
        {
            if (N % x == 0)
            {
                factors.Add(x);
                factors.Add(N / x);
            }
        }

        int i, m, all = 0, max = 0;
        
        for (int j = 0; j < factors.Count; j++)
        {
            int division = factors[j];
            
            if (division == N) continue;

            for (int k = 0; k < division; k++)
            {
                all = 0;
                m = N / division;
                for (int it = 0; it < m; it++)
                {
                    i = k * m + it;
                    if (i == 0 || i == N - 1) continue;
                    if (A[i] > A[i - 1] && A[i] > A[i + 1])
                        all++;
                }

                if (all == 0)
                    break;
            }

            if (all != 0)
            {
                if (division > max)
                    max = division;
            }
        }

        return max;
    }
}
