
namespace Strings
{
    public static class UsingIndexerForAccessingStringChar
    {
        public static char GetFirstChar(string str)
        {
            return str[0];
        }

        public static char GetSecondChar(string str)
        {
            return str[1];
        }

        public static char GetThirdChar(string str)
        {
           return str[2];
        }

        public static char GetLastChar(string str)
        {
           return str.Last();
        }

        public static char GetNextToLastChar(string str)
        {
            return str[^2];
        }

        public static char GetThirdCharFromEnd(string str)
        {
            return str[^3];
        }

        public static char GetNthChar(string str, int n)
        {
            return str[n - 1];
        }

        public static char GetNthCharFromEnd(string str, int n)
        {
            return str[^n];
        }

        public static char GetLastCharUsingLength(string str)
        {
            return str[str.Length - 1];
        }

        public static char GetNextToLastCharUsingLength(string str)
        {
            return str[str.Length - 2];
        }

        public static char GetFifthCharFromEndUsingLength(string str)
        {
            return str[str.Length - 5];
        }

        public static char GetNthCharFromEndUsingLength(string str, int n)
        {
            return str[str.Length - n];
        }

        public static void GetSpecialCodes(string serialNumber, out char expectedCode1, out char expectedCode2, out char expectedCode3)
        {
            expectedCode1 = serialNumber[1];
            expectedCode2 = serialNumber[1];
            expectedCode3 = serialNumber[1];

            for (int i = 0; i < serialNumber.Length; i++)
            {
                if (serialNumber[i] == 'M')
                {
                    expectedCode2 = serialNumber[i - 1];
                    expectedCode3 = serialNumber[i + 3];
                    break;
                }
            }
        }
    }
}
