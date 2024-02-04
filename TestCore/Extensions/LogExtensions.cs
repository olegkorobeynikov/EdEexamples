using NLog;

namespace TestCore.Extensions
{
    public static class LogExtensions
    {
        public static void TitleH1(this Logger logger, string title)
        {
            logger.Info($"\n===\n\n{title}\n\n===\n");
        }
    }
}