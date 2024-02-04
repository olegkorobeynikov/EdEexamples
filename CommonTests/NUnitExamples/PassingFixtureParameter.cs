using NLog;

namespace CommonTests.NUnitExamples
{
    [FixtureLifeCycle(LifeCycle.SingleInstance)]
    [TestFixture(PassingType.Type1)]
    [TestFixture(PassingType.Type2)]
    [TestFixture(PassingType.Type3)]
    internal class PassingFixtureParameter1
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        private static PassingType _parameter;

        public PassingFixtureParameter1(PassingType parameter)
        {
            _parameter = parameter;
            Log.Info($"Constructor = {_parameter}");

        }

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Log.Info($"OneTimeSetUp = {_parameter}");
        }

        [Test]
        public void TryToUseParameter()
        {
            Log.Info($"Test = {_parameter}");
        }
    }

    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [TestFixture(PassingType.Type1)]
    [TestFixture(PassingType.Type2)]
    [TestFixture(PassingType.Type3)]
    internal class PassingFixtureParameter2
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        private static PassingType _parameter;

        public PassingFixtureParameter2(PassingType parameter)
        {
            _parameter = parameter;
            Log.Info($"Constructor = {_parameter}");

        }

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Log.Info($"OneTimeSetUp = {_parameter}");
        }

        [Test]
        public void TryToUseParameter()
        {
            Log.Info($"Test = {_parameter}");
        }
    }

    public enum PassingType
    {
        None,
        Type1,
        Type2,
        Type3
    }
}
