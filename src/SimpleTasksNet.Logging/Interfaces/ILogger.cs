using System;

namespace SimpleTasksNet.Logging.Interfaces
{
    public interface ILogger
    {
        bool IsDebugEnabled { get; }
        void Error(string message, Exception ex = null);
        void Info(string message);
    }
}
