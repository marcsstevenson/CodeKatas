using System.Linq;

namespace CodeKatas.Logic.BinarySearch;

public class MinMaxDivision
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/14-binary_search_algorithm/min_max_division/
    /// 100%
    /// </summary>
    public int solution(int K, int M, int[] A)
    {
        int min = A.Max(); // The maximum value needs to go into a block at some stage
        int max = A.Sum(); // The worst case scenario is all summed

        int bestAnswer = max;

        // Guess our minimum block size and use a binary search to determine
        // if the guess is too small or too large based on the number of blocks
        // that the guess splits into.
        while (min <= max)
        {
            int mid = (min + max) / 2;
            int blocks = CheckBlocks(A, mid);

            if (blocks > K)
            { 
                // Too many blocks meaning that our guess was too small
                min = mid + 1;
            }
            else
            {
                // Our guess was too large
                max = mid - 1;

                // Update our bestAnswer if we have found better
                if (mid < bestAnswer)
                {
                    bestAnswer = mid;
                }
            }
        }

        return bestAnswer;
    }

    /// <summary>
    /// Take an array and a guess for the max block sum size and return
    /// the number of blocks that this results in
    /// </summary>
    public int CheckBlocks(int[] A, int guess)
    {
        int blocks = 1;
        int blockSum = 0;

        foreach (var a in A)
        {
            blockSum += a;

            // Are we over our guess value?
            if (blockSum > guess)
            {
                blocks++; // Increase the blocks
                blockSum = a; // set for the start of the next block
            }
        }

        return blocks;
    }
}
