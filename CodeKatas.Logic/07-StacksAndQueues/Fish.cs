using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Logic.StacksAndQueues;

public class Fish
{
    /// <remarks>100%</remarks>
    public int solution(int[] A, int[] B)
    {
        var allGoingUp = new Stack<int>();
        int fishEaten = 0;

        for (int i = 0; i < A.Length; i++)
        {
            var direction = B[i];

            if (direction == 1)
            {
                allGoingUp.Push(A[i]);
            }
            else
            {
                // Who is bigger?
                var goingDownFish = A[i];

                while (allGoingUp.Any())
                {
                    fishEaten++; // There will always be a fish eaten
                    var goingUpFish = allGoingUp.Peek();
                    
                    if (goingDownFish > goingUpFish)
                    {
                        // going down ate going up
                        allGoingUp.Pop();
                    }
                    else
                    {
                        // going up ate going down
                        break;
                    }
                }
            }
        }

        return A.Length - fishEaten;
    }
}
