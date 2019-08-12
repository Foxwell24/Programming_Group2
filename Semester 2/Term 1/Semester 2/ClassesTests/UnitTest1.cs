using NUnit.Framework;
using Classes;

namespace Tests
{
    [TestFixture]
    public class ClassesTests
    {
        Student student;
        Staff staff;

       [SetUp]
        public void Setup()
        {
            staff = new Staff("Joe", "Bobb", 2000, 1938763);
            student = new Student("Derp", "Derp", 2000, "Herp");
        }

        [Test]
        public void GetAgeTest()
        {
            int expected = 19;
            Assert.AreEqual(expected, student.GetAge());
        }
    }
}