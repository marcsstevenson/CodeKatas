using System;

namespace CodeKatas.Logic.CaterpillarMethod;

public class Caterpillar
{
    /// <summary>
    /// Returns true if there are a sequence of elements that sum to the given number.
    /// </summary>
    public bool HasSebsequenceOfSum(int[] A, int sum)
    {
        var n = A.Length;
        int front = 0;
        int total = 0;

        for (int back = 0; back < n; back++)
        {
            while (front < n && total + A[front] <= sum)
            {
                total += A[front];
                front++;
            }

            if (total == sum)
            {
                // Search success
                return true;
            }

            // Move the back of the caterpillar forward
            total -= A[back];
        }

        // Search failure
        return false;
    }

    /// <summary>
    /// Returns the number of element combinations that can be used as sides of a triangle.
    /// Note: 3  lengths can be used as sides of a triangle if the sum of the lengths is 
    /// greater than the length of the longest side.
    /// </summary>
    public static int GetNumberOfTriangles(int[] A)
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
            for (int middle = back + 1; middle < front; middle++)
            {
                // Search for the front for triangles.
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

    /// <summary>
    /// Count the number of triangles that can be constructed using these sticks - A
    ///  More precisely, count the number of triplets at indices x<y<z such that A[x] + A[y] > A[z].
    /// </summary>
    public static int GetNumberOfTriangles2(int[] A)
    {
        var n = A.Length;
        int result = 0;

        for (int x = 0; x < n; x++)
        {
            int z = x + 2;

            for (int y = x + 1; y < n; y++)
            {
                while (z < n && A[x] + A[y] > A[z])
                {
                    z += 1;
                    result += z - y - 1;
                }
            }
        }

        // Search failure
        return result;
    }
}
