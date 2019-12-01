using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Logic.CountingElements
{
    public class MissingInteger
    {
        /// <summary>
        /// Returns the smallest positive integer (greater than 0) that does not occur in array.
        /// </summary>
        /// <param name="array">The array.</param>
        public int Solve(int[] array)
        {
            // We only care about positive integers
            // Only keep positive integers to speed up processing
            // We only care about distinct values
            array = array.Where(i => i > 0).Distinct().OrderBy(i => i).ToArray();

            // The next smallest positive integer is 1 if we have no elements
            if(array.Length == 0) return 1;

            // Handle the case of only 1 element in the array
            if (array.Length == 1) {
                if(array[0] == 1)
                    return 2;       
                else 
                    return 1;
            }

            // The array is contiguous if the max value is = to the number of elements
            // Therefore the smallest positive integer is simply 1 more than the max in the array
            if (array[array.Length - 1] == array.Length)
                return array.Length + 1;

            // We have gaps in the array - find the largest gap
            var lastValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                var currentValue = array[i];

                if (currentValue > lastValue + 1)
                {
                    return lastValue + 1;
                }

                lastValue = currentValue;
            }

            throw new Exception("We should never be here!");
        }
    }
}
