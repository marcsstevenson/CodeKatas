using System;

namespace CodeKatas.Logic.CaterpillarMethod;

public class CountTriangles
{
    /// <summary>
    /// Returns the number of element combinations that can be used as sides of a triangle.
    /// Note: 3  lengths can be used as sides of a triangle if the sum of the lengths is 
    /// greater than the length of the longest side.
    /// </summary>
    public int solution(int[] A)
    {
        // Sort the array which simplifies the problem
        Array.Sort(A);
        var n = A.Length;
        int result = 0;

        // Eg sorted
        // 1, 2, 5, 8, 10, 12

        // Iterate the back
        // Note: The back can not use the last two elements because middle and front will need these
        for (int back = 0; back < n - 2; back++)
        {
            int front = back + 2; // Front is always at least 2 elements ahead of the back

            // Note: The back can not use the last elements because front will need this
            for (int middle = back + 1; middle < n - 1; middle++)
            {
                // Count all of the front indexes that are small enough in value to satisfy our triangle constraint.
                // Note: front is always the longest side of the triangle because we sorted the list ;)
                while (front < n && A[back] + A[middle] > A[front])
                {
                    front++;
                    //result++;
                }

                result += front - middle - 1;
            }
        }

        return result;
    }
}
