namespace IfStatements
{
    public static class Task9
    {
        public static bool DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i < -8 || i > 8)
                {
                    return true;
                }

                if (i >= -4 && i <= 4 && i != 0)
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
                if (i < -8 || i >= 8)
                {
                    return true;
                }

                if (i >= -4 && i < 4 && i != 0)
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
