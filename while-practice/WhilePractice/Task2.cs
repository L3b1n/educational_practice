namespace WhilePractice
{
    public static class Task2
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1;
            double minusone = -1;

            while (i <= n)
            {
                minusone *= -1d;
                sum += minusone / (i * (i + 1));
                i++;
            }

            return sum;
        }
    }
}