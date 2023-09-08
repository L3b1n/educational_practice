using NUnit.Framework;
using static ArithmeticSequenceTask.ArithmeticSequence;

namespace ArithmeticSequenceTask.Tests
{
    [TestFixture]
    public class ArithmeticSequenceTests
    {
        [TestCase(3, 2, 1, ExpectedResult = 3)]
        [TestCase(2, 3, 5, ExpectedResult = 40)]
        [TestCase(3, 2, 20, ExpectedResult = 440)]
        [TestCase(2, 2, 10, ExpectedResult = 110)]
        [TestCase(1, -2, 10, ExpectedResult = -80)]
        [TestCase(100, -2, 1000, ExpectedResult = -899000)]
        public int CalculateTests(int number, int add, int count) => Calculate(number, add, count);

        [TestCase(int.MaxValue, 1, 2)]
        [TestCase(int.MinValue, -1, 2)]
        public void CalculateTest_SumOutOfRange_ThrowOverflowException(int number, int add, int count)
            => Assert.Throws<OverflowException>(
                () => Calculate(number, add, count), "The obtained result out of range of integer values.");

        [TestCase(3, 2, -10)]
        public void CalculateTest_CountLessOrEqualsZero_ThrowArgumentException(int number, int add, int count)
            => Assert.Throws<ArgumentException>(
                () => Calculate(number, add, count), "The count of elements of the sequence cannot be less or equals zero.");
    }
}
