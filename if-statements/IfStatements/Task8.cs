namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i < -6 || i > 6)
                {
                    return true;
                }

                if (i >= -3 && i <= 3 && i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (i < -6 || i > 6)
                {
                    return true;
                }

                if (i > -3 && i < 3 && i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
