using System;

namespace CodeKatas.Logic.SieveOfEratosthenes;

public class CountSemiprimes
{
    public int[] solution(int N, int[] P, int[] Q)
    {
        int length = P.Length; // P and Q have the same length
        int[] result = new int[length]; // The need a result for all elements in P and Q
        int[] primes = sieve(N); // Get the primes of N
        int[] semiprimes = semiprime(primes); // Get the sub-primes of N
        
        int[] semiprimesAggreation = new int[N + 1];
        
        for (int i = 1; i < N + 1; i++)
        {
            semiprimesAggreation[i] = semiprimes[i];
            semiprimesAggreation[i] = semiprimesAggreation[i] + semiprimesAggreation[i - 1];
        }

        // Compile the results
        for (int i = 0; i < length; i++)
        {
            var number = Q[i];
            result[i] = semiprimesAggreation[number] - semiprimesAggreation[number] + semiprimes[number];
        }

        return result;
    }

    public int[] sieve(int N)
    {
        int[] prime = new int[N + 1];
        for (int i = 2; i <= Math.Sqrt(N); i++)
        {
            if ((prime[i] == 0))
            {
                int k = (i * i);
                while ((k <= N))
                {
                    if (prime[k] == 0)
                    {
                        prime[k] = i;
                    }

                    k += i;
                }
            }
        }

        return prime;
    }

    public int[] semiprime(int[] primes)
    {
        int[] semiprime = new int[primes.Length];
        
        for (int i = 0; (i < primes.Length); i++)
        {
            int prime = primes[i];
            
            if ((prime == 0)) continue;
                        
            if ((primes[(i / prime)] == 0))
            {
                semiprime[i] = 1;
            }
        }

        return semiprime;
    }
}
