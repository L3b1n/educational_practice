namespace Strings
{
    public static class StringLiterals
    {
        public static string ReturnAbcStringLiteral()
        {
            return "abc";
        }

        public static string ReturnAbcdefStringLiteral()
        {
            return "ABCDEF";
        }

        public static string ReturnEmptyString()
        {
            return string.Empty;
        }

        public static string ReturnFilePathStringLiteral()
        {
            return "c:\\documents\\files\\myfile0234.txt";
        }

        public static string ReturnFilePathVerbatimStringLiteral()
        {
            return @"c:\documents\files\myfile0234.txt";
        }
    }
}
