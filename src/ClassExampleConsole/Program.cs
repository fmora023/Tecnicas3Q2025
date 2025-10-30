namespace ClassExampleConsole
{
    /// <summary>
    /// Entry point class for the console application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// 
        /// Execute this three exercises.
        /// 
        /// sum of elements in a list of integers
        /// ispalindrome
        /// revert a string
        /// 
        /// obtener el maximo y el minimo en una lista de enteros. [ 25, 22, 7, 15, 10 ] min => 7 , max => 25
        /// obtener el indice en un string. "Hello, World!" buscar la letra "o" => indice 4
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var list = new List<int>() { 25, 22, 7, 15, 10 };

            var sumResult = ClassConsoleExamples.SumOfElements(list);

            Console.WriteLine($"Sum of elements in the list: {sumResult}");

            var palindromeTest = "madam";
            var isPalindromeResult = ClassConsoleExamples.IsPalindrome(palindromeTest);

            Console.WriteLine($"Is the string '{palindromeTest}' a palindrome? {isPalindromeResult}");

            var revertTest = "Hello, World!";
            var revertResult = ClassConsoleExamples.RevertString(revertTest);

            Console.WriteLine($"Reverted string of '{revertTest}': {revertResult}");


            (var min, var max) = ClassConsoleExamples.GetMaxMin(list);
            Console.WriteLine($"In the list [{string.Join(", ", list)}], Min: {min}, Max: {max}");

            ClassConsoleExamples.GetMaxMin(list, out var min1, out var max1);
            Console.WriteLine($"In the list [{string.Join(", ", list)}], Min: {min1}, Max: {max1}");

            var searchString = "Hello, World!";
            var indexOfO = ClassConsoleExamples.GetIndexOfChar(searchString, 'o');
            Console.WriteLine($"In the string '{searchString}', the first index of 'o' is: {indexOfO}");

            var indexesOfO = ClassConsoleExamples.GetAllIndexesOfChar(searchString, 'o');
            Console.WriteLine($"In the string '{searchString}', all the indexes of 'o' are: {string.Join(", ", indexesOfO)}");

            Console.WriteLine("Successfully executed! Bye!");
        }
    }
}