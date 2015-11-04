namespace _04.LongestSubsequenceTests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;
    using _04.LongestSubsequence;

    [TestClass]
    public class LongestSubsequenceTests
    {
        [TestMethod]
        public void CheckIfReturnsEmptyIfListIsEmpty()
        {
            List<int> list = new List<int>();
            List<int> output = LongestSubsequence.FindLongestSubsequence(list);
            Assert.AreEqual(0, output.Count);
        }

        [TestMethod]
        public void CheckIfReturnsDigitIfListHasOneDigit()
        {
            List<int> list = new List<int>() { 1 };
            List<int> output = LongestSubsequence.FindLongestSubsequence(list);
            Assert.AreEqual(1, output.Count);
        }

        [TestMethod]
        public void CheckIfReturnsCorrectlyIfLongestIsAtBeginning()
        {
            List<int> list = new List<int>() { 1, 1, 1, 1, 9, 7, 5, 5, 5 };
            List<int> output = LongestSubsequence.FindLongestSubsequence(list);
            Assert.IsTrue(output.SequenceEqual(new List<int>() { 1, 1, 1, 1 }));
        }

        [TestMethod]
        public void CheckIfReturnsCorrectlyIfLongestIsAtEnd()
        {
            List<int> list = new List<int>() { 1, 1, 1, 1, 9, 7, 5, 5, 5, 5, 5 };
            List<int> output = LongestSubsequence.FindLongestSubsequence(list);
            Assert.IsTrue(output.SequenceEqual(new List<int>() { 5, 5, 5, 5, 5 }));
        }

        [TestMethod]
        public void CheckIfReturnsCorrectlyIfLongestIsInMid()
        {
            List<int> list = new List<int>() { 1, 1, 1, 9, 7, 7, 7, 7, 5, 5 };
            List<int> output = LongestSubsequence.FindLongestSubsequence(list);
            Assert.IsTrue(output.SequenceEqual(new List<int>() { 7, 7, 7, 7 }));
        }
    }
}
