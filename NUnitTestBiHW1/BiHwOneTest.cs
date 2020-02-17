using NUnit.Framework;
using BiHW1;

namespace Tests
{
    public class BiHwOneTest
    {
        [SetUp]
        public void Setup()
        {
        }

        // Add test methods
        [Test]
        public void AddMethodTest()
        {
            // Arrange
            var biHwOne = new BiHwOne(1, 4, 5);

            // Assert
            // Check with assert methods of two numbers
            // First give us true
            Assert.AreEqual(5, biHwOne.Add());

            // Second Give us false
            Assert.AreEqual(7, biHwOne.Add());
        }

        [Test]
        public void GetSumTotalOfArrayTest()
        {
            // Arrange
            var biHwOne = new BiHwOne(1, 4, 5);

            // Assert
            // Check with if sum of array total
            // First give us true
            Assert.AreEqual(0, biHwOne.GetSumTotalOfArray());

            // Second Give us false
            Assert.AreEqual(7, biHwOne.GetSumTotalOfArray());
        }

        [Test]
        public void GetSumOfTotalArrayList()
        {
            // Arrange
            var biHwOne = new BiHwOne(1, 4, 5);

            // Assert
            // Check with if sum of ArrayList total
            // First give us true
            Assert.AreEqual(55, biHwOne.GetSumOfTotalArrayList());

            // Second Give us false
            Assert.AreEqual(7, biHwOne.GetSumOfTotalArrayList());
        }
    }
}