using System;

namespace Strings
{
    public static class ConcatenatingStrings
    {
        public static string ConcatenateStrings(string str0, string str1)
        {
            return string.Concat(str0, str1);
        }

        public static string ConcatenateStrings(string str0, string str1, string str2)
        {
            return string.Concat(str0, str1, str2);
        }

        public static string ConcatenateStrings(string str0, string str1, string str2, string str3)
        {
            return string.Concat(str0, str1, str2, str3);
        }

        public static string ConcatenateStrings(IEnumerable<string> strings)
        {
            return string.Concat(strings);
        }

        public static string ConcatenateValues(string str, int intValue, long longValue)
        {
            return string.Concat(str, intValue, longValue);
        }

        public static string ConcatenateValues(short shortValue, float floatValue, bool boolValue, double doubleValue)
        {
            return string.Concat(shortValue, floatValue, boolValue, doubleValue);
        }

        public static string ConcatenateValues(IEnumerable<object> values)
        {
            return string.Concat<object>(values);
        }
    }
}
