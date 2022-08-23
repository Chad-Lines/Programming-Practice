namespace Practice;

public class OnlyOddNumbers
{
    public static int[] Get(int[] nums)
    {
        int[] output = new int[5];      // Creating an empty array

        foreach (int i in nums)         // For each int in the array
        {
            if (i % 2 == 0) continue;   // If it's divisible by 2 (i.e. even), move on
            else output.Append(i);      // otherwise (i.e. if it's odd), add it to the array
        }

        return output;                  // return the list
    }
}
