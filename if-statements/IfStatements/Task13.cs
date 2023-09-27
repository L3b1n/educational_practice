namespace IfStatements
{
    public static class Task13
    {
        public static int DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i < -8)
                {
                    return 5 + i;
                }

                if (i < -4)
                {
                    return i;
                }

                if (i < 0)
                {
                    return 5 + i;
                }

                if (i == 0)
                {
                    return 10;
                }

                if (i <= 3)
                {
                    return i - 5;
                }

                return -i;
            }
            else
            {
                if (i <= -5)
                {
                    return -i;
                }

                if (i <= 5)
                {
                    return 10 - i;
                }

                return -i;
            }
        }
    }
}
