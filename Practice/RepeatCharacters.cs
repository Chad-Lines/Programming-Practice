namespace Practice;

internal class RepeatCharacters
{
    public static char FindRepeat(string str)
    {
        int notFound = -1;                                  // If a repeating character is not found, return -1

        string s = str.ToLower();                           // Lowercase the whole string to normalize

        for (int i = 0; i < s.Length; i++)                  // Get the first index
        {
            for (int j = i + 1; j < s.Length; j++)          // Get the second index (while excluding the first)
            {
                if (s[i] == s[j]) return s[i];              // Compare the first to the second
            }   
        }
        return (char)notFound;                              // Return the not found variable
    }
}
