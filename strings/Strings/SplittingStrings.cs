using System;

namespace Strings
{
    public static class SplittingStrings
    {
        public static string[] SplitCommaSeparatedString(string str)
        {
            return str.Split(',');
        }

        public static string[] SplitColonSeparatedString(string str)
        {
            return str.Split(':');
        }

        public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
        {
            return str.Split(',', 2);
        }

        public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
        {
            return str.Split(':', 3);
        }

        public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
        {
            return str.Split('-', 3, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
        {
            char[] separators = new char[] { ',', ':' };
            return str.Split(separators, 4, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] GetOnlyWords(string str)
        {
            char[] separators = new char[] { ',', ' ', '.', '!', '?', '\t', ':', ';', '-' };
            return str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] GetDataFromCsvLine(string str)
        {
            char[] separators = new char[] { ',', ' ' };
            return str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
