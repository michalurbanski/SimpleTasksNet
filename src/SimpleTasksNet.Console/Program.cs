using Ninject;
using SimpleTasksNet.Console.NinjectModules;
using SimpleTasksNet.Logging.Implementation;
using SimpleTasksNet.Logging.Interfaces;
using System;
using System.Reflection;

namespace SimpleTasksNet.Console
{
    class Program
    {
        //private static readonly ILogger _logger = LogManager.GetLogger(typeof(Program)); 

        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(AppDomain.CurrentDomain.GetAssemblies());

            ProgramLogic programLogic = new ProgramLogic(kernel.Get<ILogger>());
            programLogic.Execute(); 

           //_logger.Info("Program started");
        }
    }
}
