using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Logic.Arrays;

public class CyclicRotation
{
    /// <summary>
    /// The goal is to rotate array <paramref name="A"/>  <paramref name="K"/> times; that is, each element of A will be shifted to the right K times.
    /// </summary>
    /// <param name="A">The array.</param>
    /// <param name="K">The k.</param>
    /// <see>https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/</see>
    /// <returns></returns>
    public int[] Solve(int[] A, int K)
    {
        if (A.Length == 0) return A;

        int[] output = new int[A.Length];
        
        for (int i = 0; i < A.Length; i++)
        {
            var rotatedIndex = (i + K) % A.Length;

            output[rotatedIndex] = A[i];
        }

        return output;
    }
}
