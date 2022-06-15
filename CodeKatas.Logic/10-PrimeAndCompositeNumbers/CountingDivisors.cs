namespace CodeKatas.Logic.PrimeAndCompositeNumbers;

public class CountingDivisors
{
    /// <summary>
    /// Returns the count of divisors of a number.
    /// </summary>
    /// <remarks>Divisors are also known as factors</remarks>
    public uint GetDivisors(uint n)
    {
        uint i = 1;
        uint divisors = 0;

        // Iterate up to the square root of the number because
        // that is as far as needed to find all pairs of divisors.
        while (i * i < n)
        {
            if (n % i == 0)
            {
                divisors += 2; // We found a pair
            }

            i++;
        }

        // Check if the number is a perfect square
        if (i * i == n)
            divisors += 1; // Only count unique results when we find the square root

        return divisors;
    }

    /// <summary>
    /// Returns the count of divisors of a number.
    /// </summary>
    /// <remarks>Double counts :/ Eg, for 6, it counts 2*3 and 3*2 </remarks>
    public int GetDivisorsSlow(int n)
    {
        int divisors = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                divisors++;
            }
        }

        return divisors;
    }
}
