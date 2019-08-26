using NUnit.Framework;
using Challenge1Practice;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        WordProcessing wordProcessing;
        [SetUp]
        public void Setup()
        {
            wordProcessing = new WordProcessing();
        }

        [TestCase("Bob", "BoB")]
        [TestCase("harry", "hArRy")]
        public void TestAlternateCase(string input, string ans)
        {
            Assert.AreEqual(ans, wordProcessing.AlternateCase(input));
        }

        [TestCase("abc", 3, "def")]
        [TestCase("abc", -2,  "yza")]
        [TestCase("ace", 5, "fgh")]
        public void TestShiftWord(string input, int input2, string ans)
        {
            Assert.AreEqual(ans, wordProcessing.ShiftWord(input, input2));
        }

        [TestCase("aaab", "a")]
        [TestCase("aabb", "a")]
        public void TestMostCommonLetter(string input, string ans)
        {
            Assert.AreEqual(ans, wordProcessing.MostCommonLetter(input));
        }

        [TestCase("abcde", 5)]
        [TestCase("aaaab", 2)]
        [TestCase("aaaaa", 1)]
        public void TestAmtOfDifferentChars(string input, int ans)
        {
            Assert.AreEqual(ans, wordProcessing.AmtOfDifferentChars(input));
        }

        [TestCase("abcab", "ab", 3)]
        [TestCase("abccab", "ab", 4)]
        public void TestfindPattern(string input, string input2, int ans)
        {
            Assert.AreEqual(ans, wordProcessing.findPattern(input, input2));
        }

        [TestCase("abccab" ,"bcaabc", "abc")]
        public void TestfindLongestPattern(string input, string input2, string ans)
        {
            Assert.AreEqual(ans, wordProcessing.findLongestPattern(input, input2));
        }
    }
}