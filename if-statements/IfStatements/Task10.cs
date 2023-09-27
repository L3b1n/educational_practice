namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1)
            {
                if (b2)
                {
                    if (i == 0)
                    {
                        return -1;
                    }

                    if (i < -9 || i > 9)
                    {
                        return i;
                    }

                    if (i > -2 && i < 2)
                    {
                        return i;
                    }

                    if (i <= -2)
                    {
                        return 5 + i;
                    }
                    else
                    {
                        return 10 - i;
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        return -1;
                    }

                    if (i < -9 || i > 9)
                    {
                        return i;
                    }

                    if (i > -2 && i < 2)
                    {
                        return i;
                    }

                    if (i <= -2)
                    {
                        return 5 - i;
                    }
                    else
                    {
                        return 10 + i;
                    }
                }
            }
            else
            {
                if (b2)
                {
                    if (i == 0)
                    {
                        return 1;
                    }

                    if (i <= -10 || i >= 10)
                    {
                        return i + 1;
                    }

                    if (i > -5 && i < 5)
                    {
                        return i + 10;
                    }

                    return i;
                }
                else
                {
                    if (i == 0)
                    {
                        return -1;
                    }

                    if (i <= -10 || i >= 10)
                    {
                        return i - 1;
                    }

                    if (i > -5 && i < 5)
                    {
                        return i - 10;
                    }

                    return i;
                }
            }
        }
    }
}
