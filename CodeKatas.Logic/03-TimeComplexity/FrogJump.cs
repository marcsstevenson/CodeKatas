namespace CodeKatas.Logic.TimeComplexity
{
    public class FrogJump
    {
        /// <summary>
        /// A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
        ///
        /// Count the minimal number of jumps that the small frog must perform to reach its target.
        /// </summary>
        /// <see cref="https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/"/>
        public int Solve(int x, int y, int d)
        {
            var distanceToCover = y - x;
            var hops = distanceToCover / d;

            // Add a last hop if needed
            if (distanceToCover % d > 0)
                hops++;
                       
            return hops;
        }
    }
}
