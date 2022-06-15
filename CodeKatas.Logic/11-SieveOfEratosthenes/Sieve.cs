using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Logic.SieveOfEratosthenes;

/// <summary>
///  Sieve of Eratosthenes
/// </summary>
public class Sieve
{
    public bool[] SieveNumbers(int n)
    {
        var sieve = Enumerable.Range(0, n + 1).Select(i => true).ToArray();
        sieve[0] = false;
        sieve[1] = false;

        var i = 2;
        while (i * i <= n)
        {
            if (sieve[i]) // Sieve if still true
            {
                // Mark all i * i multiples as false
                for (var k = i * i; k <= n; k+=i)
                {
                    sieve[k] = false;
                }
            }
            i++;
        }

        return sieve;
    }

    public int[] Factorise(int n)
    {
        var factors = new int[n + 1];
        var i = 2;
        
        while (i * i <= n)
        {
            if (factors[i] == 0)
            {
                for (var k = i * i; k <= n; k += i)
                {
                    if (factors[k] == 0)
                    {
                        factors[k] = i;
                    }
                }
            }
            i++;
        }

        return factors;
    }
    
    public int[] Factorisation(int x, int[] factors)
    {
        var primeFactors = new List<int>();

        while (factors[x] > 0)
        {
            primeFactors.Add(factors[x]);
            x /= factors[x];
        }

        return primeFactors.ToArray();
    }
}
