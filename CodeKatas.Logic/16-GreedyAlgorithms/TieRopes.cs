namespace CodeKatas.Logic.GreedyAlgorithms;

public class TieRopes
{
    public int solution(int K, int[] A)
    {
        int ropeCount = 0;
        int batchLength = 0;

        for (int i = 0; i < A.Length; i++)
        {
            batchLength += A[i]; // Add the length of the current rope to the batch

            // Are we on over the limit? And have more than 1 rope in our batch?
            if (batchLength >= K)
            {
                ropeCount++;                
                batchLength = 0; // Start a new rope
            }    
        }

        return ropeCount;
    }        
}
