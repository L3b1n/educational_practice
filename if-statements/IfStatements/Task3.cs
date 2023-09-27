namespace IfStatements
{
    public static class Task3
    {
        public static bool DoSomething1(bool b)
        {
            if (b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool DoSomething2(bool b)
        {
            return !b;
        }
    }
}
