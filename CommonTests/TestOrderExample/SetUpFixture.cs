using NLog;

namespace CommonTests.TestOrderExample
{
    [SetUpFixture]
    internal class SetUpFixture
    {

        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public SetUpFixture()
        {
            Log.Info($"SetUpFixture - Constructor");
        }

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Log.Info($"SetUpFixture - OneTimeSetUp");
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Log.Info($"SetUpFixture - OneTimeTearDown");
        }
    }
}
