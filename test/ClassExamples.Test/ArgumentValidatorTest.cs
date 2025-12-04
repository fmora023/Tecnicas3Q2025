using ClassExamples;
using Moq;

namespace ClassExamples.Test
{
    /// <summary>
    /// Test for <see cref="ArgumentValidator"/>.
    /// </summary>
    [TestClass]
    public class ArgumentValidatorTest
    {
        /// <summary>
        /// Validates the correct parse string to int.
        /// </summary>
        [TestMethod]
        public void ValidateCorrectParseStringToInt()
        {
            // Arrange
            var input = "1";

            // Act
            var result = input.ParseStringToInt();

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
