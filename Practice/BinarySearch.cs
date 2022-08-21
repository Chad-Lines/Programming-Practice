namespace Practice;

public class BinarySearch
{
    // Perform a binary search on an array of numbers, looking for the 
    // target number
    public static int Search(int[] nums, int target)
    {
        // setting the search space from 0 to the length of the array
        int left = 0;
        int right = nums.Length - 1;

        // Loop 
        while (left <= right)
        {
            // Determine the mid-value in the search to compare with the target
            int mid = (left + right) / 2;

            // If the target is found, return it
            if (target == nums[mid]) return mid;

            // If the target is less than the mid, then set the right to mid - 1 (descreasing the search area)
            else if (target < nums[mid]) right = mid - 1;

            // If the target is more than the mid, then set the left to mid + 1 (descreasing the search area)
            else left = mid + 1;                            
        }

        // The target doesn't exist in the array 
        return -1;
    }

}
