namespace Practice;

public class FirstAndLastPosition
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

        for (int i = 0; i < arr.Length; i++)
        {
            // If we haven't determined the start yet, and the current index is the target
            // then set 'start' to the current index
            if (start == -1 && arr[i]== target) start = i;

            // Otherwise...
            else
            {
                // While the current index is still equal to the target 
                // (there should be at least two instances of the target)
                while (arr[i] == target)
                {
                    // Check to see if we've reached the end of the array
                    // If we have, then we assign the end index
                    if (i == arr.Length - 1)
                    {
                        end = i;
                        break;
                    }

                    // See if the next index does NOT equal the target
                    // If that's true, we assign the end index 
                    else if (arr[i + 1] != target)
                    {
                        end = i;
                        break;
                    }

                    // If we're not at the end of the array, and the next
                    // index still equals the target, then we increment the
                    // index, and try again.
                    else
                    {
                        i++;
                        continue;
                    }
                }
            }
        }
        // Finally we return the start and end indexes
        return new int[] { start, end };
    }
}
