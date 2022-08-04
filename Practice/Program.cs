using System.Linq;

namespace Practice;

internal class Program
{
    static void Main()
    {
        Console.Clear();

        int choice;

        Console.WriteLine("\nWhat do you want to do? Enter the corresponding number:\n");
        Console.WriteLine("1. Perform a Binary Search");
        Console.WriteLine("2. Perform a Quick Sort");
        Console.WriteLine("3. Find the first Repeating Character in String");
        Console.WriteLine("4. Find the Min and Max in an Array");
        Console.WriteLine("5. Get the odd numbers between 1 and 10");
        Console.WriteLine("6. Return whether two words are anagrams");
        Console.WriteLine("7. Get first and last index in a sorted array");

        Console.WriteLine("\n");

        string input = Console.ReadLine();            

        if(Int32.TryParse(input, out choice))
        {
            switch (choice)
            {
                case 1:
                    BinarySearchSelection();
                    break;
                case 2:
                    QuickSortSelection();
                    break;
                case 3:
                    RepeatCharactersSelection();
                    break;
                case 4:
                    GetMinAndMaxFromArraySelection();
                    break;
                case 5:
                    OnlyOddNumbersSelection();
                    break;
                case 6:
                    AnagramSelection();
                    break;
                case 7:
                    FirstAndLastSelection();
                    break;
                default:
                    Invalid();
                    break;
            }
        }
        else
        {
            Invalid();                
        }
    }
            

    static void BinarySearchSelection()
    {
        int choice;
        int[] nums = Enumerable.Range(1, 100).ToArray();
        
        Console.WriteLine("\nPlease enter a number between 1 and 100.\n");

        string input = Console.ReadLine();

        if (Int32.TryParse(input, out choice))
        {
            int idx = BinarySearch.Search(nums, choice);
            Console.WriteLine("\n" + choice.ToString() + " found at index: " + idx.ToString() + "\n");
            Again();
        }
        else Invalid();
    }

    static void QuickSortSelection()
    {
        int[] array = { 9, -3, 5, 2, 6, 8, -6, 1, 3 };
        Console.Write("\nWe will quicksort the following numbers: ");
        foreach (int i in array) { Console.Write("{0} ", i); }

        QuickSort.Sort(array, 0, array.Length - 1);

        Console.Write("\nViola! ");
        foreach (int i in array) { Console.Write("{0} ", i); }
        Console.Write("\n");

        Again();
    }

    static void RepeatCharactersSelection()
    {
        
        Console.WriteLine("\nPlease enter a word of your choice.\n");
        string choice = Console.ReadLine();
        char output = RepeatCharacters.FindRepeat(choice);

        Console.WriteLine("\nRepeating character is: (-1 indicates no repeating character)\n");
        Console.WriteLine(output);
        Again();

    }

    static void GetMinAndMaxFromArraySelection()
    {

        int[] array = { 5, 7, 1, 4, 2, 8, 4, 8, 1, 3, 5 };
        Console.Write("\nWe will find the Min and Max of the following numbers: ");
        foreach (int i in array) { Console.Write("{0} ", i); }

        GetMinAndMaxFromArray.Get(array, out int min, out int max);

        Console.WriteLine($"\nmin = {min}, max = {max}");

        Again();
    }

    static void OnlyOddNumbersSelection()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("\nWe will get only the odd numbers from this list: ");
        foreach (int i in nums) { Console.Write("{0} ", i); }
        Console.Write("\n");

        List<int> list = OnlyOddNumbers.Get(nums);

        foreach (int i in list) { Console.WriteLine("{0} ", i); }
        Console.Write("\n");

        Again();
    }

    static void AnagramSelection()
    {
        Console.Write("\nEnter the first word: ");        
        string s1 = Console.ReadLine();

        Console.Write("\nEnter the second word: ");
        string s2 = Console.ReadLine();

        Console.Write("\nHow would you like to check? ");
        Console.Write("\n1. Comparing dictionaries ");
        Console.Write("\n2. Comparing sorts\n\n");
        string howToCheck = Console.ReadLine();

        int choice;

        if (Int32.TryParse(howToCheck, out choice))
        {
            switch (choice)
            {
                case 1:
                    if (Anagram.CheckAnagramWithDicts(s1, s2)) Console.WriteLine("\nYes, they are anagrams");
                    else Console.WriteLine("\nNo, they are not anagrams");
                    break;
                case 2:
                    if (Anagram.CheckAnagramWithSort(s1, s2)) Console.WriteLine("\nYes, they are anagrams");
                    else Console.WriteLine("\nNo, they are not anagrams");
                    break;
                default:
                    Console.WriteLine("\nPlease enter a valid selection");
                    break;
            }
        }
        else
        {
            Invalid();
        }
        Again();

    }

    static void FirstAndLastSelection()
    {
        int target;

        // Generating a random array
        int[] array = RandomIntArray();        

        Console.WriteLine("\nConsider the following array:");
        foreach (int i in array) { Console.WriteLine("{0} ", i); }

        Console.WriteLine("\nEnter any number that you see more than once: ");

        string t = Console.ReadLine();

        if (Int32.TryParse(t, out target))
        {
            Array.Sort(array);
            int[] indexes = FirstAndLastPosition.Get(array, target);
            Console.WriteLine("\nThe indexes are: ");
            foreach (int i in indexes) { Console.WriteLine("{0} ", i); }
            Console.WriteLine("\nThe sorted array is: ");
            foreach (int i in array) { Console.WriteLine("{0} ", i); }
            Again();
        }
        else Invalid();
    }

    static int[] RandomIntArray()
    {
        int Min = 0;
        int Max = 9;

        int[] array = new int[10];
        Random random = new Random();
       
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(Min, Max);
        }

        return array;
    }

    #region HouseKeeping
    static void Invalid()
    {
        Console.WriteLine("\nPlease enter a number representing your selection.\n");
        Main();
    }

    static void Again()
    {
        Console.WriteLine("\nDo you want to go again? [Y/N]\n");
        string input = Console.ReadLine();

        switch (input.ToUpper())
        {
            case "Y":
                Main();
                break;
            case "N":
                Environment.Exit(0);
                break;
            default:
                Invalid();
                break;
        }
    }
    #endregion
}