using SimpleTasksNet.Logging.Implementation;
using SimpleTasksNet.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasksNet.Console
{
    class Program
    {
        private static readonly ILogger _logger = LogManager.GetLogger(typeof(Program)); 

        static void Main(string[] args)
        {
            _logger.Info("Progam started");
        }
    }
}
