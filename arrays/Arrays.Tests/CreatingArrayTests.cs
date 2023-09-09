using System;
using NUnit.Framework;

namespace WorkingWithArrays.Tests
{
    [TestFixture]
    public sealed class CreatingArrayTests
    {
        [Test]
        public void CreateEmptyArrayOfIntegers_ReturnsEmptyArray()
        {
            // Act
            int[] result = CreatingArray.CreateEmptyArrayOfIntegers();

            Assert.AreEqual(Array.Empty<int>(), result);
        }

        [Test]
        public void CreateEmptyArrayOfBooleans_ReturnsEmptyArray()
        {
            // Act
            bool[] result = CreatingArray.CreateEmptyArrayOfBooleans();

            // Assert
            Assert.AreEqual(Array.Empty<bool>(), result);
        }

        [Test]
        public void CreateEmptyArrayOfStrings_ReturnsEmptyArray()
        {
            // Act
            string[] result = CreatingArray.CreateEmptyArrayOfStrings();

            // Assert
            Assert.AreEqual(Array.Empty<string>(), result);
        }

        [Test]
        public void CreateEmptyArrayOfCharacters_ReturnsEmptyArray()
        {
            // Act
            char[] result = CreatingArray.CreateEmptyArrayOfCharacters();

            // Assert
            Assert.AreEqual(Array.Empty<char>(), result);
        }

        [Test]
        public void CreateEmptyArrayOfDoubles_ReturnsEmptyArray()
        {
            // Act
            double[] result = CreatingArray.CreateEmptyArrayOfDoubles();

            // Assert
            Assert.AreEqual(Array.Empty<double>(), result);
        }

        [Test]
        public void CreateEmptyArrayOfFloats_ReturnsEmptyArray()
        {
            // Act
            float[] result = CreatingArray.CreateEmptyArrayOfFloats();

            // Assert
            Assert.AreEqual(Array.Empty<float>(), result);
        }

        [Test]
        public void CreateEmptyArrayOfDecimals_ReturnsEmptyArray()
        {
            // Act
            decimal[] result = CreatingArray.CreateEmptyArrayOfDecimals();

            // Assert
            Assert.AreEqual(Array.Empty<decimal>(), result);
        }

        [Test]
        public void CreateArrayOfTenIntegersWithDefaultValues_ReturnsArrayWithTenIntegers()
        {
            // Act
            int[] result = CreatingArray.CreateArrayOfTenIntegersWithDefaultValues();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(10, result.Length);
            Assert.That(result, Is.EquivalentTo(new int[10]));
        }

        [Test]
        public void CreateArrayOfTwentyBooleansWithDefaultValues_ReturnsArrayWithTwentyBooleans()
        {
            // Act
            bool[] result = CreatingArray.CreateArrayOfTwentyBooleansWithDefaultValues();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(20, result.Length);
            Assert.That(result, Is.EquivalentTo(new bool[20]));
        }

        [Test]
        public void CreateArrayOfFiveEmptyStrings_ReturnsArrayWithFiveEmptyStrings()
        {
            // Act
            string[] result = CreatingArray.CreateArrayOfFiveEmptyStrings();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(5, result.Length);
            Assert.That(result, Is.EquivalentTo(new string[5]));
        }

        [Test]
        public void CreateArrayOfFifteenCharactersWithDefaultValues_ReturnsArrayWithFifteenCharacters()
        {
            // Act
            char[] result = CreatingArray.CreateArrayOfFifteenCharactersWithDefaultValues();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(15, result.Length);
            Assert.That(result, Is.EquivalentTo(new char[15]));
        }

        [Test]
        public void CreateArrayOfEighteenDoublesWithDefaultValues_ReturnsArrayWithFifteenCharacters()
        {
            // Act
            double[] result = CreatingArray.CreateArrayOfEighteenDoublesWithDefaultValues();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(18, result.Length);
            Assert.That(result, Is.EquivalentTo(new double[18]));
        }

        [Test]
        public void CreateArrayOfOneHundredFloatsWithDefaultValues_ReturnsArrayWithOneHundredCharacters()
        {
            // Act
            float[] result = CreatingArray.CreateArrayOfOneHundredFloatsWithDefaultValues();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(100, result.Length);
            Assert.That(result, Is.EquivalentTo(new float[100]));
        }

        [Test]
        public void CreateArrayOfOneThousandDecimalsWithDefaultValues_ReturnsArrayWithOneThousandCharacters()
        {
            // Act
            decimal[] result = CreatingArray.CreateArrayOfOneThousandDecimalsWithDefaultValues();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(1000, result.Length);
            Assert.That(result, Is.EquivalentTo(new decimal[1000]));
        }

        [Test]
        public void CreateIntArrayWithOneElement_ReturnsArrayWithOneElement()
        {
            // Act
            int[] result = CreatingArray.CreateIntArrayWithOneElement();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(1, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 123_456 }));
        }

        [Test]
        public void CreateIntArrayWithTwoElements_ReturnsArrayWithTwoElement()
        {
            // Act
            int[] result = CreatingArray.CreateIntArrayWithTwoElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(2, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 1_111_111, 9_999_999 }));
        }

        [Test]
        public void CreateIntArrayWithTenElements_ReturnsArrayWithTenElement()
        {
            // Act
            int[] result = CreatingArray.CreateIntArrayWithTenElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(10, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 0, 4_234, 3_845, 2_942, 1_104, 9_794, 0_923_943, 7_537, 4_162, 10134 }));
        }

        [Test]
        public void CreateBoolArrayWithOneElement_ReturnsArrayWithOneElement()
        {
            // Act
            bool[] result = CreatingArray.CreateBoolArrayWithOneElement();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(1, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { true }));
        }

        [Test]
        public void CreateBoolArrayWithFiveElements_ReturnsArrayWithFiveElement()
        {
            // Act
            bool[] result = CreatingArray.CreateBoolArrayWithFiveElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(5, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { true, false, true, false, true }));
        }

        [Test]
        public void CreateBoolArrayWithSevenElements_ReturnsArrayWithSevenElement()
        {
            // Act
            bool[] result = CreatingArray.CreateBoolArrayWithSevenElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(7, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { false, true, true, false, true, true, false }));
        }

        [Test]
        public void CreateStringArrayWithOneElement_ReturnsArrayWithOneElement()
        {
            // Act
            string[] result = CreatingArray.CreateStringArrayWithOneElement();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(1, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { "one" }));
        }

        [Test]
        public void CreateStringArrayWithThreeElements_ReturnsArrayWithThreeElement()
        {
            // Act
            string[] result = CreatingArray.CreateStringArrayWithThreeElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(3, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { "one", "two", "three" }));
        }

        [Test]
        public void CreateStringArrayWithSixElements_ReturnsArrayWithSixElement()
        {
            // Act
            string[] result = CreatingArray.CreateStringArrayWithSixElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(6, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { "one", "two", "three", "four", "five", "six" }));
        }

        [Test]
        public void CreateCharArrayWithOneElement_ReturnsArrayWithOneElement()
        {
            // Act
            char[] result = CreatingArray.CreateCharArrayWithOneElement();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(1, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 'a' }));
        }

        [Test]
        public void CreateCharArrayWithThreeElements_ReturnsArrayWithThreeElement()
        {
            // Act
            char[] result = CreatingArray.CreateCharArrayWithThreeElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(3, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 'a', 'b', 'c' }));
        }

        [Test]
        public void CreateCharArrayWithNineElements_ReturnsArrayWithNineElement()
        {
            // Act
            char[] result = CreatingArray.CreateCharArrayWithNineElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(9, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' }));
        }

        [Test]
        public void CreateDoubleArrayWithOneElement_ReturnsArrayWithNineElement()
        {
            // Act
            double[] result = CreatingArray.CreateDoubleArrayWithOneElement();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(1, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 1.12 }));
        }

        [Test]
        public void CreateDoubleWithFiveElements_ReturnsArrayWithFiveElement()
        {
            // Act
            double[] result = CreatingArray.CreateDoubleWithFiveElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(5, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 1.12, 2.23, 3.34, 4.45, 5.56 }));
        }

        [Test]
        public void CreateDoubleWithNineElements_ReturnsArrayWithNineElement()
        {
            // Act
            double[] result = CreatingArray.CreateDoubleWithNineElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(9, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 }));
        }

        [Test]
        public void CreateFloatArrayWithOneElement_ReturnsArrayWithOneElement()
        {
            // Act
            float[] result = CreatingArray.CreateFloatArrayWithOneElement();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(1, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 123_456_789.12_34_56f }));
        }

        [Test]
        public void CreateFloatWithThreeElements_ReturnsArrayWithThreeElement()
        {
            // Act
            float[] result = CreatingArray.CreateFloatWithThreeElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(3, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 10_000_00.12_34_56f, 222_333_4444.12_34_56f, 9999.999999f }));
        }

        [Test]
        public void CreateFloatWithFiveElements_ReturnsArrayWithFiveElement()
        {
            // Act
            float[] result = CreatingArray.CreateFloatWithFiveElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(5, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 1.01_23f, 20.01_23_45f, 300.01_23_45_67f, 4_000.0123_4567f, 50_0000.01234567f }));
        }

        [Test]
        public void CreateDecimalArrayWithOneElement_ReturnsArrayWithOneElement()
        {
            // Act
            decimal[] result = CreatingArray.CreateDecimalArrayWithOneElement();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(1, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 10_000.12_34_56m }));
        }

        [Test]
        public void CreateDecimalWithFiveElements_ReturnsArrayWithFiveElement()
        {
            // Act
            decimal[] result = CreatingArray.CreateDecimalWithFiveElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(5, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 1_000.12_34m, 10_0000.23_45m, 100_000.34_56m, 1_000_000.4567_89m, 10000000.5678901m }));
        }

        [Test]
        public void CreateDecimalWithNineElements_ReturnsArrayWithNineElement()
        {
            // Act
            decimal[] result = CreatingArray.CreateDecimalWithNineElements();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(9, result.Length);
            Assert.That(result, Is.EquivalentTo(new[] { 10.12_21_12M, 200.23_32_23M, 3_000.34_43_34M, 40_000.45_54_45M, 500_000.56_65_56M, 6_000_000.67_76_67M, 70_000_000.78_87_78M, 800_000_000.89_98_89M, 9_000_000_000.91_19_91M }));
        }
    }
}
