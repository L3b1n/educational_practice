
using System;

namespace CountingStringChars
{
    public static class ForMethods
    {
        public static int GetCharCount(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int i = 0;
            for (i = 0; i < str.Length; i++);
            return i;
        }

        public static int GetUpperCharCount(string? str)
        {

            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                bool isUpper = char.IsUpper(str[i]);
                int currentIncrement = isUpper ? 1 : 0;
                sum += currentIncrement;
            }

            return sum;
        }

        public static int GetCharCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetCharCountRecursive(str, 0);
        }

        public static int GetUpperCharCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetUpperCharCountRecursive(str, 0);
        }

        private static int GetCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            return GetCharCountRecursive(str, index + 1) + 1;
        }

        private static int GetUpperCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            bool isUpper = char.IsUpper(str[index]);
            int currentIncrement = isUpper ? 1 : 0;

            return GetUpperCharCountRecursive(str, index + 1) + currentIncrement;
        }
    }
}
