namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(bool b1, bool b2)
        {
            if (b1)
            {
                if (b2)
                {
                    return 123;
                }
                else
                {
                    return -345;
                }
            }
            else
            {
                if (b2)
                {
                    return -567;
                }
                else
                {
                    return 789;
                }
            }
        }

        public static int DoSomething2(bool b1, bool b2)
        {
            if (b1)
            {
                if (b2)
                {
                    return 123;
                }
                else
                {
                    return -345;
                }
            }
            else
            {
                if (b2)
                {
                    return -567;
                }
                else
                {
                    return 789;
                }
            }
        }
    }
}