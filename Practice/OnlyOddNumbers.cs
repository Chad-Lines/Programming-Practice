using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class OnlyOddNumbers
    {
        public static List<int> Get(int[] nums)
        {
            List<int> output = new();       // Creating an empty list

            foreach (int i in nums)         // For each int in the array
            {
                if (i % 2 == 0) continue;   // If it's divisible by 2 (i.e. even), move on
                else output.Add(i);         // otherwise (i.e. if it's odd), add it to the list
            }

            return output;                  // return the list
        }
    }
}
