namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething(int i)
        {
            if (i < -5 || i == 0 || i > 5)
            {
                return i;
            }
            else
            {
                if (i < 0)
                {
                    return i + 5;
                }
                else
                {
                    return i - 5;
                }
            }
        }
    }
}
