namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            long sum = 0, i = 1, ielement = 0;

            while (ielement <= maxTerm)
            {
                ielement = (a * i * i) + (b * i) + c;
                if (ielement <= maxTerm)
                {
                    sum += ielement;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long sum = 0, i = startN, ielement = 0;

            while (count > 0)
            {
                ielement = (a * i * i) + (b * i) + c;
                sum += ielement;
                i++;
                count--;
            }

            return sum;
        }
    }
}
