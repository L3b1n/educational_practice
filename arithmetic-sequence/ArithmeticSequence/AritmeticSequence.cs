using System;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int fins = number;
            int sum = number;
            int i = 0;
            count--;
            while (i < count)
            {
                sum += add;
                i++;
                fins += sum;
            }

            if (((number == int.MaxValue) && (add > 0)) || ((number == int.MinValue) && (add < 0)))
            {
                throw new OverflowException(); 
            }

            if (count < 0)
            {
                throw new ArgumentException();
            }

            return fins;
        }
    }
}
