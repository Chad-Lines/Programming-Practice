namespace Practice;

internal class GetMinAndMaxFromArray
{
    public static void Get(int[] array, out int min, out int max)
    {
        min = array.Min();
        max = array.Max();
    }
}
