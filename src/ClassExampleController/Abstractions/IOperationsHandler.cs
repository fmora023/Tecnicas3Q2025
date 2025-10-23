namespace ClassExampleController.Abstractions
{
    /// <summary>
    /// Interfaz para el manejo de operaciones de calculo.
    /// </summary>
    public interface IOperationsHandler
    {
        /// <summary>
        /// Executes the operation.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <param name="operation">The operation.</param>
        /// <returns>The result of the operation provided.</returns>
        int ExecuteOperation(int input1, int input2, Operations operation);
    }
}
