namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sumnum = 0;
            while (n > 0)
            {
                sumnum += n % 10;
                n /= 10;
            }

            return sumnum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong sumnum = 1;

            if (n == 0)
            {
                return 0;
            }

            while (n > 0)
            {
                sumnum *= n % 10;
                n /= 10;
            }

            return sumnum;
        }
    }
}
