using NUnit.Framework;

// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo
namespace Strings.Tests
{
    [TestFixture]
    public sealed class StringLiteralsTests
    {
        [Test]
        public void ReturnAbcStringLiteral()
        {
            // Act
            string actualResult = StringLiterals.ReturnAbcStringLiteral();

            // Assert
            Assert.AreEqual("abc", actualResult);
        }

        [Test]
        public void ReturnAbcdefStringLiteral()
        {
            // Act
            string actualResult = StringLiterals.ReturnAbcdefStringLiteral();

            // Assert
            Assert.AreEqual("ABCDEF", actualResult);
        }

        [Test]
        public void ReturnEmptyString()
        {
            // Act
            string result = StringLiterals.ReturnEmptyString();

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void ReturnFilePathStringLiteral()
        {
            // Act
            string actualResult = StringLiterals.ReturnFilePathStringLiteral();

            // Assert
            Assert.AreEqual("c:\\documents\\files\\myfile0234.txt", actualResult);
        }

        [Test]
        public void ReturnFilePathVerbatimStringLiteral()
        {
            // Act
            string actualResult = StringLiterals.ReturnFilePathVerbatimStringLiteral();

            // Assert
            Assert.AreEqual(@"c:\documents\files\myfile0234.txt", actualResult);
        }
    }
}
