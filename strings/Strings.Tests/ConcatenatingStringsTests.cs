using System.Globalization;
using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace Strings.Tests
{
    [TestFixture]
    public sealed class ConcatenatingStringsTests
    {
        private static readonly object[][] ConcatenateStringsData =
        {
            new object[]
            {
                new[] { string.Empty },
                string.Empty,
            },
            new object[]
            {
                new[] { string.Empty, string.Empty },
                string.Empty,
            },
            new object[]
            {
                new[] { string.Empty, string.Empty, string.Empty },
                string.Empty,
            },
            new object[]
            {
                new[] { "a" },
                "a",
            },
            new object[]
            {
                new[] { "a", "b" },
                "ab",
            },
            new object[]
            {
                new[] { "a", "b", "c" },
                "abc",
            },
            new object[]
            {
                new[] { "abc" },
                "abc",
            },
            new object[]
            {
                new[] { "abc", "bcd" },
                "abcbcd",
            },
            new object[]
            {
                new[] { "abc", "bcd", "cde" },
                "abcbcdcde",
            },
            new object[]
            {
                new[] { "abc", "bcd", "cde", "def" },
                "abcbcdcdedef",
            },
        };

        private static readonly object[][] ConcatenateValuesData =
        {
            new object[]
            {
                new object[] { 1 },
                "1",
            },
            new object[]
            {
                new object[] { 1, true, 1.1, false, 1.1f },
                "1True1.1False1.1",
            },
        };

        [TestCase("", "", ExpectedResult = "")]
        [TestCase("a", "b", ExpectedResult = "ab")]
        [TestCase("abc", "bcd", ExpectedResult = "abcbcd")]
        public string ConcatenateStrings_TwoParameters_ParametersAreValid_ReturnsResult(string str0, string str1)
        {
            // Act
            return ConcatenatingStrings.ConcatenateStrings(str0, str1);
        }

        [TestCase("", "", "", ExpectedResult = "")]
        [TestCase("a", "b", "c", ExpectedResult = "abc")]
        [TestCase("abc", "bcd", "cde", ExpectedResult = "abcbcdcde")]
        public string ConcatenateStrings_ThreeParameters_ParametersAreValid_ReturnsResult(string str0, string str1, string str2)
        {
            // Act
            return ConcatenatingStrings.ConcatenateStrings(str0, str1, str2);
        }

        [TestCase("", "", "", "", ExpectedResult = "")]
        [TestCase("a", "b", "c", "d", ExpectedResult = "abcd")]
        [TestCase("abc", "bcd", "cde", "def", ExpectedResult = "abcbcdcdedef")]
        public string ConcatenateStrings_ThreeParameters_ParametersAreValid_ReturnsResult(string str0, string str1, string str2, string str3)
        {
            // Act
            return ConcatenatingStrings.ConcatenateStrings(str0, str1, str2, str3);
        }

        [TestCaseSource(nameof(ConcatenateStringsData))]
        public void ConcatenateStrings_Enumerable_ParametersAreValid_ReturnsResult(object[] data)
        {
            // Arrange
            IEnumerable<string> strings = (IEnumerable<string>)data[0];
            string expectedResult = (string)data[1];

            // Act
            string actualResult = ConcatenatingStrings.ConcatenateStrings(strings);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("", 1, 1L, ExpectedResult = "11")]
        [TestCase("abc", int.MaxValue, long.MaxValue, ExpectedResult = "abc21474836479223372036854775807")]
        [TestCase("abc", int.MinValue, long.MinValue, ExpectedResult = "abc-2147483648-9223372036854775808")]
        public string ConcatenateValues_ThreeParameters_ReturnsResult(string str, int intValue, long longValue)
        {
            // Arrange
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            // Act
            string actualResult = ConcatenatingStrings.ConcatenateValues(str, intValue, longValue);

            // Tear down
            CultureInfo.CurrentCulture = currentCulture;

            // Assert
            return actualResult;
        }

        [TestCase(1, 1f, true, 1.1, ExpectedResult = "11True1.1")]
        [TestCase(short.MaxValue, float.MaxValue, false, double.MaxValue, ExpectedResult = "327673.4028235E+38False1.7976931348623157E+308")]
        [TestCase(short.MinValue, float.MinValue, true, double.MinValue, ExpectedResult = "-32768-3.4028235E+38True-1.7976931348623157E+308")]
        public string ConcatenateValues_FourParameters_ReturnsResult(short shortValue, float floatValue, bool boolValue, double doubleValue)
        {
            // Arrange
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            // Act
            string actualResult = ConcatenatingStrings.ConcatenateValues(shortValue, floatValue, boolValue, doubleValue);

            // Tear down
            CultureInfo.CurrentCulture = currentCulture;

            return actualResult;
        }

        [TestCaseSource(nameof(ConcatenateValuesData))]
        public void ConcatenateValues_Enumerable_ParametersAreValid_ReturnsResult(object[] data)
        {
            // Arrange
            IEnumerable<object> values = (IEnumerable<object>)data[0];
            string expectedResult = (string)data[1];

            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            // Act
            string actualResult = ConcatenatingStrings.ConcatenateValues(values);

            // Tear down
            CultureInfo.CurrentCulture = currentCulture;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
