namespace IfStatements
{
    public static class Task12
    {
        public static int DoSomething(int i)
        {
            if (i < -8)
            {
                return i * i;
            }

            if (i < -5)
            {
                return i;
            }

            if (i < 5)
            {
                return (i * i) - i;
            }

            if (i < 10)
            {
                return i;
            }

            return -i * i;
        }
    }
}
