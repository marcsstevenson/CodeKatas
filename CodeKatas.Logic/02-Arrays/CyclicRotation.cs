using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Logic.Arrays
{
    public class CyclicRotation
    {
        /// <summary>
        /// The goal is to rotate array <paramref name="array"/>  <paramref name="rotation"/> times; that is, each element of A will be shifted to the right K times.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="K">The k.</param>
        /// <see>https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/</see>
        /// <returns></returns>
        public int[] Solve(int[] array, int rotation)
        {
            int[] output = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                var rotatedIndex = (i + rotation) % array.Length;

                output[rotatedIndex] = array[i];
            }

            return output;
        }
    }
}
