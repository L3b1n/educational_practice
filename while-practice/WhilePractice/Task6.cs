namespace WhilePractice
{
    public static class Task6
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1;
            double minusone = -1;

            while (i <= n)
            {
                sum += minusone / ((2 * i) + 1);
                minusone *= -1d;
                i++;
            }

            return sum;
        }
    }
}
