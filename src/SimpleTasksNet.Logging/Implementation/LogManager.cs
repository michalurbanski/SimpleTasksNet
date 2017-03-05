using SimpleTasksNet.Logging.Interfaces;
using System;

namespace SimpleTasksNet.Logging.Implementation
{
    public static class LogManager
    {
        public static ILogger GetLogger(Type type)
        {
            //return new Log4NetWrapper(type); 
            throw new NotImplementedException(); 
        }
    }
}
