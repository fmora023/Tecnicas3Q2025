using ClassExampleController.Abstractions;

namespace ClassExampleController
{
    /// <summary>
    /// Implementation of <see cref="IOperationsHandler"/>.
    /// </summary>
    /// <seealso cref="ClassExampleController.Abstractions.IOperationsHandler" />
    public class OperationsHandler : IOperationsHandler
    {
        /// <summary>
        /// Executes the operation based on <paramref name="operation"/>.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <param name="operation">The operation.</param>
        /// <returns>
        /// The result of the operation provided.
        /// </returns>
        public int ExecuteOperation(int input1, int input2, Operations operation)
        {
            if (operation.Equals(Operations.Add))
            {
                return Add(input1, input2);
            }

            return 0;
        }

        /// <summary>
        /// Adds the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>input1 plus input2 result.</returns>
        private static int Add(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
