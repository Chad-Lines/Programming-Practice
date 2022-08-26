using Practice;

namespace PracticeTests;

[TestClass]
public class PracticeTests
{
    #region Variables

    // Anagram variables
    private string[] trueStrings = { "danger", "garden" };
    private string[] falseStrings = { "alpha", "omega" };

    // Binary Search variables
    private int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private int target = 5;
    private int index = 4;

    // Repeating Characters variables
    private string repeats = "test";
    private string repeatingChar = "t";
    private string noRepeats = "desk";
    private string noRepeatChar = "-1";

    // Get Min and Max from Array variables
    private int[] minMaxArray = { 5, 7, 1, 4, 2, 8, 4, 8, 1, 3, 5 };
    private int min = 1;
    private int max = 8;

    // Only Odd Numbers Variables
    private int[] onlyOddNumsInput = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private int[] onlyOddNumsExpected = { 1, 3, 5, 7, 9 };

    // First And Last Variables
    private int[] firstAndLastArray = { 1, 2, 2, 3, 5, 5, 5, 6, 9, 8, 7 };
    private int firstAndLastTarget = 5;
    private int expectedFirstIdx = 4;
    private int expectedLastIdx = 6;

    #endregion

    #region Anagram Tests
    /// <summary>
    /// Testing the anagram class CheckAnagramWithDicts method
    /// </summary>
    [TestMethod]
    public void CheckDicts()
    {
        Assert.IsTrue(Anagram.CheckAnagramWithDicts(trueStrings[0], trueStrings[1]));       // Check true anagrams
        Assert.IsFalse(Anagram.CheckAnagramWithDicts(falseStrings[0], falseStrings[1]));    // Check false anagrams
    }
    /// <summary>
    /// Testing the anagram class CheckAnagramWithSort method
    /// </summary>
    [TestMethod]
    public void CheckSorts()
    {
        Assert.IsTrue(Anagram.CheckAnagramWithSort(trueStrings[0], trueStrings[1]));       // Check true anagrams
        Assert.IsFalse(Anagram.CheckAnagramWithSort(falseStrings[0], falseStrings[1]));    // Check false anagrams
    }
    #endregion

    #region BinarySearch Test
    /// <summary>
    /// Testing the BinarySearch class
    /// </summary>
    [TestMethod]
    // Check that the index returned by BinarySearch matches our expected index
    public void TestBinarySearch() => Assert.AreEqual(BinarySearch.Search(nums, target), index);

    #endregion

    #region TODO: QUICKSORT
    #endregion

    #region Repeat Characters Test

    /// <summary>
    /// Testing RepeatCharacters with a string that has repeating characters
    /// </summary>
    [TestMethod]
    public void TestRepeatCharactersTrue() => Assert.AreEqual(RepeatCharacters.FindRepeat(repeats), repeatingChar);

    /// <summary>
    /// Testing RepeatCharacters with a string that does not have repeating characters
    /// </summary>
    [TestMethod]
    public void TestRepeatCharactersFalse() => Assert.AreEqual(RepeatCharacters.FindRepeat(noRepeats), noRepeatChar);

    #endregion

    #region Get Min And Max From Array Test

    /// <summary>
    /// Testing the GetMinAndMaxFromArray class
    /// </summary>
    [TestMethod]
    public void TestMinAndMaxFromArray()
    {
        GetMinAndMaxFromArray.Get(minMaxArray, out int _min, out int _max); // Running the method on the array
        Assert.AreEqual(min, _min);                                         // Comparing expected and actual min
        Assert.AreEqual(max, _max);                                         // Comparing expected and actual max
    }

    #endregion

    #region Only Odd Numbers Test

    [TestMethod]
    public void OnlyOddNumbersTest()
    {
        CollectionAssert.AreEqual(onlyOddNumsExpected, OnlyOddNumbers.Get(onlyOddNumsInput));
        //Assert.AreEqual(onlyOddNumsExpected, OnlyOddNumbers.Get(onlyOddNumsInput));
    }

    #endregion

    #region First And Last Test
    [TestMethod]
    public void FirstAndLastTest()
    {
        int[] indexes = FirstAndLastPosition.Get(firstAndLastArray, firstAndLastTarget);

        Assert.AreEqual(indexes[0], expectedFirstIdx);
        Assert.AreEqual(indexes[1], expectedLastIdx);
    }

    #endregion
}