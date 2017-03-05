using SimpleTasksNet.Logging.Interfaces;

namespace SimpleTasksNet.Console
{
    class ProgramLogic
    {
        private ILogger _logger; 

        public ProgramLogic(ILogger logger)
        {
            _logger = logger; 
        }

        public void Execute()
        {
            _logger.Info("Starting program.");

            // TODO: Logic here

            _logger.Info("Program execution ended."); 
        }
    }
}
