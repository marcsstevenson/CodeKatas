namespace CodeKatas.Logic.TimeComplexity;

public class FrogJump
{
    /// <summary>
    /// A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
    ///
    /// Count the minimal number of jumps that the small frog must perform to reach its target.
    /// </summary>
    /// <see cref="https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/"/>
    public int Solve(int X, int Y, int D)
    {
        var distanceToCover = Y - X;
        var hops = distanceToCover / D;

        // Add a last hop if needed
        if (distanceToCover % D > 0)
            hops++;
                   
        return hops;
    }
}
