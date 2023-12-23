namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint Pow(uint i, uint n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n > 0)
            {
                return i * Pow(i, n - 1);
            }

            return 0;
        }

        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0, i = 0, ielement;

            while (i < n)
            {
                ielement = a * Pow(r, i);
                sum = sum + ielement;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            uint sum = 0, i = 0, ielement;

            while (i < n)
            {
                ielement = 13 * Pow(3, i);
                sum = sum + ielement;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint count = 0, i = 0, ielement = 0;

            do
            {
                ielement = a * Pow(r, i);
                if (ielement <= maxTerm)
                {
                    count++;
                    i++;
                }
                else
                {
                    break;
                }
            }
            while (true);

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0, i = 0, ielement = 0;

            while (i < n)
            {
                ielement = a * Pow(r, i);
                if (ielement >= minTerm)
                {
                    count++;
                }

                i++;
            }

            return count;
        }
    }
}
