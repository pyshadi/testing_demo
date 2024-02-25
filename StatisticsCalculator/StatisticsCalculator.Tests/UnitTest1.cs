namespace StatisticsCalculator.Tests
{
    [TestClass]
    public class StatisticsTests
    {
        [TestMethod]
        public void MeanTest()
        {
            // Arrange
            var calculator = new Statistics();
            var numbers = new List<double> { 1, 2, 3 };

            // Act
            var result = calculator.Mean(numbers);

            // Assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void VarTest()
        {
            // Arrange
            var calculator = new Statistics();
            var numbers = new List<double> { 1, 2, 3, 4 };

            // Act
            var result = calculator.Variance(numbers);

            // Assert
            Assert.AreEqual(1.25, result);
        }
        [TestMethod]
        public void StdTest()
        {
            // Arrange
            var calculator = new Statistics();
            var numbers = new List<double> { 1, 2, 3, 4 };

            // Act
            var result = calculator.StandardDeviation(numbers);

            // Assert
            Assert.AreEqual(1.118033988749895, result);
        }
    }
}