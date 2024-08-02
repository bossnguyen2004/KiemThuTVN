namespace BaiBon
{
    public class Tests
    {
        public class Calculator
        {
            public double CalculateAverage(List<int> numbers)
            {
                if (numbers == null || numbers.Count == 0)
                {
                    throw new ArgumentException("Danh sách không được rỗng.");
                }
                return numbers.Average();
            }
        }
        [TestFixture]
        public class CalculatorTests
        {
            private Calculator _calculator;

            [SetUp]
            public void Setup()
            {
                _calculator = new Calculator();
            }

            [Test]
            public void CalculateAverage_ValidPositiveNumbers_ReturnsCorrectAverage()
            {
                // Arrange
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                // Act
                double result = _calculator.CalculateAverage(numbers);

                // Assert
                Assert.AreEqual(30, result);
            }

        }
    }
}