using System.Text;

namespace ClassExampleConsole
{
    /// <summary>
    /// Class containing console examples.
    /// </summary>
    public static class ClassConsoleExamples
    {
        /// <summary>
        /// Sums the of elements.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>the sum of the elements in the list</returns>
        public static int SumOfElements(List<int> input)
        {
            if (input == null || input.Count == 0)
            {
                return 0;
            }

            var result = 0;
            foreach (var item in input)
            {
                result += item;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified input is palindrome.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            for (var i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Reverts the string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string RevertString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            var result = new StringBuilder();
            for (var i = 0; i < input.Length; i++)
            {
                result.Insert(0, input[i]);
            }

            return result.ToString();
        }

        /// <summary>
        /// Gets the maximum minimum.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Input list cannot be null or empty.</exception>
        public static (int min, int max) GetMaxMin(List<int> input)
        {
            if (input == null || input.Count == 0)
            {
                throw new ArgumentException("Input list cannot be null or empty.");
            }

            var min = input[0];
            var max = input[0];

            for (var i = 1; i < input.Count; i++)
            {
                if (input[i] < min)
                {
                    min = input[i];
                }
                if (input[i] > max)
                {
                    max = input[i];
                }
            }

            return (min, max);
        }

        /// <summary>
        /// Gets the maximum minimum.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <exception cref="System.ArgumentException">Input list cannot be null or empty.</exception>
        public static void GetMaxMin(List<int> input, out int min, out int max)
        {
            if (input == null || input.Count == 0)
            {
                throw new ArgumentException("Input list cannot be null or empty.");
            }

            min = input[0];
            max = input[0];

            for (var i = 1; i < input.Count; i++)
            {
                if (input[i] < min)
                {
                    min = input[i];
                }
                if (input[i] > max)
                {
                    max = input[i];
                }
            }
        }

        /// <summary>
        /// Gets the index of character.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="character">The character.</param>
        /// <returns></returns>
        public static int GetIndexOfChar(string input, char character)
        {
            if (string.IsNullOrEmpty(input))
            {
                return -1;
            }
            
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == character)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Gets all indexes of character.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="character">The character.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Input string cannot be null or empty.</exception>
        public static List<int> GetAllIndexesOfChar(string input, char character)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }

            var result = new List<int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == character)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
