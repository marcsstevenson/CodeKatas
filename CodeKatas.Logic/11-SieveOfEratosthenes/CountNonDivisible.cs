using System;
using System.Linq;

namespace CodeKatas.Logic.SieveOfEratosthenes;

public class CountNonDivisible
{    
    public int[] solution(int[] A)
    {
        int[,] D = new int[A.Max() + 1, 2];

        for (int i = 0; i < A.Length; i++)
        {
            var number = A[i];
            
            D[number, 0]++; // Count occurrences
            D[number, 1] = -1; // Mark as found
        }

        for (int i = 0; i < A.Length; i++)
        {
            var number = A[i];

            // Scan through the found
            if (D[number, 1] == -1)
            {
                D[number, 1] = 0;

                // Loop to the square root of the number
                for (int j = 1; j <= Math.Sqrt(number); j++)
                {
                    // Is J a divisor of the number?
                    if (number % j == 0)
                    {
                        if (number / j != j)
                        {
                            D[number, 1] += D[number / j, 0]; // ??!!
                        }

                        D[number, 1] += D[j, 0];
                    }
                }
            }
        }

        for (int i = 0; i < A.Length; i++)
        {
            // Assign the counts to each element
            A[i] = A.Length - D[A[i], 1];
        }

        return A;
    }
}
