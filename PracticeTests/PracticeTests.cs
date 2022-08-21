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




}