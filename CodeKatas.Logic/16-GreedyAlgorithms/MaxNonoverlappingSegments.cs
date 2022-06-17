namespace CodeKatas.Logic.GreedyAlgorithms;

public class MaxNonoverlappingSegments
{
    public int solution(int[] A, int[] B)
    {
        var n = A.Length;

        int segmentCount = 0;
        int pos = -1;

        // Use a greedy algorithm to build sets of segments that do not overlap
        for (int i = 0; i < n; i++)
        {            
            if (A[i] > pos)
            {
                pos = B[i];
                segmentCount++;
            }
        }
        
        return segmentCount;
    }
}
