using NUnit.Framework;
using CIV_UnitTesting_Exercises;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        RecursiveCalculations recursiveCalculations;
        [SetUp]
        public void Setup()
        {
            recursiveCalculations = new RecursiveCalculations();
        }

        [Test]
        public void FibCheckTest()
        {
            Assert.AreEqual(true, recursiveCalculations.FibCheck(8));
        }

        [Test]
        public void FibRecTest()
        {
            Assert.AreEqual(3, recursiveCalculations.FibocacciRec(1, 1, 4));
        }
    }
}