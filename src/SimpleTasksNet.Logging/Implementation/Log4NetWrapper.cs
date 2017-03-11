using log4net;
using SimpleTasksNet.Logging.Interfaces;
using System;
using System.Reflection;

namespace SimpleTasksNet.Logging.Implementation
{
    public class Log4NetWrapper : ILogger
    {
        private readonly ILog _logger;

        public Log4NetWrapper()
        {
            _logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType); 
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
