namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i <= -7 || i >= 7)
                {
                    return i;
                }
                else
                {
                    return 7 - i;
                }
            }
            else
            {
                if (i <= -5 || i >= 5)
                {
                    return i + 5;
                }
                else
                {
                    return i;
                }
            }
        }
    }
}
