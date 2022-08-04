using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

internal class FirstAndLastPosition
{
    // Given a sorted array of integers (arr) and an integer of 'target', find the index
    // of the first and last position of 'target' in 'arr'. If the target can't be found,
    // then return [-1, -1]
    public static int[] Get(int[] arr, int target)
    {
        // Used to hold the index of the first occurance of 'target'
        int start = -1;

        // Used to hold the index of the first occurance of 'target'
        int end = -1;

        foreach (int i in arr)
        {
            if (start == -1 && i == target)
            {
                start = i;
                Console.WriteLine("Start found: " + i);
            }
            Console.WriteLine("i: " + i + ", target: " + target + ", i + 1: " + (i + 1));
            Console.WriteLine("arr[arr.Length - 1]: " + arr[arr.Length - 1]);

            if (i == arr[arr.Length - 1] && i + 1 == target)
            {
                continue;
                Console.WriteLine("Continue.");
            }
            else
            {
                end = i;
                break;
            }
        }


        // For each element in the array...
        //foreach (int i in arr)
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    // If the element is the first occurance of target, set the start to i
        //    if (start == -1 && arr[i] == target)
        //    {
        //        start = i;
        //        Console.WriteLine("Start found: " + i);
        //    }
        //    Console.WriteLine("[" + i + "] = " + arr[i].ToString() + ", target: " + target);
        //    Console.WriteLine("arr[i + 1] = " + arr[i + 1]);

        //    // If we haven't reached the end of the array, and the next element
        //    // in the array is still the target, then continue onward
        //    if (i + 1 < arr.Length && arr[i + 1] == target)
        //    {
        //        continue;
        //        Console.WriteLine("Continue.");
        //    }

        //    // If the array is ending, or the next element is NOT target,
        //    // then we set end to i
        //    else
        //    {
        //        end = i;
        //        break;
        //    }
        //}
        // Return the start and end indexes of the array
        return new int[] { start, end };
    }
}
