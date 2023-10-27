using System;

#pragma warning disable CA1305
#pragma warning disable SA1008

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine($"Number {first} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
            else if (second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine($"Number {first} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
            else if (second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.WriteLine($"Number {first} is the largest");
            }
            else if (second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else if (userAge >= 21)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine("You're old enough to drive.");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else if (countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }
            else if (countOfDailyDownloads < 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }
            else if (countOfDailyDownloads < 10000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }
            else if (countOfDailyDownloads < 100000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }

        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("The weekend.");
            }
            else if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The first day of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the work week.");
            }
            else
            {
                Console.WriteLine("The middle of the work week.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("The weekend.");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;
                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            string str = string.Empty;

            if (arg is sbyte)
            {
                str = arg.ToString() + " is sbyte.";
            }
            else if (arg is byte)
            {
                str = arg.ToString() + " is byte.";
            }
            else if (arg is short)
            {
                str = arg.ToString() + " is short.";
            }
            else if (arg is ushort)
            {
                str = arg.ToString() + " is ushort.";
            }
            else if (arg is int)
            {
                str = arg.ToString() + " is int.";
            }
            else if (arg is uint)
            {
                str = arg.ToString() + " is uint.";
            }
            else if (arg is long)
            {
                str = arg.ToString() + " is long.";
            }
            else if (arg is ulong)
            {
                str = arg.ToString() + " is ulong.";
            }
            else
            {
                str = arg.ToString() + " is not integer.";
            }

            return str;
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            string str = string.Empty;

            switch (arg)
            {
                case sbyte _:
                    str = arg.ToString() + " is sbyte.";
                    break;
                case byte _:
                    str = arg.ToString() + " is byte.";
                    break;
                case short _:
                    str = arg.ToString() + " is short.";
                    break;
                case ushort _:
                    str = arg.ToString() + " is ushort.";
                    break;
                case int _:
                    str = arg.ToString() + " is int.";
                    break;
                case uint _:
                    str = arg.ToString() + " is uint.";
                    break;
                case long _:
                    str = arg.ToString() + " is long.";
                    break;
                case ulong _:
                    str = arg.ToString() + " is ulong.";
                    break;
                default:
                    str = arg.ToString() + " is not integer.";
                    break;
            }

            return str;
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg) =>
            arg switch
            {
                sbyte => $"{arg} is sbyte.",
                byte => $"{arg} is byte.",
                short => $"{arg} is short.",
                ushort => $"{arg} is ushort.",
                int => $"{arg} is int.",
                uint => $"{arg} is uint.",
                long => $"{arg} is long.",
                ulong => $"{arg} is ulong.",
                _ => $"{arg} is not integer.",
            };

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.March:
                case Month.April:
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.June:
                case Month.July:
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.September:
                case Month.October:
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;
                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            int num;

            if (number > -1_000_000_100)
            {
                num = Math.Abs(number);
            }
            else
            {
                num = Math.Abs(number + 10);
            }

            if (num < 10)
            {
                return 1;
            }

            if (num < 100)
            {
                return 2;
            }

            if (num < 1_000)
            {
                return 3;
            }

            if (num < 10_000)
            {
                return 4;
            }

            if (num < 100_000)
            {
                return 5;
            }

            if (num < 1_000_000)
            {
                return 6;
            }

            if (num < 10_000_000)
            {
                return 7;
            }

            if (num < 100_000_000)
            {
                return 8;
            }

            if (num < 1_000_000_000)
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }

        public static byte GetLengthWithSwitchExpression(int number) =>
            number switch
            {
                (< 10) and (> -10) => 1,
                (< 100) and (> -100) => 2,
                (< 1_000) and (> -1_000) => 3,
                (< 10_000) and (> -10_000) => 4,
                (< 100_000) and (> -100_000) => 5,
                (< 1_000_000) and (> -1_000_000) => 6,
                (< 10_000_000) and (> -10_000_000) => 7,
                (< 100_000_000) and (> -100_000_000) => 8,
                (< 1_000_000_000) and (> -1_000_000_000) => 9,
                _ => 10,
            };

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month == 1)
            {
                return Month.January;
            }

            if (month == 2)
            {
                return Month.February;
            }

            if (month == 3)
            {
                return Month.March;
            }

            if (month == 4)
            {
                return Month.April;
            }

            if (month == 5)
            {
                return Month.May;
            }

            if (month == 6)
            {
                return Month.June;
            }

            if (month == 7)
            {
                return Month.July;
            }

            if (month == 8)
            {
                return Month.August;
            }

            if (month == 9)
            {
                return Month.September;
            }

            if (month == 10)
            {
                return Month.October;
            }

            if (month == 11)
            {
                return Month.November;
            }

            if (month == 12)
            {
                return Month.December;
            }
            else
            {
                return null;
            }
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case 1:
                    return Month.January;
                case 2:
                    return Month.February;
                case 3:
                    return Month.March;
                case 4:
                    return Month.April;
                case 5:
                    return Month.May;
                case 6:
                    return Month.June;
                case 7:
                    return Month.July;
                case 8:
                    return Month.August;
                case 9:
                    return Month.September;
                case 10:
                    return Month.October;
                case 11:
                    return Month.November;
                case 12:
                    return Month.December;
                default:
                    return null;
            }
        }

        public static Month? GetMonthWithSwitchExpression(int month) =>
            month switch
            {
                1 => Month.January,
                2 => Month.February,
                3 => Month.March,
                4 => Month.April,
                5 => Month.May,
                6 => Month.June,
                7 => Month.July,
                8 => Month.August,
                9 => Month.September,
                10 => Month.October,
                11 => Month.November,
                12 => Month.December,
                _ => null,
            };
    }
}
