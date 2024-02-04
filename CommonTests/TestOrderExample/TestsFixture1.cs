namespace CommonTests.TestOrderExample
{
    internal class Fixture : TestBase
    {
        public Fixture()
        {
            Log.Info($"Fixture - Constructor");
        }

        [OneTimeSetUp]
        public static new void OneTimeSetUp()
        {
            Log.Info($"Fixture - new OneTimeSetUp");
        }

        [SetUp]
        public static new void SetUp()
        {
            Log.Info($"Fixture - new SetUp");
        }

        [OneTimeTearDown]
        public static new void OneTimeTearDown()
        {
            Log.Info($"Fixture - new OneTimeTearDown");
        }

        [TearDown]
        public static new void TearDown()
        {
            Log.Info($"Fixture - new TearDown");
        }

        [Test]
        public static void Test1()
        {
            Log.Info($"Fixture - Test1");
        }

        [TestCaseSource(nameof(TestCaseCreator))]
        public static void Test2(string s)
        {
            Log.Info($"Fixture - Test2 - {s}");
        }

        public static IEnumerable<TestCaseData> TestCaseCreator()
        {
            Log.Info($"Fixture - TestCaseCreator");
            yield return new TestCaseData("case1");
            yield return new TestCaseData("case2");
        }
    }
}
