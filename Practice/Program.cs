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
            Console.WriteLine("2. Quick Sort");

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
            foreach (int i in array) { Console.Write("{0}", i); }

            QuickSort.Sort(array, 0, array.Length - 1);

            Console.Write("\nViola! ");
            foreach (int i in array) { Console.Write("{0}", i); }
            Console.Write("\n");

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