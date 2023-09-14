using System;

namespace DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            if (radius <= 1)
            {
                return 10;
            }
            else if (radius <= 5)
            {
                return 5;
            }
            else if (radius <= 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
