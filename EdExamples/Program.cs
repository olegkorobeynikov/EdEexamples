using NLog;

namespace EdExamples
{
    internal class Program
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Logger.Info("Hello there");
            Console.WriteLine("Hello, World!");
        }
    }
}