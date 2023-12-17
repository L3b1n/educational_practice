namespace WhilePractice
{
    public static class Task1
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1;

            while (i <= n)
            {
                sum += 1 / i;
                i++;
            }

            return sum;
        }
    }
}