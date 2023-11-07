using System;

namespace Strings
{
    public static class CreatingStrings
    {
        public static string ReturnNewString(string str)
        {
            return new string(str);
        }

        public static string ReturnStringWithRepeatedChars(char c, int count)
        {
            return new string(c, count);
        }

        public static string ReturnStringFromCharArray(char[] c)
        {
            return new string(c);
        }

        public static string ReturnStringFromCharArray(char[] c, int startIndex, int length)
        {
            return new string(c, startIndex, length);
        }
    }
}
