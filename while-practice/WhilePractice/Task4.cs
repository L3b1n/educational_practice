namespace WhilePractice
{
    public static class Task4
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1;

            while (i <= n)
            {
                sum += 1d / (((2d * i) + 1d) * ((2d * i) + 1d));
                i++;
            }

            return sum;
        }
    }
}