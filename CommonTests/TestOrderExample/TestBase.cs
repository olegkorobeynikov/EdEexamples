using NLog;

namespace CommonTests.TestOrderExample
{
    public class TestBase
    {
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public TestBase()
        {
            Log.Info($"Base - Constructor");
        }

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Log.Info($"Base - OneTimeSetUp");
        }

        [SetUp]
        public static void SetUp()
        {
            Log.Info($"Base - SetUp");
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Log.Info($"Base - OneTimeTearDown");
        }

        [TearDown]
        public static void TearDown()
        {
            Log.Info($"Base - TearDown");

        }
    }
}
