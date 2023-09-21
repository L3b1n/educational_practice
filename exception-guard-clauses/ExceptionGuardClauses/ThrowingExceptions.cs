using System;
using System.Globalization;

namespace ExceptionGuardClauses
{
    public static class ThrowingExceptions
    {
        public static int ConvertHexCharToInteger(char c)
        {
            if (int.TryParse($"{c}", NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int result))
            {
                return result; 
            }

            throw new ArgumentException("c is not a hex char.", nameof(c));
        }

        public static char GetLastCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str[^1];
        }

        public static string GenerateUserCode(string code, int day)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (code.Length != 4)
            {
                throw new ArgumentException($"{nameof(code)} has {code.Length} chars.", nameof(code));
            }

            if (day <= 0 || day >= 100)
            {
                throw new ArgumentOutOfRangeException(nameof(day));
            }

            return code + day.ToString(CultureInfo.InvariantCulture);
        }

        public static string GenerateGreeting(string hello, string[] addressee, int index)
        {
            if (string.IsNullOrEmpty(hello))
            {
                throw new ArgumentNullException(nameof(hello));
            }

            if (addressee is null)
            {
                throw new ArgumentNullException(nameof(addressee));
            }

            if (addressee.Length == 0)
            {
                throw new ArgumentException($"array is empty", nameof(addressee));
            }

            if (index < 0 || index >= addressee.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return $"{hello}, {addressee[index]}!";
        }

        public static string GetArrayValue(int[] indexArray, int indexArrayPosition, string[] valueArray)
        {
            if (indexArray is null)
            {
                throw new ArgumentNullException(nameof(indexArray));
            }

            if (indexArray.Length == 0)
            {
                throw new ArgumentException($"array is empty", nameof(indexArray));
            }

            if (valueArray is null)
            {
                throw new ArgumentNullException(nameof(valueArray));
            }

            if (valueArray.Length == 0)
            {
                throw new ArgumentException($"array is empty", nameof(valueArray));
            }

            if (indexArrayPosition < 0 || indexArrayPosition >= indexArray.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(indexArrayPosition));
            }

            int position = indexArray[indexArrayPosition];

            return valueArray[position];
        }
    }
}
