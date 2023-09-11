using NUnit.Framework;

namespace Calculations.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(6, 2.4499999999999997)]
        [TestCase(10, 2.9289682539682538)]
        [TestCase(100, 5.187377517639621)]
        [TestCase(1_000_000, 14.392726722864989)]
        [TestCase(10_000_000, 16.695311365857272)]
        public void GetSumOneTests(int n, double expected)
        {
            Assert.AreEqual(expected, Calculator.GetSumOne(n), double.Epsilon);
        }

        [TestCase(6, 0.3761904761904762)]
        [TestCase(10, 0.3821789321789322)]
        [TestCase(100, 0.3862453487194004)]
        [TestCase(1_000_000, 0.38629436111938714)]
        [TestCase(10_000_000, 0.38629436111988125)]
        public void GetSumTwoTests(int n, double expected)
        {
            Assert.AreEqual(expected, Calculator.GetSumTwo(n), double.Epsilon);
        }

        [TestCase(6, 1.036790389660494)]
        [TestCase(10, 1.0369073413446939)]
        [TestCase(100, 1.0369277526929555)]
        [TestCase(1_000_000, 1.036927755143338)]
        [TestCase(10_000_000, 1.036927755143338)]
        public void GetSumThreeTests(int n, double expected)
        {
            Assert.AreEqual(expected, Calculator.GetSumThree(n), double.Epsilon);
        }

        [TestCase(6, 0.19804657596199388)]
        [TestCase(10, 0.21098888481753328)]
        [TestCase(100, 0.23122532283135178)]
        [TestCase(1_000_000, 0.23370030013643212)]
        [TestCase(10_000_000, 0.23370052513612405)]
        public void GetSumFourTests(int n, double expected)
        {
            Assert.AreEqual(expected: expected, Calculator.GetSumFour(n), double.Epsilon);
        }

        [TestCase(6, 3.154706790123457)]
        [TestCase(10, 3.342847116573682)]
        [TestCase(100, 3.639682294531309)]
        [TestCase(1_000_000, 3.676074234300874)]
        [TestCase(10_000_000, 3.6760775427785917)]
        public void GetProductOneTests(int n, double expected)
        {
            Assert.AreEqual(expected, Calculator.GetProductOne(n), double.Epsilon);
        }

        [TestCase(6, -0.17906537906537906)]
        [TestCase(10, -0.1919210476486018)]
        [TestCase(100, -0.21212664973225237)]
        [TestCase(1_000_000, -0.21460158660281903)]
        [TestCase(10_000_000, -0.2146018116025734)]
        public void GetSumFiveTests(int n, double expected)
        {
            Assert.AreEqual(expected, Calculator.GetSumFive(n), double.Epsilon);
        }

        [TestCase(6, 363.55835615201624)]
        [TestCase(10, 1384350.0519936203)]
        [TestCase(100, 1.8173121424936406E+157)]
        public void GetSumSixTests(int n, double expected)
        {
            Assert.AreEqual(expected, Calculator.GetSumSix(n), double.Epsilon);
        }

        [TestCase(1_000_000)]
        [TestCase(10_000_000)]
        public void GetSumSixInfinityTests(int n)
        {
            Assert.IsTrue(double.IsInfinity(Calculator.GetSumSix(n)));
        }

        [TestCase(6, 1.9993976373924085)]
        [TestCase(10, 1.9999976469034038)]
        [TestCase(100, 2)]
        [TestCase(1_000_000, 2)]
        [TestCase(10_000_000, 2)]
        public void GetSumSevenTests(int n, double expected)
        {
            Assert.AreEqual(expected, Calculator.GetSumSeven(n), double.Epsilon);
        }

        [TestCase(6, 98.23879465320995)]
        [TestCase(10, 104.20325304917145)]
        [TestCase(100, 113.7643137434921)]
        public void GetSumEightTests(int n, double expected)
        {
            Assert.AreEqual(expected, Calculator.GetSumEight(n), double.Epsilon);
        }
    }
}
