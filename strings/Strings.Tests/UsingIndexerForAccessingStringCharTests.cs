using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace Strings.Tests
{
    [TestFixture]
    public sealed class UsingIndexerForAccessingStringCharTests
    {
        [TestCase("Abcdefghijk", ExpectedResult = 'A')]
        [TestCase("0123456789", ExpectedResult = '0')]
        public char GetFirstChar_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetFirstChar(str);
        }

        [TestCase("aBcdefghijk", ExpectedResult = 'B')]
        [TestCase("0123456789", ExpectedResult = '1')]
        public char GetSecondChar_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetSecondChar(str);
        }

        [TestCase("abCdefghijk", ExpectedResult = 'C')]
        [TestCase("0123456789", ExpectedResult = '2')]
        public char GetThirdChar_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetThirdChar(str);
        }

        [TestCase("abCdefghijK", ExpectedResult = 'K')]
        [TestCase("0123456789", ExpectedResult = '9')]
        public char GetLastChar_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetLastChar(str);
        }

        [TestCase("abcdefghiJk", ExpectedResult = 'J')]
        [TestCase("0123456789", ExpectedResult = '8')]
        public char GetNextToLastChar_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetNextToLastChar(str);
        }

        [TestCase("abcdefghIjk", ExpectedResult = 'I')]
        [TestCase("0123456789", ExpectedResult = '7')]
        public char GetThirdCharFromEnd_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetThirdCharFromEnd(str);
        }

        [TestCase("Abcdefghijk", 1, ExpectedResult = 'A')]
        [TestCase("0123456789", 2, ExpectedResult = '1')]
        [TestCase("abCdefghijk", 3, ExpectedResult = 'C')]
        [TestCase("0123456789", 4, ExpectedResult = '3')]
        public char GetNthChar_ParameterIsValid_ReturnsResult(string str, int n)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetNthChar(str, n);
        }

        [TestCase("abcdefghijK", 1, ExpectedResult = 'K')]
        [TestCase("0123456789", 2, ExpectedResult = '8')]
        [TestCase("abCdefghIjk", 3, ExpectedResult = 'I')]
        [TestCase("0123456789", 4, ExpectedResult = '6')]
        public char GetNthCharFromEnd_ParameterIsValid_ReturnsResult(string str, int n)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetNthCharFromEnd(str, n);
        }

        [TestCase("abCdefghijK", ExpectedResult = 'K')]
        [TestCase("0123456789", ExpectedResult = '9')]
        public char GetLastCharUsingLength_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetLastCharUsingLength(str);
        }

        [TestCase("abcdefghiJk", ExpectedResult = 'J')]
        [TestCase("0123456789", ExpectedResult = '8')]
        public char GetNextToLastCharUsingLength_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetNextToLastCharUsingLength(str);
        }

        [TestCase("abcdefGhijk", ExpectedResult = 'G')]
        [TestCase("0123456789", ExpectedResult = '5')]
        public char GetFifthCharFromEndUsingLength_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetFifthCharFromEndUsingLength(str);
        }

        [TestCase("abcdefghijK", 1, ExpectedResult = 'K')]
        [TestCase("0123456789", 2, ExpectedResult = '8')]
        [TestCase("abCdefghIjk", 3, ExpectedResult = 'I')]
        [TestCase("0123456789", 4, ExpectedResult = '6')]
        public char GetNthCharFromEndUsingLength_ParameterIsValid_ReturnsResult(string str, int n)
        {
            // Act
            return UsingIndexerForAccessingStringChar.GetNthCharFromEndUsingLength(str, n);
        }

        [TestCase("07K4M1DZ-BZ", '7', '4', 'Z')]
        [TestCase("19K06M1DI-AZ", '9', '6', 'I')]
        [TestCase("31K008M1DJ-KZ", '1', '8', 'J')]
        public void GetSpecialCodes(string serialNumber, char expectedCode1, char expectedCode2, char expectedCode3)
        {
            // Act
            UsingIndexerForAccessingStringChar.GetSpecialCodes(serialNumber, out char code1, out char code2, out char code3);

            // Assert
            Assert.AreEqual(expectedCode1, code1);
            Assert.AreEqual(expectedCode2, code2);
            Assert.AreEqual(expectedCode3, code3);
        }
    }
}
