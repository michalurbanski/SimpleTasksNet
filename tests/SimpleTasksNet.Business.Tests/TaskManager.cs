using System.Collections.Generic;
using System.Linq;

namespace SimpleTasksNet.Business.Tests
{
    internal class TaskManager
    {
        internal IEnumerable<DelayedTask> FindDelayedTasks(List<CustomTask> tasks)
        {
            if(tasks == null || tasks.Count == 0)
            {
                return new List<DelayedTask>(); 
            }

            return tasks.OfType<DelayedTask>();
        }
    }
}