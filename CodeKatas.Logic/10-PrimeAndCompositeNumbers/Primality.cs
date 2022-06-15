namespace CodeKatas.Logic.PrimeAndCompositeNumbers;

public class Primality
{
    /// <summary>
    /// Returns if the number is prime.
    /// </summary>
    public static bool GetPrimality(int n)
    {
        if (n == 1) return false; // Handle corner-case

        int i = 2; // Don't include 1 because that's not a test of prime (everything is divisible by 1)
        
        // Iterate up to the square root of the number because
        // that is as far as needed to find all pairs of divisors.
        while (i * i <= n)
        {
            if (n % i == 0)
            {
                return false; // We found a pair so the number is not prime
            }

            i++;
        }

        // We made it this far
        return true;
    }
}
