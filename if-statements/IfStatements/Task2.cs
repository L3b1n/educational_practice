namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(int i)
        {
            if (i < -5)
            {
                return -i * i;
            }
            else
            {
                if (i < 0)
                {
                    return -i;
                }
                else
                {
                    return i;
                }
            }
        }

        public static int DoSomething2(int i)
        {
            int k;

            if (i < -5)
            {
                k = -i * i;
            }
            else
            {
                if (i < 0)
                {
                    k = -i;
                }
                else
                {
                    k = i;
                }
            }

            return k;
        }
    }
}
