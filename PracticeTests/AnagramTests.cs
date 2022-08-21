using Practice;

namespace PracticeTests;

[TestClass]
public class AnagramTests
{
    private string[] trueStrings = { "danger", "garden" };
    private string[] falseStrings = { "alpha", "omega" };

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
}