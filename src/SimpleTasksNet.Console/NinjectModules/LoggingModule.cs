using Ninject.Modules;
using SimpleTasksNet.Logging.Implementation;
using SimpleTasksNet.Logging.Interfaces;
using System;
using System.Reflection;

namespace SimpleTasksNet.Console.NinjectModules
{
    // Class has to be public, otherwise it's not visible by ninject and won't be loaded to the kernel
    public class LoggingModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<Type>().ToMethod(s => s.Request.ParentRequest.Service.FullName.GetType());

            Bind<ILogger>().To<Log4NetWrapper>()
                .InSingletonScope()
                .WithConstructorArgument(MethodBase.GetCurrentMethod().DeclaringType);

            
        }
    }
}
