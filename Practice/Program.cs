using System.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();

            int choice;

            Console.WriteLine("\nWhat do you want to do? Enter the corresponding number:\n");
            Console.WriteLine("1. Perform a Binary Search");
            Console.WriteLine("2. Perform a Quick Sort");
            Console.WriteLine("3. Find Repeated Character in String");
            Console.WriteLine("4. Find the Min and Max in an Array");

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
}