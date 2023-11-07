using System;

namespace Strings
{
    public static class UsingRanges
    {
        public static string GetStringWithAllChars(string str)
        {
            return str[..];
        }

        public static string GetStringWithoutFirstChar(string str)
        {
            return str[1..];
        }

        /// <summary>
        /// Gets a string without two first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoFirstChars(string str)
        {
            return str[2..];
        }

        public static string GetStringWithoutThreeFirstChars(string str)
        {
            return str[3..];
        }

        public static string GetStringWithoutLastChar(string str)
        {
            return str[..^1];
        }

        public static string GetStringWithoutTwoLastChars(string str)
        {
            return str[..^2];
        }

        public static string GetStringWithoutThreeLastChars(string str)
        {
            return str[..^3];
        }

        public static string GetStringWithoutFirstAndLastChars(string str)
        {
            return str[1..^1];
        }

        public static string GetStringWithoutTwoFirstAndTwoLastChars(string str)
        {
            return str[2..^2];
        }

        public static string GetStringWithoutThreeFirstAndThreeLastChars(string str)
        {
            return str[3..^3];
        }

        public static void GetProductionCodeDetails(string productionCode, out string regionCode, out string locationCode, out string dateCode, out string factoryCode)
        {
            regionCode = productionCode[0..^15];
            locationCode = productionCode[3..^11];
            dateCode = productionCode[7..^6];
            factoryCode = productionCode[12..];
        }

        public static void GetSerialNumberDetails(string serialNumber, out string countryCode, out string manufacturerCode, out string factoryCode, out string stationCode)
        {
            countryCode = serialNumber[(serialNumber.Length - 9) ..^8];
            manufacturerCode = serialNumber[(serialNumber.Length - 8) ..^6];
            factoryCode = serialNumber[(serialNumber.Length - 5) ..^1];
            stationCode = serialNumber[(serialNumber.Length - 1) ..];
        }
    }
}
