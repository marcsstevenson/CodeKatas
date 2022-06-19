namespace CodeKatas.Logic.StacksAndQueues;

/// <remarks>100%</remarks>
public class StoneWall
{
    /// Translated from python: https://codility.com/media/train/solution-stone-wall.pdf
    public int Solution(int[] H)
    {
        var N = H.Length;
        int stones = 0;
        int[] stack = new int[N];
        int stackNum = 0;

        for (int i = 0; i < H.Length; i++)
        {
            while (stackNum > 0 && stack[stackNum - 1] > H[i])
            {
                stackNum--;
            }

            if (stackNum > 0 && stack[stackNum - 1] == H[i])
            {
                continue;
            }
            else
            {
                stones++;
                stack[stackNum] = H[i];
                stackNum++;
            }
        }

        return stones;
    }

    public class Block
    {        
        public Block(int lowerHeight, int upperHeight)
        {
            LowerHeight = lowerHeight;
            UpperHeight = upperHeight;
        }

        public int LowerHeight { get; }
        public int UpperHeight { get; }
    }
}
