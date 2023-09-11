using System;

namespace Calculations
{
    public static class Calculator
    {
        public static double GetSumOne(int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }

            return sum;
        }

        public static double GetSumTwo(int n)
        {
            double sum = 0;
            double i = 2;

            while (i <= n)
            {
                sum += 1 / (i * (i - 1));
                i++;
                sum -= 1 / (i * (i - 1));
                i++;
            }

            return sum;
        }

        public static double GetSumThree(int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / (i * i * i * i * i);
            }

            return sum;
        }

        public static double GetSumFour(int n)
        {
            double sum = 0;
            double i = 1;
            while (i <= n)
            {
                sum += 1 / (((2 * i) + 1) * ((2 * i) + 1));
                i++;
            }

            return sum;
        }

        public static double GetProductOne(int n)
        {
            double sum = 1;
            double i = 1;
            while (i <= n)
            {
                sum *= 1 + (1 / (i * i));
                i++;
            }

            return sum;
        }

        public static double GetSumFive(int n)
        {
            double sum = 0;
            double i = 1;
            while (i <= n)
            {
                sum -= 1 / ((2 * i) + 1);
                i++;
                sum += 1 / ((2 * i) + 1);
                i++;
            }

            return sum;
        }

        public static double GetSumSix(int n)
        {
            double sum = 0;
            double i = 1;
            double fact = 1;
            double arSeq = 0;
            for (i = 1; i <= n; i++)
            {
                fact *= i;
                arSeq += 1 / i;
                sum += fact / arSeq;
            }

            return sum;
        }

        public static double GetSumSeven(int n)
        {
            double term = Math.Sqrt(2);
            for (int i = 1; i < n; i++)
            {
                term = Math.Sqrt(2 + term);
            }

            return term;
        }

        public static double GetSumEight(int n)
        {
            double sum = 0;
            double term = 0;
            for (int i = 1; i <= n; i++)
            {
                term += Math.Sin(Math.PI * i / 180);
                sum += 1 / term;
            }

            return sum;
        }
    }
}
