using TestCore;
using NLog;

namespace CommonTests
{
    public class TestBase
    {
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Log.TitleH1($"TestClass = {TestContext.CurrentContext.Test.ClassName}");
        }

        [SetUp]
        public static void SetUp()
        {
            Log.TitleH1($"Test = {TestContext.CurrentContext.Test.FullName.Split('.').Last()}");
        }
    }
}
