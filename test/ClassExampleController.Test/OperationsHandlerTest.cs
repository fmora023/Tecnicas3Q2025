namespace ClassExampleController.Test
{
    /// <summary>
    /// Test for <see cref="OperationsHandler"/>.
    /// </summary>
    [TestClass]
    public class OperationsHandlerTest
    {
        private OperationsHandler? OperationHandler { get; set; }

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            this.OperationHandler = new OperationsHandler();
        }

        /// <summary>
        /// Tests the cleanup.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            this.OperationHandler = null;
        }

        /// <summary>
        /// Tests the execute operation with add.
        /// </summary>
        [TestMethod]
        [DoNotParallelize]
        public void TestExecuteOperationWithAdd()
        {
            // Arrange
            var input1 = 5;
            var input2 = 10;

            // Act
            var result = this.OperationHandler!.ExecuteOperation(input1, input2, Operations.Add);

            // Assert
            Assert.AreEqual(15, result);
        }

        /// <summary>
        /// Tests the execute operation with mult operation.
        /// </summary>
        [TestMethod]
        [DoNotParallelize]
        public void TestExecuteOperationWithMultOperation()
        {
            // Arrange 
            var input1 = 5;
            var input2 = 10;

            // Act
            var result = this.OperationHandler!.ExecuteOperation(input1, input2, Operations.Mult);

            // Assert
            Assert.AreEqual(50, result);
        }

        /// <summary>
        /// Tests the execute operation with mult operation.
        /// </summary>
        [TestMethod]
        [DoNotParallelize]
        [DataRow(2, 3, 6)]
        [DataRow(5, 5, 25)]
        public void TestExecuteOperationWithMultOperationWithMultipleElements(int input1, int input2, int expected)
        {
            // Arrange

            // Act
            var result = this.OperationHandler!.ExecuteOperation(input1, input2, Operations.Mult);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the execute operation with unsupported operation attribute.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        [DoNotParallelize]
        public void TestExecuteOperationWithUnsupportedOperationAttribute()
        {
            // Arrange 
            var input1 = 5;
            var input2 = 10;
         
            // Act
            var result = this.OperationHandler!.ExecuteOperation(input1, input2, (Operations)999);

            // Assert
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Tests the execute operation with unsupported operation in code.
        /// </summary>
        [TestMethod]
        [DoNotParallelize]
        public void TestExecuteOperationWithUnsupportedOperationInCode()
        {
            // Arrange 
            var input1 = 5;
            var input2 = 10;
         
            // Act
            Assert.ThrowsException<NotSupportedException>(() => this.OperationHandler!.ExecuteOperation(input1, input2, Operations.Div));

            // Assert is handled by ExpectedException
        }
    }
}