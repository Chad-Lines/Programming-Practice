namespace Practice;

public class Anagram
{
    public static bool CheckAnagramWithDicts(string s1, string s2)
    {        
        if (s1.Length != s2.Length) return false;       // If the strings are not the same length, they will not be anagrams

        Dictionary<char, int> freq1 = new();            // The dictionary for the first string
        Dictionary<char, int> freq2 = new();            // the dictionary for the second string

        foreach (char c in s1)                          // Loop through each character of the first string...
        {
            if (freq1.ContainsKey(c)) freq1[c]++;       // If c is already in the dict, then add one to it
            else freq1[c] = 1;                          // If it is not, then add it
        }

        foreach(char c in s2)                           // Repeating the above process for the second string
        {
            if (freq2.ContainsKey(c)) freq2[c]++;   
            else freq2[c] = 1;                      
        }

        foreach (KeyValuePair<char, int> kvp in freq1)  // For each key-value pair in freq1...
        {
            if (!freq2.ContainsKey(kvp.Key) ||          // If the key (char) doesn't have a match in freq2, or...
                freq1[kvp.Key] != freq1[kvp.Key])       // If the value (count) isn't the same... 
                return false;                           // Then return false
            else continue;                              // Otherwise continuet to the next key-value pair
        }
        return true;                                    // If it never returns false, then return true
    }

    public static bool CheckAnagramWithSort(string s1, string s2)
    {
        char[] c1 = new char[s1.Length];                            // Create a char array to hold s1
        char[] c2 = new char[s2.Length];                            // Create a char array to hold s2

        for (int i = 0; i < s1.Length; i++) c1[i] = (char)s1[i];    // Add the chars in the s1 to the array
        for (int i = 0; i < s2.Length; i++) c2[i] = (char)s2[i];    // Add the chars in the s2 to the array

        Array.Sort(c1);                                             // Sort array c1
        Array.Sort(c2);                                             // Sort array c2

        if (c1.SequenceEqual(c2)) return true;                      // If c1 and c2 are equal, then return true
        else return false;                                          // If they are not equal, return false
    }
}
