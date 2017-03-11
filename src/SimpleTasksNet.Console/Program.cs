using Ninject;
using SimpleTasksNet.Logging.Implementation;
using SimpleTasksNet.Logging.Interfaces;
using System;

namespace SimpleTasksNet.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(AppDomain.CurrentDomain.GetAssemblies()); // will load all modules

            kernel.Bind<ILogger>().To<Log4NetWrapper>().InSingletonScope(); 

            ProgramLogic programLogic = new ProgramLogic(kernel.Get<ILogger>());
            programLogic.Execute(); 
        }
    }
}
