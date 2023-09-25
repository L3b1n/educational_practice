namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            if (i < -8)
            {
                return i * i;
            }

            if (i <= -2)
            {
                return i * 3;
            }

            if (i <= 3)
            {
                return (i * 2) + (i * i);
            }

            if (i < 7)
            {
                return i * (i - 1) * -1;
            }
            else
            {
                return i * 2;
            }
        }
    }
}