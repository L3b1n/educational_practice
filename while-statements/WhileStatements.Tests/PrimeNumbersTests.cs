﻿namespace WhileStatements.Tests
{
    [TestFixture]
    public class PrimeNumbersTests
    {
        [TestCase(0u, ExpectedResult = false)]
        [TestCase(1u, ExpectedResult = false)]
        [TestCase(2u, ExpectedResult = true)]
        [TestCase(3u, ExpectedResult = true)]
        [TestCase(4u, ExpectedResult = false)]
        [TestCase(5u, ExpectedResult = true)]
        [TestCase(6u, ExpectedResult = false)]
        [TestCase(7u, ExpectedResult = true)]
        [TestCase(8u, ExpectedResult = false)]
        [TestCase(9u, ExpectedResult = false)]
        [TestCase(10u, ExpectedResult = false)]
        [TestCase(11u, ExpectedResult = true)]
        [TestCase(12u, ExpectedResult = false)]
        [TestCase(13u, ExpectedResult = true)]
        [TestCase(14u, ExpectedResult = false)]
        [TestCase(15u, ExpectedResult = false)]
        [TestCase(16u, ExpectedResult = false)]
        [TestCase(17u, ExpectedResult = true)]
        [TestCase(18u, ExpectedResult = false)]
        [TestCase(19u, ExpectedResult = true)]
        [TestCase(20u, ExpectedResult = false)]
        [TestCase(21u, ExpectedResult = false)]
        [TestCase(22u, ExpectedResult = false)]
        [TestCase(23u, ExpectedResult = true)]
        [TestCase(29u, ExpectedResult = true)]
        [TestCase(31u, ExpectedResult = true)]
        [TestCase(37u, ExpectedResult = true)]
        [TestCase(41u, ExpectedResult = true)]
        [TestCase(43u, ExpectedResult = true)]
        [TestCase(47u, ExpectedResult = true)]
        [TestCase(53u, ExpectedResult = true)]
        public bool IsPrimeNumber(uint n)
        {
            return PrimeNumbers.IsPrimeNumber(n);
        }

        [TestCase(0u, ExpectedResult = 0u)]
        [TestCase(1u, ExpectedResult = 0u)]
        [TestCase(2u, ExpectedResult = 2u)]
        [TestCase(3u, ExpectedResult = 3u)]
        [TestCase(4u, ExpectedResult = 3u)]
        [TestCase(5u, ExpectedResult = 5u)]
        [TestCase(6u, ExpectedResult = 5u)]
        [TestCase(7u, ExpectedResult = 7u)]
        [TestCase(8u, ExpectedResult = 7u)]
        [TestCase(9u, ExpectedResult = 7u)]
        [TestCase(10u, ExpectedResult = 7u)]
        [TestCase(11u, ExpectedResult = 11u)]
        [TestCase(12u, ExpectedResult = 11u)]
        [TestCase(13u, ExpectedResult = 13u)]
        [TestCase(14u, ExpectedResult = 13u)]
        [TestCase(15u, ExpectedResult = 13u)]
        [TestCase(16u, ExpectedResult = 13u)]
        [TestCase(17u, ExpectedResult = 17u)]
        [TestCase(18u, ExpectedResult = 17u)]
        [TestCase(19u, ExpectedResult = 19u)]
        [TestCase(20u, ExpectedResult = 19u)]
        [TestCase(21u, ExpectedResult = 19u)]
        [TestCase(22u, ExpectedResult = 19u)]
        [TestCase(23u, ExpectedResult = 23u)]
        [TestCase(23u, ExpectedResult = 23u)]
        [TestCase(24u, ExpectedResult = 23u)]
        [TestCase(25u, ExpectedResult = 23u)]
        [TestCase(26u, ExpectedResult = 23u)]
        [TestCase(27u, ExpectedResult = 23u)]
        [TestCase(28u, ExpectedResult = 23u)]
        [TestCase(29u, ExpectedResult = 29u)]
        [TestCase(30u, ExpectedResult = 29u)]
        [TestCase(31u, ExpectedResult = 31u)]
        [TestCase(32u, ExpectedResult = 31u)]
        [TestCase(37u, ExpectedResult = 37u)]
        [TestCase(40u, ExpectedResult = 37u)]
        [TestCase(41u, ExpectedResult = 41u)]
        [TestCase(42u, ExpectedResult = 41u)]
        [TestCase(43u, ExpectedResult = 43u)]
        [TestCase(46u, ExpectedResult = 43u)]
        [TestCase(47u, ExpectedResult = 47u)]
        [TestCase(52u, ExpectedResult = 47u)]
        [TestCase(53u, ExpectedResult = 53u)]
        public uint GetLastPrimeNumber(uint n)
        {
            return PrimeNumbers.GetLastPrimeNumber(n);
        }

        [TestCase(0u, 1u, ExpectedResult = 0u)]
        [TestCase(1u, 1u, ExpectedResult = 0u)]
        [TestCase(2u, 1u, ExpectedResult = 2u)]
        [TestCase(3u, 1u, ExpectedResult = 3u)]
        [TestCase(3u, 2u, ExpectedResult = 5u)]
        [TestCase(4u, 1u, ExpectedResult = 3u)]
        [TestCase(4u, 2u, ExpectedResult = 5u)]
        [TestCase(5u, 1u, ExpectedResult = 5u)]
        [TestCase(5u, 1u, ExpectedResult = 5u)]
        [TestCase(5u, 2u, ExpectedResult = 8u)]
        [TestCase(5u, 3u, ExpectedResult = 10u)]
        [TestCase(6u, 1u, ExpectedResult = 5u)]
        [TestCase(6u, 2u, ExpectedResult = 8u)]
        [TestCase(6u, 3u, ExpectedResult = 10u)]
        [TestCase(7u, 1u, ExpectedResult = 7u)]
        [TestCase(7u, 2u, ExpectedResult = 12u)]
        [TestCase(7u, 3u, ExpectedResult = 15u)]
        [TestCase(7u, 4u, ExpectedResult = 17u)]
        [TestCase(8u, 1u, ExpectedResult = 7u)]
        [TestCase(8u, 2u, ExpectedResult = 12u)]
        [TestCase(8u, 3u, ExpectedResult = 15u)]
        [TestCase(8u, 4u, ExpectedResult = 17u)]
        [TestCase(9u, 1u, ExpectedResult = 7u)]
        [TestCase(9u, 2u, ExpectedResult = 12u)]
        [TestCase(9u, 3u, ExpectedResult = 15u)]
        [TestCase(9u, 4u, ExpectedResult = 17u)]
        [TestCase(10u, 1u, ExpectedResult = 7u)]
        [TestCase(10u, 2u, ExpectedResult = 12u)]
        [TestCase(10u, 3u, ExpectedResult = 15u)]
        [TestCase(10u, 4u, ExpectedResult = 17u)]
        [TestCase(11u, 1u, ExpectedResult = 11u)]
        [TestCase(11u, 2u, ExpectedResult = 18u)]
        [TestCase(11u, 3u, ExpectedResult = 23u)]
        [TestCase(11u, 4u, ExpectedResult = 26u)]
        [TestCase(11u, 5u, ExpectedResult = 28u)]
        [TestCase(12u, 1u, ExpectedResult = 11u)]
        [TestCase(12u, 2u, ExpectedResult = 18u)]
        [TestCase(12u, 3u, ExpectedResult = 23u)]
        [TestCase(12u, 4u, ExpectedResult = 26u)]
        [TestCase(12u, 5u, ExpectedResult = 28u)]
        [TestCase(13u, 1u, ExpectedResult = 13u)]
        [TestCase(13u, 2u, ExpectedResult = 24u)]
        [TestCase(13u, 3u, ExpectedResult = 31u)]
        [TestCase(13u, 4u, ExpectedResult = 36u)]
        [TestCase(13u, 5u, ExpectedResult = 39u)]
        [TestCase(13u, 6u, ExpectedResult = 41u)]
        public uint SumLastPrimeNumbers(uint n, uint count)
        {
            return PrimeNumbers.SumLastPrimeNumbers(n, count);
        }
    }
}
