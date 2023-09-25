namespace IfStatements
{
    public static class Task3
    {
        public static int DoSomething1(bool b, int i)
        {
            if (b)
            {
                if (i <= -6)
                {
                    return i - 10;
                }
                else
                {
                    return i + 1;
                }
            }
            else
            {
                if (i < 8)
                {
                    return i - 1;
                }
                else
                {
                    return i + 10;
                }
            }
        }

        public static int DoSomething2(bool b, int i)
        {
            if (b)
            {
                if (i <= -6)
                {
                    return i - 10;
                }
                else
                {
                    return i + 1;
                }
            }
            else
            {
                if (i < 8)
                {
                    return i - 1;
                }
                else
                {
                    return i + 10;
                }
            }
        }
    }
}