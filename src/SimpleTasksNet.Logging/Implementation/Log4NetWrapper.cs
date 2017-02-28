using log4net;
using SimpleTasksNet.Logging.Interfaces;
using System;

namespace SimpleTasksNet.Logging.Implementation
{
    public class Log4NetWrapper : ILogger
    {
        private readonly ILog _logger;

        public Log4NetWrapper(Type type)
        {
            _logger = log4net.LogManager.GetLogger(type); 
        }

        public bool IsDebugEnabled => _logger.IsDebugEnabled;

        public void Error(string message, Exception ex = null)
        {
            if(ex == null)
            {
                _logger.Error(message); 
            }
            else
            {
                _logger.Error(message, ex); 
            }
        }

        public void Info(string message)
        {
            _logger.Info(message); 
        }
    }
}
