using System.Linq;
using NUnit.Framework;

namespace WorkingWithArrays.Tests
{
    [TestFixture]
    public sealed class UsingIndexerForAccessingArrayElementTests
    {
        [Test]
        public void GetFirstArrayElement_ReturnsFirstElement([Values(1, 2, 20)] int arrayLength)
        {
            // Arrange
            int[] array = Enumerable.Range(1, arrayLength).ToArray();

            // Act
            int result = UsingIndexerForAccessingArrayElement.GetFirstArrayElement(array);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetSecondArrayElement_ReturnsSecondElement([Values(2, 3, 20)] int arrayLength)
        {
            // Arrange
            int[] array = Enumerable.Range(1, arrayLength).ToArray();

            // Act
            int result = UsingIndexerForAccessingArrayElement.GetSecondArrayElement(array);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void GetThirdArrayElement_ReturnsThirdElement([Values(3, 4, 20)] int arrayLength)
        {
            // Arrange
            int[] array = Enumerable.Range(1, arrayLength).ToArray();

            // Act
            int result = UsingIndexerForAccessingArrayElement.GetThirdArrayElement(array);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void GetLastElement_ReturnsLastElement([Values(1, 2, 20)] int arrayLength)
        {
            // Arrange
            int[] array = Enumerable.Range(1, arrayLength).ToArray();

            // Act
            int result = UsingIndexerForAccessingArrayElement.GetLastElement(array);

            // Assert
            Assert.AreEqual(array[array.Length - 1], result);
        }

        [Test]
        public void GetNextToLastElement_ReturnsNextToLastElement([Values(2, 3, 20)] int arrayLength)
        {
            // Arrange
            int[] array = Enumerable.Range(1, arrayLength).ToArray();

            // Act
            int result = UsingIndexerForAccessingArrayElement.GetNextToLastElement(array);

            // Assert
            Assert.AreEqual(array[array.Length - 2], result);
        }

        [Test, Sequential]
        public void GetNthArrayElement_ReturnsNthElement([Values(1, 2, 3, 20)] int arrayLength, [Values(1, 2, 3, 20)] int n)
        {
            // Arrange
            int[] array = Enumerable.Range(1, arrayLength).ToArray();

            // Act
            int result = UsingIndexerForAccessingArrayElement.GetNthArrayElement(array, n);

            // Assert
            Assert.AreEqual(array[n - 1], result);
        }

        [TestCase(new[] { true }, ExpectedResult = true)]
        public bool GetFirstArrayElement_ReturnsFirstBoolElement(bool[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetFirstArrayElement(array);
        }

        [TestCase(new[] { false, true }, ExpectedResult = true)]
        [TestCase(new[] { false, true, false }, ExpectedResult = true)]
        public bool GetSecondArrayElement_ReturnsSecondBoolElement(bool[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetSecondArrayElement(array);
        }

        [TestCase(new[] { false, false, false, false, false, true }, ExpectedResult = true)]
        [TestCase(new[] { false, false, false, false, false, true, false }, ExpectedResult = true)]
        public bool GetSixthArrayElement_ReturnsSixthBoolElement(bool[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetSixthArrayElement(array);
        }

        [TestCase(new[] { true }, ExpectedResult = true)]
        [TestCase(new[] { false, true }, ExpectedResult = true)]
        [TestCase(new[] { false, false, true }, ExpectedResult = true)]
        public bool GetLastElement_ReturnsLastBoolElement(bool[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetLastElement(array);
        }

        [TestCase(new[] { true, false }, ExpectedResult = true)]
        [TestCase(new[] { false, true, false }, ExpectedResult = true)]
        [TestCase(new[] { false, false, true, false }, ExpectedResult = true)]
        public bool GetNextToLastElement_ReturnsNextToLastBoolElement(bool[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetNextToLastElement(array);
        }

        [TestCase(new[] { true, false, false, false }, 1, ExpectedResult = true)]
        [TestCase(new[] { false, true, false, false }, 2, ExpectedResult = true)]
        [TestCase(new[] { false, false, true, false }, 3, ExpectedResult = true)]
        [TestCase(new[] { false, false, false, true }, 4, ExpectedResult = true)]
        public bool GetNthArrayElement_ReturnsNthElement(bool[] array, int n)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetNthArrayElement(array, n);
        }

        [Test]
        public void GetFirstArrayElement_ReturnsFirstStringElement()
        {
            // Arrange
            string[] array = { "one", "two", "three", "four", "five", "six" };

            // Act
            string result = UsingIndexerForAccessingArrayElement.GetFirstArrayElement(array);

            // Assert
            Assert.AreEqual("one", result);
        }

        [Test]
        public void GetForthArrayElement_ReturnsForthStringElement()
        {
            // Arrange
            string[] array = { "one", "two", "three", "four", "five", "six" };

            // Act
            string result = UsingIndexerForAccessingArrayElement.GetForthArrayElement(array);

            // Assert
            Assert.AreEqual("four", result);
        }

        [Test]
        public void GetLastElement_ReturnsLastStringElement()
        {
            // Arrange
            string[] array = { "one", "two", "three", "four", "five", "six" };

            // Act
            string result = UsingIndexerForAccessingArrayElement.GetLastElement(array);

            // Assert
            Assert.AreEqual("six", result);
        }

        [Test]
        public void GetNextToLastElement_ReturnsLastStringElement()
        {
            // Arrange
            string[] array = { "one", "two", "three", "four", "five", "six" };

            // Act
            string result = UsingIndexerForAccessingArrayElement.GetNextToLastElement(array);

            // Assert
            Assert.AreEqual("five", result);
        }

        // char section
        [TestCase(new[] { 'a' }, ExpectedResult = 'a')]
        [TestCase(new[] { 'a', 'b' }, ExpectedResult = 'a')]
        [TestCase(new[] { 'a', 'b', 'c' }, ExpectedResult = 'a')]
        public char GetFirstArrayElement_ReturnsFirstCharElement(char[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetFirstArrayElement(array);
        }

        [TestCase(new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' }, ExpectedResult = 'g')]
        [TestCase(new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' }, ExpectedResult = 'g')]
        public char GetSeventhArrayElement_ReturnsSeventhCharElement(char[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetSeventhArrayElement(array);
        }

        [TestCase(new[] { 'a' }, ExpectedResult = 'a')]
        [TestCase(new[] { 'a', 'b' }, ExpectedResult = 'b')]
        [TestCase(new[] { 'a', 'b', 'c' }, ExpectedResult = 'c')]
        public char GetLastElement_ReturnsLastCharElement(char[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetLastElement(array);
        }

        [TestCase(new[] { 'a', 'b' }, ExpectedResult = 'a')]
        [TestCase(new[] { 'a', 'b', 'c' }, ExpectedResult = 'b')]
        public char GetNextToLastElement_ReturnsNextToLastCharElement(char[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetNextToLastElement(array);
        }

        [TestCase(new[] { 0.01 }, ExpectedResult = 0.01)]
        [TestCase(new[] { 0.01, 0.02 }, ExpectedResult = 0.01)]
        [TestCase(new[] { 0.01, 0.02, 0.03 }, ExpectedResult = 0.01)]
        public double GetFirstArrayElement_ReturnsFirstDoubleElement(double[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetFirstArrayElement(array);
        }

        [TestCase(new[] { 0.01, 0.02, 0.03, 0.04, 0.05, 0.06, 0.07 }, ExpectedResult = 0.07)]
        [TestCase(new[] { 0.01, 0.02, 0.03, 0.04, 0.05, 0.06, 0.07, 0.08 }, ExpectedResult = 0.07)]
        public double GetSeventhArrayElement_ReturnsSeventhDoubleElement(double[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetSeventhArrayElement(array);
        }

        [TestCase(new[] { 0.01 }, ExpectedResult = 0.01)]
        [TestCase(new[] { 0.01, 0.02 }, ExpectedResult = 0.02)]
        [TestCase(new[] { 0.01, 0.02, 0.03 }, ExpectedResult = 0.03)]
        public double GetLastElement_ReturnsLastDoubleElement(double[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetLastElement(array);
        }

        [TestCase(new[] { 0.01, 0.02 }, ExpectedResult = 0.01)]
        [TestCase(new[] { 0.01, 0.02, 0.03 }, ExpectedResult = 0.02)]
        public double GetNextToLastElement_ReturnsNextToLastDoubleElement(double[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetNextToLastElement(array);
        }

        [TestCase(new[] { 0.01f }, ExpectedResult = 0.01f)]
        [TestCase(new[] { 0.01f, 0.02f }, ExpectedResult = 0.01f)]
        [TestCase(new[] { 0.01f, 0.02f, 0.03f }, ExpectedResult = 0.01f)]
        public float GetFirstArrayElement_ReturnsFirstFloatElement(float[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetFirstArrayElement(array);
        }

        [TestCase(new[] { 0.01f, 0.02f, 0.03f, 0.04f, 0.05f, 0.06f, 0.07f, 0.08f, 0.09f }, ExpectedResult = 0.09f)]
        [TestCase(new[] { 0.01f, 0.02f, 0.03f, 0.04f, 0.05f, 0.06f, 0.07f, 0.08f, 0.09f, 0.11f }, ExpectedResult = 0.09f)]
        public float GetNinthArrayElement_ReturnsNinthFloatElement(float[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetNinthArrayElement(array);
        }

        [TestCase(new[] { 0.01f }, ExpectedResult = 0.01f)]
        [TestCase(new[] { 0.01f, 0.02f }, ExpectedResult = 0.02f)]
        [TestCase(new[] { 0.01f, 0.02f, 0.03f }, ExpectedResult = 0.03f)]
        public float GetLastElement_ReturnsLastFloatElement(float[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetLastElement(array);
        }

        [TestCase(new[] { 0.01f, 0.02f }, ExpectedResult = 0.01f)]
        [TestCase(new[] { 0.01f, 0.02f, 0.03f }, ExpectedResult = 0.02f)]
        public float GetNextToLastElement_ReturnsNextToLastFloatElement(float[] array)
        {
            // Act
            return UsingIndexerForAccessingArrayElement.GetNextToLastElement(array);
        }

        [Test]
        public void GetLastElement_ReturnsLastDecimalElement()
        {
            // Arrange
            decimal[] array = { 0.01m, 0.02m, 0.03m, 0.04m };

            // Act
            decimal result = UsingIndexerForAccessingArrayElement.GetLastElement(array);

            // Assert
            Assert.AreEqual(0.04m, result);
        }

        [Test]
        public void GetNextToLastElement_ReturnsNextToLastDecimalElement()
        {
            // Arrange
            decimal[] array = { 0.01m, 0.02m, 0.03m, 0.04m };

            // Act
            decimal result = UsingIndexerForAccessingArrayElement.GetNextToLastElement(array);

            // Assert
            Assert.AreEqual(0.03m, result);
        }

        [Test]
        public void GetThirdElementFromEnd_ReturnsThirdDecimalElementFromEnd()
        {
            // Arrange
            decimal[] array = { 0.01m, 0.02m, 0.03m, 0.04m };

            // Act
            decimal result = UsingIndexerForAccessingArrayElement.GetThirdElementFromEnd(array);

            // Assert
            Assert.AreEqual(0.02m, result);
        }

        [Test]
        public void GetFourthElementFromEnd()
        {
            // Arrange
            decimal[] array = { 0.01m, 0.02m, 0.03m, 0.04m };

            // Act
            decimal result = UsingIndexerForAccessingArrayElement.GetFourthElementFromEnd(array);

            // Assert
            Assert.AreEqual(0.01m, result);
        }
    }
}
