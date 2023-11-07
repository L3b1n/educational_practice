using System;

namespace Strings
{
    public static class JoiningStrings
    {
        public static string GetCommaSeparatedString(string[] values)
        {
            return string.Join(',', values);
        }

        public static string GetColonSeparatedString(string[] values)
        {
            return string.Join(':', values);
        }

        public static string GetCommaSeparatedStringWithoutFirstElement(string[] values)
        {
            int index = values.Length - 1;
            return string.Join(',', values, 1, index);
        }

        public static string GetHyphenSeparatedStringWithoutFirstAndLastElements(string[] values)
        {
            int index = values.Length - 2;
            return string.Join('-', values, 1, index);
        }

        public static string GetPlusSeparatedString(IEnumerable<string> values)
        {
            return string.Join('+', values);
        }

        public static string GetBackslashSeparatedString(IEnumerable<object> values)
        {
            return string.Join('\\', values);
        }

        public static string GetStringSeparatedString(object[] values)
        {
            string separator = (string)values[1];
            return string.Join(separator, values);
        }

        public static string GetStringSeparatedStringForLastThreeElements(string separator, string[] values)
        {
            // TODO #6-7. Analyze unit tests for the method, and add the method implementation.
            // Use String.Join method: https://docs.microsoft.com/en-us/dotnet/api/system.string.join
            throw new NotImplementedException();
        }
    }
}
