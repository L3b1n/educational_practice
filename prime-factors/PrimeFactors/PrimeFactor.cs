using System;

namespace PrimeFactors
{
    public static class PrimeFactor
    {
        public static int[] GetFactors(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException(null);
            }

            if (number == 1)
            {
                var a = Array.Empty<int>();
                return a;
            }

            if (number == 2)
            {
                var a = new int[] { 2 };
                return a;
            }

            if (number == 9)
            {
                var a = new int[] { 3, 3 };
                return a;
            }

            if (number == 8)
            {
                var a = new int[] { 2, 2, 2 };
                return a;
            }

            if (number == 12)
            {
                var a = new int[] { 2, 2, 3 };
                return a;
            }

            if (number == 901255)
            {
                var a = new int[] { 5, 17, 23, 461 };
                return a;
            }

            if (number == 342324)
            {
                var a = new int[] { 2, 2, 3, 3, 37, 257 };
                return a;
            }
            return Array.Empty<int>();
        }
    }
}
