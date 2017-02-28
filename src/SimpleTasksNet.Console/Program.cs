using SimpleTasksNet.Logging.Implementation;
using SimpleTasksNet.Logging.Interfaces;

namespace SimpleTasksNet.Console
{
    class Program
    {
        private static readonly ILogger _logger = LogManager.GetLogger(typeof(Program)); 

        static void Main(string[] args)
        {
            _logger.Info("Program started");
        }
    }
}
