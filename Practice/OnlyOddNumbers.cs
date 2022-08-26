namespace Practice;

public class OnlyOddNumbers
{
    public static int[] Get(int[] nums)
    {
        int[] output = new int[5];      // Creating an empty array
        int idx = 0;                    // This will hold the index of the new array

        foreach (int i in nums)         // For each int in the array
        {
            if (i % 2 == 0) continue;   // If it's divisible by 2 (i.e. even), move on
            else
            {
                output[idx] = i;        // Otherwise (i.e. if it's odd), add it to the array at the index
                idx++;                  // Increment the index in preparation for the next element
            }
        }

        return output;                  // return the list
    }
}
