using System;

namespace CodeKatas.Logic.PrimeAndCompositeNumbers;

public class MinPerimeterRectangle
{
    public int solution(int N)
    {
        // Find the first divisor starting at the square root of N
        // because the divisors that are closer in value give minimal perimeter
        int i = (int)Math.Floor(Math.Sqrt(N));

        // Iterate down from the root and use the first divisor found.
        while (i > 1)
        {
            // Is i a divisor of N?
            if (N % i == 0)
            {
                // One side of the rectangle is length i
                // The other side the must be N/i so that i * N/i = N (the area)

                // Return the resultant perimeter of this rectangle
                return (i + N/i) * 2; 
            }

            i--;
        }

        // worstCase result is 2 * (1 + N); // eg N = 30: (1, 30), with a perimeter of 62
        return 2 * (1 + N);
    }
}
