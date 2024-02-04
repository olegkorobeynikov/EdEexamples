namespace CommonTests.LoggerExample
{
    public class Tests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            Log.Info("SetUp");
        }

        [Test]
        public void Test1()
        {
            Log.Info("Test1 here");
            Assert.Pass();
        }

        [TestCase("s1")]
        [TestCase("s2")]
        public void Test2(string str)
        {
            Log.Info("Test2 here");
            Assert.Pass(str);
        }
    }
}