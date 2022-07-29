using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

internal class QuickSort
{
    public static void Swap(int[] arr, int i, int j)
    {
        // Quickly swap two indexes in an array
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public static int Partition(int[] a, int start, int end)
    {
        // Pick the right-most element as the pivot from the given array
        int pivot = a[end];

        // Elements less than the pivot are sent to the left
        // Elements more than the pivot are sent to the right
        // Equal elements can go either way
        int pIndex = start;

        for (int i = start; i < end; i++)
        {
            // each time we find an element less than or equal to the pivot,
            // 'pIndex' is incremented, and that element would be placed
            // before the pivot.
            if (a[i] <= pivot)
            {
                Swap(a, i, pIndex);
                pIndex++;
            }
        }

        // swap 'pIndex' with pivot
        Swap(a, end, pIndex);

        return pIndex;
    }

    public static void Sort(int[] a, int start, int end)
    {
        // Make sure it's valid
        if (start >= end) return;

        // Rearrange the elements across pivot
        int pivot = Partition(a, start, end);

        // Recur on the subarray containing elements less than the pivot
        Sort(a, start, pivot - 1);

        // Recur on the subarray containing elements more than the pivot
        Sort(a, pivot + 1, end);
    }
}
