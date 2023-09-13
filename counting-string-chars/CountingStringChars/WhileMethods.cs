using System;

namespace CountingStringChars
{
    public static class WhileMethods
    {
        public static int GetSpaceCount(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int result = 0;
            int index = 0;
            while (index < str.Length)
            {
                int argument = char.IsWhiteSpace(str[index]) ? 1 : 0;
                result += argument;
                index++;
            }

            return result;
        }

        public static int GetPunctuationCount(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int result = 0;
            int index = 0;
            while (index < str.Length)
            {
                bool isPunctuation = char.IsPunctuation(str[index]);
                int currentIncrement = isPunctuation ? 1 : 0;
                result += currentIncrement;
                index++;
            }

            return result;
        }

        public static int GetSpaceCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int result = GetSpaceCountRecursive(str[1..]) + (char.IsWhiteSpace(str[0]) ? 1 : 0);

            return result;
        }

        public static int GetPunctuationCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            bool isPunctuation = char.IsPunctuation(str[0]);
            int currentIncrement = isPunctuation ? 1 : 0;
            int result = GetPunctuationCountRecursive(str[1..]) + currentIncrement;

            return result;
        }
    }
}
