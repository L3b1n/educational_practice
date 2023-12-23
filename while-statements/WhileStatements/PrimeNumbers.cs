namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            int i = 2;

            if (n == 0 || n == 1)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }

            while (i < Math.Sqrt(n) + 1)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            while (n > 0)
            {
                if (!IsPrimeNumber(n))
                {
                    n--;
                }
                else
                {
                    break;
                }
            }

            if (n < 2)
            {
                return 0;
            }

            return n;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint sum = 0;

            while (n > 0 && count > 0)
            {
                if (IsPrimeNumber(n))
                {
                    sum += n;
                    count--;
                }

                n--;
            }

            return sum;
        }
    }
}
