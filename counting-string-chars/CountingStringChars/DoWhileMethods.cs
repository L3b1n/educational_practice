using System;

namespace CountingStringChars
{
    public static class DoWhileMethods
    {
        public static int GetDigitCount(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int count = 0;
            int index = 0;
            do
            {
                bool isDigit = char.IsDigit(str[index]);
                int currentIncrement = isDigit ? 1 : 0;
                count += currentIncrement;
                ++index;
            } while (index <= (str.Length - 1));

            return count;
        }

        public static int GetLetterCount(string? str)
        {

            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int count = 0;
            int index = 0;
            do
            {
                bool isLetter = char.IsLetter(str[index]);
                int currentIncrement = isLetter ? 1 : 0;
                count += currentIncrement;
                ++index;
            } while (index <= (str.Length - 2));

            return count;
        }

        public static int GetDigitCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetDigitCountRecursive(str, str.Length, 0);
        }

        public static int GetLetterCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetLetterCountRecursive(str, str.Length, 0);
        }

        private static int GetDigitCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetDigitCountRecursive(str, charsLeft - 1, char.IsDigit(str[^charsLeft]) ? counter + 1 : counter);
            }

            return counter;
        }

        private static int GetLetterCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetLetterCountRecursive(str, charsLeft - 1, char.IsLetter(str[^charsLeft]) ? counter + 1 : counter);
            }

            return counter;
        }
    }
}
