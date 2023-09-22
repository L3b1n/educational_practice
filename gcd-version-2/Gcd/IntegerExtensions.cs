using System;

namespace Gcd
{
    public static class IntegerExtensions
    {
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("a and b can't be zero", nameof(a));
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
            {
                return a + b;
            }

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            return a + b;
        }

        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("a and b and c can't be zero", nameof(a));
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);

            if (a == 0 || b == 0 || c == 0)
            {
                return a + b + c;
            }

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            int res = a + b;

            while (res != 0 && c != 0)
            {
                if (res > c)
                {
                    res = res % c;
                }
                else
                {
                    c = c % res;
                }
            }

            return res + c;
        }

        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            int i = 1;

            if (a == 0 && b == 0)
            {
                int res = other[0];

                while (i < other.Length)
                {
                    res = GetGcdByEuclidean(other[1], res);
                    i++;
                }

                return res;
            }
            else
            {
                int res1 = GetGcdByEuclidean(a, b);

                while (i < other.Length)
                {
                    res1 = GetGcdByEuclidean(other[i], res1);
                    i++;
                }

                return res1;
            }
        }

        public static int GetGcdByStein(int a, int b)
        {
            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("a and b can't be zero", nameof(a));
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
            {
                return a + b;
            }

            int k = 1;

            while ((a != 0) && (b != 0))
            {
                while ((a % 2 == 0) && (b % 2 == 0))
                {
                    a /= 2;
                    b /= 2;
                    k *= 2;
                }

                while (a % 2 == 0)
                {
                    a /= 2;
                }

                while (b % 2 == 0)
                {
                    b /= 2;
                }

                if (a >= b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return b * k;
        }

        public static int GetGcdByStein(int a, int b, int c)
        {
            if (a == 0 && b == 0)
            {
                int res = c;
                res = GetGcdByStein(res, b);

                return res;
            }
            else
            {
                int res1 = GetGcdByStein(a, b);
                res1 = GetGcdByStein(c, res1);

                return res1;
            }
        }

        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            int i = 1;

            if (a == 0 && b == 0)
            {
                int res = other[0];

                while (i < other.Length)
                {
                    res = GetGcdByStein(other[1], res);
                    i++;
                }

                return res;
            }
            else
            {
                int res1 = GetGcdByStein(a, b);

                while (i < other.Length)
                {
                    res1 = GetGcdByStein(other[i], res1);
                    i++;
                }

                return res1;
            }
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int res = GetGcdByEuclidean(a, b);
            elapsedTicks = watch.ElapsedMilliseconds;

            return res;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int res = GetGcdByEuclidean(a, b, c);
            elapsedTicks = watch.ElapsedMilliseconds;

            return res;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int res = GetGcdByEuclidean(a, b, other);
            elapsedTicks = watch.ElapsedMilliseconds;

            return res;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int res = GetGcdByStein(a, b);
            elapsedTicks = watch.ElapsedMilliseconds;

            return res;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int res = GetGcdByStein(a, b, c);
            elapsedTicks = watch.ElapsedMilliseconds;

            return res;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int res = GetGcdByStein(a, b, other);
            elapsedTicks = watch.ElapsedMilliseconds;

            return res;
        }
    }
}
