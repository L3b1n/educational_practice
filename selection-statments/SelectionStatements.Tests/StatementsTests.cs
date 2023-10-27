using NUnit.Framework;
using SelectionStatments;

namespace SelectionStatements.Tests
{
    [TestFixture]
    public class StatementsTests
    {
        private StringWriter? writer;

        [SetUp]
        public void SetUp()
        {
            this.writer = new StringWriter();
            Console.SetOut(this.writer);
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            this.writer.Close();
        }

        [TestCase(7, -23, 13, 13)]
        [TestCase(77, 23, -13, 77)]
        [TestCase(77, -23, 13, 77)]
        [TestCase(-7, 23, 103, 103)]
        [TestCase(7, 809, 13, 809)]
        [TestCase(-7, 89, -13, 89)]
        public void WriteLargestWithNestedIfElseTests(int first, int second, int third, int largest)
        {
            Statements.WriteLargestWithNestedIfElse(first, second, third);

            string actual = this.writer.GetStringBuilder().ToString().Trim();

            string expected = $"Number {largest} is the largest";

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, -23, 13, 13)]
        [TestCase(77, 23, -13, 77)]
        [TestCase(77, -23, 13, 77)]
        [TestCase(-7, 23, 103, 103)]
        [TestCase(7, 809, 13, 809)]
        [TestCase(-7, 89, -13, 89)]
        public void WriteLargestWithIfElseAndTernaryOperatorTests(int first, int second, int third, int largest)
        {
            Statements.WriteLargestWithIfElseAndTernaryOperator(first, second, third);

            string actual = this.writer.GetStringBuilder().ToString().Trim();

            string expected = $"Number {largest} is the largest";

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, -23, 13, 13)]
        [TestCase(77, 23, -13, 77)]
        [TestCase(77, -23, 13, 77)]
        [TestCase(-7, 23, 103, 103)]
        [TestCase(7, 809, 13, 809)]
        [TestCase(-7, 89, -13, 89)]
        public void WriteLargestWithIfElseAndConditionLogicalOperatorsTests(int first, int second, int third, int largest)
        {
            Statements.WriteLargestWithIfElseAndConditionLogicalOperators(first, second, third);

            string actual = this.writer.GetStringBuilder().ToString().Trim();

            string expected = $"Number {largest} is the largest";

            Assert.AreEqual(expected, actual);
        }

        [TestCase(77, ExpectedResult = "Enjoy your retirement!")]
        [TestCase(21, ExpectedResult = "Fancy an alcoholic beverage?")]
        [TestCase(45, ExpectedResult = "Fancy an alcoholic beverage?")]
        [TestCase(33, ExpectedResult = "Fancy an alcoholic beverage?")]
        [TestCase(18, ExpectedResult = "You're old enough to drive.")]
        [TestCase(20, ExpectedResult = "You're old enough to drive.")]
        [TestCase(15, ExpectedResult = "You are too young to drive, drink, or retire.")]
        [TestCase(4, ExpectedResult = "You are too young to drive, drink, or retire.")]
        public string HowOldAreYouWithCascadedIfElseTests(int userAge)
        {
            Statements.HowOldAreYouReactionWithCascadedIfElse(userAge);
            return this.writer.GetStringBuilder().ToString().Trim();
        }

        [TestCase(-90, ExpectedResult = "No downloads.")]
        [TestCase(0, ExpectedResult = "No downloads.")]
        [TestCase(77, ExpectedResult = "Daily downloads: 1-100.")]
        [TestCase(291, ExpectedResult = "Daily downloads: 100-1,000.")]
        [TestCase(4508, ExpectedResult = "Daily downloads: 1,000-10,000.")]
        [TestCase(33987, ExpectedResult = "Daily downloads: 10,000-100,000.")]
        [TestCase(180765, ExpectedResult = "Daily downloads: 100,000+.")]
        [TestCase(1800765, ExpectedResult = "Daily downloads: 100,000+.")]
        public string WriteInformationAboutDailyDownloadsWithCascadedIfElseTests(int countOfDailyDownloads)
        {
            Statements.WriteInformationAboutDailyDownloadsWithCascadedIfElse(countOfDailyDownloads);
            return this.writer.GetStringBuilder().ToString().Trim();
        }

        [TestCase(Month.April, ExpectedResult = "It's spring now.")]
        [TestCase(Month.February, ExpectedResult = "It's winter now.")]
        [TestCase(Month.August, ExpectedResult = "It's summer now.")]
        [TestCase(Month.June, ExpectedResult = "It's summer now.")]
        [TestCase(Month.November, ExpectedResult = "It's autumn now.")]
        [TestCase(12, ExpectedResult = "It's winter now.")]
        [TestCase(6, ExpectedResult = "It's summer now.")]
        [TestCase(9, ExpectedResult = "It's autumn now.")]
        [TestCase(14, ExpectedResult = "Sorry, the month was entered incorrectly.")]
        public string WriteTheInformationAboutSeasonsWithSwitchStatementTests(Month month)
        {
            Statements.WriteTheInformationAboutSeasonsWithSwitchStatement(month);
            return this.writer.GetStringBuilder().ToString().Trim();
        }

        [TestCase(DayOfWeek.Sunday, ExpectedResult = "The weekend.")]
        [TestCase(DayOfWeek.Saturday, ExpectedResult = "The weekend.")]
        [TestCase(DayOfWeek.Monday, ExpectedResult = "The first day of the work week.")]
        [TestCase(DayOfWeek.Friday, ExpectedResult = "The last day of the work week.")]
        [TestCase(DayOfWeek.Tuesday, ExpectedResult = "The middle of the work week.")]
        [TestCase(DayOfWeek.Wednesday, ExpectedResult = "The middle of the work week.")]
        public string WriteTheInformationAboutDayWithIfElseTests(DayOfWeek dayOfWeek)
        {
            Statements.WriteTheInformationAboutDayWithIfElse(dayOfWeek);
            return this.writer.GetStringBuilder().ToString().Trim();
        }

        [TestCase(DayOfWeek.Sunday, ExpectedResult = "The weekend.")]
        [TestCase(DayOfWeek.Saturday, ExpectedResult = "The weekend.")]
        [TestCase(DayOfWeek.Monday, ExpectedResult = "The first day of the work week.")]
        [TestCase(DayOfWeek.Friday, ExpectedResult = "The last day of the work week.")]
        [TestCase(DayOfWeek.Tuesday, ExpectedResult = "The middle of the work week.")]
        [TestCase(DayOfWeek.Wednesday, ExpectedResult = "The middle of the work week.")]
        public string WriteTheInformationAboutDayWithSwitchStatementTests(DayOfWeek dayOfWeek)
        {
            Statements.WriteTheInformationAboutDayWithSwitchStatement(dayOfWeek);
            return this.writer.GetStringBuilder().ToString().Trim();
        }

        [TestCase(int.MinValue, ExpectedResult = 10)]
        [TestCase(int.MaxValue, ExpectedResult = 10)]
        [TestCase(-1101123234, ExpectedResult = 10)]
        [TestCase(-101123234, ExpectedResult = 9)]
        [TestCase(-33123543, ExpectedResult = 8)]
        [TestCase(3123543, ExpectedResult = 7)]
        [TestCase(127653, ExpectedResult = 6)]
        [TestCase(65908, ExpectedResult = 5)]
        [TestCase(1500, ExpectedResult = 4)]
        [TestCase(498, ExpectedResult = 3)]
        [TestCase(48, ExpectedResult = 2)]
        [TestCase(-1, ExpectedResult = 1)]
        [TestCase(0, ExpectedResult = 1)]
        public byte GetLengthWithCascadedIfElseTests(int number)
        {
            return Statements.GetLengthWithCascadedIfElse(number);
        }

        [TestCase(int.MinValue, ExpectedResult = 10)]
        [TestCase(int.MaxValue, ExpectedResult = 10)]
        [TestCase(-1101123234, ExpectedResult = 10)]
        [TestCase(-101123234, ExpectedResult = 9)]
        [TestCase(-33123543, ExpectedResult = 8)]
        [TestCase(3123543, ExpectedResult = 7)]
        [TestCase(127653, ExpectedResult = 6)]
        [TestCase(65908, ExpectedResult = 5)]
        [TestCase(1500, ExpectedResult = 4)]
        [TestCase(498, ExpectedResult = 3)]
        [TestCase(48, ExpectedResult = 2)]
        [TestCase(-1, ExpectedResult = 1)]
        [TestCase(0, ExpectedResult = 1)]
        public byte GetLengthWithSwitchExpressionTests(int number)
        {
            return Statements.GetLengthWithSwitchExpression(number);
        }

        [TestCase((sbyte)-12, ExpectedResult = "-12 is sbyte.")]
        [TestCase((byte)126, ExpectedResult = "126 is byte.")]
        [TestCase((ushort)65478, ExpectedResult = "65478 is ushort.")]
        [TestCase(short.MinValue, ExpectedResult = "-32768 is short.")]
        [TestCase(int.MaxValue, ExpectedResult = "2147483647 is int.")]
        [TestCase(2147483649L, ExpectedResult = "2147483649 is long.")]
        [TestCase(908876L, ExpectedResult = "908876 is long.")]
        [TestCase(1239087ul, ExpectedResult = "1239087 is ulong.")]
        [TestCase(90f, ExpectedResult = "90 is not integer.")]
        [TestCase(90d, ExpectedResult = "90 is not integer.")]
        public string GetTypeOfIntegerWithCascadedIfElseTests(object arg)
        {
            return Statements.GetTypeOfIntegerWithCascadedIfElse(arg);
        }

        [TestCase((sbyte)-12, ExpectedResult = "-12 is sbyte.")]
        [TestCase((byte)126, ExpectedResult = "126 is byte.")]
        [TestCase((ushort)65478, ExpectedResult = "65478 is ushort.")]
        [TestCase(short.MinValue, ExpectedResult = "-32768 is short.")]
        [TestCase(int.MaxValue, ExpectedResult = "2147483647 is int.")]
        [TestCase(2147483649L, ExpectedResult = "2147483649 is long.")]
        [TestCase(908876L, ExpectedResult = "908876 is long.")]
        [TestCase(1239087ul, ExpectedResult = "1239087 is ulong.")]
        [TestCase(90f, ExpectedResult = "90 is not integer.")]
        [TestCase(90d, ExpectedResult = "90 is not integer.")]
        public string GetTypeOfIntegerWithSwitchStatementTests(object arg)
        {
            return Statements.GetTypeOfIntegerWithSwitchStatement(arg);
        }

        [TestCase((sbyte)-12, ExpectedResult = "-12 is sbyte.")]
        [TestCase((byte)126, ExpectedResult = "126 is byte.")]
        [TestCase((ushort)65478, ExpectedResult = "65478 is ushort.")]
        [TestCase(short.MinValue, ExpectedResult = "-32768 is short.")]
        [TestCase(int.MaxValue, ExpectedResult = "2147483647 is int.")]
        [TestCase(2147483649L, ExpectedResult = "2147483649 is long.")]
        [TestCase(908876L, ExpectedResult = "908876 is long.")]
        [TestCase(1239087ul, ExpectedResult = "1239087 is ulong.")]
        [TestCase(90f, ExpectedResult = "90 is not integer.")]
        [TestCase(90d, ExpectedResult = "90 is not integer.")]
        public string GetTypeOfIntegerWithSwitchExpressionTests(object arg)
        {
            return Statements.GetTypeOfIntegerWithSwitchExpression(arg);
        }

        [TestCase(1, ExpectedResult = Month.January)]
        [TestCase(2, ExpectedResult = Month.February)]
        [TestCase(3, ExpectedResult = Month.March)]
        [TestCase(4, ExpectedResult = Month.April)]
        [TestCase(5, ExpectedResult = Month.May)]
        [TestCase(6, ExpectedResult = Month.June)]
        [TestCase(7, ExpectedResult = Month.July)]
        [TestCase(8, ExpectedResult = Month.August)]
        [TestCase(9, ExpectedResult = Month.September)]
        [TestCase(10, ExpectedResult = Month.October)]
        [TestCase(11, ExpectedResult = Month.November)]
        [TestCase(12, ExpectedResult = Month.December)]
        [TestCase(13, ExpectedResult = null)]
        [TestCase(-123, ExpectedResult = null)]
        public Month? GetMonthWithCascadedIfElseTests(int month)
        {
            return Statements.GetMonthWithCascadedIfElse(month);
        }

        [TestCase(1, ExpectedResult = Month.January)]
        [TestCase(2, ExpectedResult = Month.February)]
        [TestCase(3, ExpectedResult = Month.March)]
        [TestCase(4, ExpectedResult = Month.April)]
        [TestCase(5, ExpectedResult = Month.May)]
        [TestCase(6, ExpectedResult = Month.June)]
        [TestCase(7, ExpectedResult = Month.July)]
        [TestCase(8, ExpectedResult = Month.August)]
        [TestCase(9, ExpectedResult = Month.September)]
        [TestCase(10, ExpectedResult = Month.October)]
        [TestCase(11, ExpectedResult = Month.November)]
        [TestCase(12, ExpectedResult = Month.December)]
        [TestCase(13, ExpectedResult = null)]
        [TestCase(-123, ExpectedResult = null)]
        public Month? GetMonthWithSwitchStatementTests(int month)
        {
            return Statements.GetMonthWithSwitchStatement(month);
        }

        [TestCase(1, ExpectedResult = Month.January)]
        [TestCase(2, ExpectedResult = Month.February)]
        [TestCase(3, ExpectedResult = Month.March)]
        [TestCase(4, ExpectedResult = Month.April)]
        [TestCase(5, ExpectedResult = Month.May)]
        [TestCase(6, ExpectedResult = Month.June)]
        [TestCase(7, ExpectedResult = Month.July)]
        [TestCase(8, ExpectedResult = Month.August)]
        [TestCase(9, ExpectedResult = Month.September)]
        [TestCase(10, ExpectedResult = Month.October)]
        [TestCase(11, ExpectedResult = Month.November)]
        [TestCase(12, ExpectedResult = Month.December)]
        [TestCase(13, ExpectedResult = null)]
        [TestCase(-123, ExpectedResult = null)]
        public Month? GetMonthWithSwitchExpressionTest(int month)
        {
            return Statements.GetMonthWithSwitchExpression(month);
        }
    }
}
