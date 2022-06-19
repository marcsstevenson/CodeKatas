using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Logic.Leader;

public class EquiLeader
{
    /// <remarks>100%</remarks>
    public int solution(int[] A)
    {
        var N = A.Length;
        int splits = 0;

        // Determine the leader
        var sorted = A.OrderBy(i => i);
        int leader = A.OrderBy(i => i).ElementAt(A.Length / 2);
        
        // Now count the splits
        int leadersLeft = 0;
        int leadersRight = A.Count(i => i == leader);
        
        for (int i = 0; i < N - 1; i++)
        {
            var element = A[i];
            if (element == leader)
            {
                leadersLeft++;
                leadersRight--;
            }

            // Do we have split?
            var hasLeadersLeft = leadersLeft * 2 > i + 1;
            var hasLeadersRight = leadersRight * 2 > (N - i - 1);

            if (hasLeadersLeft && hasLeadersRight)
            {
                splits++;
            }
        }

        return splits;
    }
    public int solution2(int[] A)
    {
        var stack = new Stack<int>();

        for (int i = 0; i < A.Length; i++)
        {
            if (!stack.Any())
            {
                stack.Push(A[i]);
            }
            else
            {
                if (stack.Peek() == A[i])
                {
                    stack.Push(A[i]);
                }
                else
                {
                    stack.Pop();
                }
            }
        }

        //no equi leaders if stack is empty
        if (!stack.Any()) return 0;
        int candidate = stack.Peek();
        int dominatorCount = 0;

        //Map<Integer, Integer> dominatorMap = new HashMap<Integer, Integer>();
        Dictionary<int, int?> dominatorMap = new();
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == candidate)
            {
                dominatorCount++;
                dominatorMap.Add(i, dominatorCount);
            }
        } //works for even and odd number of A elements //e.g. if A.Length = 4, count needs to be > 2
          //e.g. if A.Length = 5, count needs to be > 2

        int equiLeaders = 0;
        if (dominatorCount > (A.Length / 2))
        {
            //find all equi leader sequences

            int lastCandidateOccurenceIndex = 0;
            int runningDominatorCount = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] == candidate)
                {
                    lastCandidateOccurenceIndex = i;
                    runningDominatorCount = dominatorMap[i].Value;
                }
                else if (dominatorMap.ContainsKey(lastCandidateOccurenceIndex))
                {
                    runningDominatorCount = dominatorMap[lastCandidateOccurenceIndex].Value;
                }
                if (runningDominatorCount > (i + 1) / 2)
                {
                    if ((dominatorCount - runningDominatorCount) > (A.Length - (i + 1)) / 2)
                    {
                        equiLeaders++;
                    }
                }
            }
        }
        return equiLeaders;
    }
}
