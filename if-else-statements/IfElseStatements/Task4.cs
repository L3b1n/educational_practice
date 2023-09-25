namespace IfStatements
{
    public static class Task4
    {
        public static int DoSomething(bool b1, bool b2, bool b3, bool b4)
        {
            int result = 0;

            if (b1)
            {
                if (b2)
                {
                    if (b4)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 2;
                    }
                }
                else
                {
                    if (b3)
                    {
                        if (b4)
                        {
                            result = 4;
                        }
                        else
                        {
                            result = 3;
                        }
                    }
                    else
                    {
                        if (b4)
                        {
                            result = 1;
                        }
                        else
                        {
                            result = 2;
                        }
                    }
                }
            }
            else
            {
                if (b2)
                {
                    if (b3)
                    {
                            result = 6;
                    }
                    else
                    {
                            result = 5;
                    }
                }
                else
                {
                    if (b3)
                    {
                        if (b4)
                        {
                            result = 7;
                        }
                        else
                        {
                            result = 6;
                        }
                    }
                    else
                    {
                        if (b4)
                        {
                            result = 8;
                        }
                        else
                        {
                            result = 5;
                        }
                    }
                }
            }

            return result;
        }
    }
}