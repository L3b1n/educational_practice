namespace IfStatements
{
    public static class Task11
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1)
            {
                if (b2)
                {
                    if (i == 0)
                    {
                        return 1;
                    }

                    if (i < -8 || i >= 8)
                    {
                        return i;
                    }

                    if (i >= -4 && i < 4)
                    {
                        return i;
                    }

                    if (i < -4)
                    {
                        return i * 3;
                    }
                    else
                    {
                        return i * 2;
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        return -1;
                    }

                    if (i <= -7 || i > 7)
                    {
                        return i;
                    }

                    if (i > -3 && i <= 3)
                    {
                        return i;
                    }

                    if (i <= -3)
                    {
                        return 10 + (i * 3);
                    }
                    else
                    {
                        return 10 - (i * 2);
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

                    if (i < -8 || i >= 8)
                    {
                        return i - (i * i);
                    }

                    if (i > -4 && i <= 4)
                    {
                        return (i * i) - (i * i * i);
                    }

                    return i;
                }
                else
                {
                    if (i == 0)
                    {
                        return 1;
                    }

                    if (i <= -7 || i > 7)
                    {
                        return i - (i * i * i);
                    }

                    if (i >= -3 && i < 3)
                    {
                        return (i * i * i) - (i * i);
                    }

                    return i;
                }
            }
        }
    }
}
