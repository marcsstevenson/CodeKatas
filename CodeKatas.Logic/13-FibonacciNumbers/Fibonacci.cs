using System;
using System.Collections.Generic;

namespace CodeKatas.Logic.FibonacciNumbers;

public static class Fibonacci
{
    public static int[] GetFibonacciNumbers(int n, int? limit = null)
    {        
        return GetFibonacciNumbersAsList(n, limit).ToArray();
    }

    public static List<int> GetFibonacciNumbersAsList(int n, int? limit = null)
    {
        var fibonacciNumbers = new List<int>
        {
            0,
            1
        };

        for (int i = 2; i < n; i++)
        {
            var next = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            if (limit.HasValue && next > limit)
            {
                break; // We are at our limit
            }
            fibonacciNumbers.Add(next);
        }

        return fibonacciNumbers;
    }
    
    public static List<long> GetFibonacciNumbersAsListWithMod(int n, long? modulous = null)
    {
        modulous = modulous ?? (long)Math.Pow(2, 30);
        var fibonacciNumbers = new List<long>();
        fibonacciNumbers.Add(0);
        fibonacciNumbers.Add(1);

        for (int i = 2; i < n; i++)
        {
            fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2] % modulous.Value);
        }

        return fibonacciNumbers;
    }
}
