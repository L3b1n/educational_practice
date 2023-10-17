using NUnit.Framework;

namespace PrintFace.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private StringWriter writer;

        [SetUp]
        public void SetUp()
        {
            this.writer = new StringWriter();
            Console.SetOut(this.writer);
        }

        [TearDown]
        public void Cleanup()
        {
            this.writer.Close();
        }

        [Test]
        public void Main_Tests()
        {
            Program.Main();

            string actual = this.writer.GetStringBuilder().ToString().Trim();

            string expected = "Hello, world!";

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Joseph")]
        [TestCase("Eric")]
        [TestCase("Jon")]
        public void SayHelloUser_Tests(string userName)
        {
            Program.SayHelloUser(userName);

            string actual = this.writer.GetStringBuilder().ToString().Trim();

            string expected = $"Hello, {userName}!";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrintFace_Tests()
        {
            Program.PrintFace();

            string actual = this.writer.GetStringBuilder().ToString();

            string expected = $" +\"\"\"\"\"+{Environment.NewLine}" +
                              $"(| o o |){Environment.NewLine}" +
                              $" |  ^  |{Environment.NewLine}" +
                              $" | '-' |{Environment.NewLine}" +
                              $" +-----+{Environment.NewLine}";

            Assert.AreEqual(expected, actual);
        }
    }
}
